using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using project_api.Contexts;
using project_api.Entities;

namespace project_api.Controllers.People
{
	[Route("api/[controller]")]
	[ApiController]
	public class StudentsController : ControllerBase
	{
		private readonly DatabaseContext _context;

		public StudentsController(DatabaseContext context)
		{
			_context = context;
		}

		// GET: api/Students
		[HttpGet]
		public async Task<ActionResult<IEnumerable<Students>>> GetStudents()
		{
			if (_context.Students == null)
			{
				return NotFound();
			}
			return await _context.Students
				 .Include(s => s.Universities)
				 .Include(s => s.Department)
				 .Include(s => s.Address)
				 .Include(s => s.Address.City)
				 .ToListAsync();
		}

		// GET: api/Students/5
		[HttpGet("{id}")]
		public async Task<ActionResult<Students>> GetStudents(int id)
		{
			if (_context.Students == null)
			{
				return NotFound();
			}
			var students = await _context.Students
				.Include(s => s.Universities)
				.Include(s => s.Department)
				.Include(s => s.Address)
				.Include(s => s.Address.City)
				.Include(s => s.StudentsSubjects)
				.SingleOrDefaultAsync(s => s.Id == id);

			if (students == null)
			{
				return NotFound();
			}

			return students;
		}

		[HttpGet("SubjectsIds/{id}")]
		public async Task<ActionResult<IEnumerable<int>>> GetSubjectsIds(int id)
		{
			if (_context.Teachers == null)
			{
				return NotFound();
			}

			var studentsSubjects = await _context.StudentsSubjects
				.Where(s => s.StudentsId == id)
				.ToListAsync();

			var ids = studentsSubjects.Select(s => s.SubjectsId).ToList();

			return ids.ToList();
		}

		// PUT: api/Students/5
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPut("{id}")]
		public async Task<IActionResult> PutStudents(int id, Students students)
		{
			if (id != students.Id)
			{
				return BadRequest();
			}
			try
			{
				var studentsSubjects = new List<StudentsSubjects>();
				if (students.StudentsSubjects != null)
					studentsSubjects.AddRange(students.StudentsSubjects);

				await _context.StudentsSubjects.LoadAsync();
				if (await _context.StudentsSubjects.Where(s => s.StudentsId == students.Id).AnyAsync())
				{
					var studentParent = await _context.Students
						.Include(s => s.StudentsSubjects)
						.SingleAsync(s => s.Id == students.Id);

					foreach (var s in studentParent.StudentsSubjects)
						_context.Entry(s).State = EntityState.Deleted;
				}

				await _context.SaveChangesAsync();
				_context.ChangeTracker.Clear();

				if (students.Address != null)
					_context.Entry(students.Address).Reference(s => s.City).IsModified = true;
				if (students.Address.City != null)
					_context.Update(students.Address.City).State = EntityState.Modified;
				if (students.Universities != null)
					_context.Entry(students.Universities).State = EntityState.Detached;

				if (students.Address != null)
					_context.Entry(students).Reference(s => s.Universities).IsModified = true;
				if (students.Universities != null)
					_context.Update(students.Universities).State = EntityState.Modified;
				//if (students.Department != null)
				//_context.Entry(students.Department).Reference(s => s.TeachersDepartments).IsModified = false;
				//_context.Entry(students).Reference(s => s.Department).IsModified = true;
				_context.Entry(students.Department).State = EntityState.Modified;
				_context.Entry(students).State = EntityState.Modified;

				await _context.SaveChangesAsync();
				_context.ChangeTracker.Clear();

				/*_context.Update(students).State = EntityState.Modified;

				await _context.SaveChangesAsync();*/
				_context.Entry(students).State = EntityState.Detached;
				_context.ChangeTracker.Clear();

				if (studentsSubjects != null)
				{
					if (students.StudentsSubjects != null)
						_context.StudentsSubjects.AttachRange(students.StudentsSubjects);
					foreach (var item in studentsSubjects)
						_context.Entry(item).State = EntityState.Added;

					await _context.SaveChangesAsync();
				}

				_context.Entry(students).State = EntityState.Modified;
				await _context.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!StudentsExists(id))
				{
					return NotFound();
				}
				else
				{
					throw;
				}
			}

			return NoContent();
		}

		// POST: api/Students
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPost]
		public async Task<ActionResult<Students>> PostStudents(Students students)
		{
			if (_context.Students == null)
			{
				return Problem("Entity set 'DatabaseContext.Students'  is null.");
			}

			List<long> excludeList = new();
			try
			{
				excludeList.AddRange(
					(await _context.Students
						.Select(s => s.FacultyNumber ?? "")
						.ToListAsync())
						.Select(s => long.Parse(s)).ToList()
					);
			}
			catch (FormatException) { }

			students.FacultyNumber = GenerateFacultyNumber(
					students.EnrolmentDate,
					students.Department.Id,
					excludeList
				);

			_context.Students.Attach(students);
			_context.Students.Add(students);
			await _context.SaveChangesAsync();

			return CreatedAtAction("GetStudents", new { id = students.Id }, students);
		}

		// DELETE: api/Students/5
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteStudents(int id)
		{
			if (_context.Students == null)
			{
				return NotFound();
			}
			var students = await _context.Students.FindAsync(id);
			if (students == null)
			{
				return NotFound();
			}

			_context.Students.Remove(students);
			await _context.SaveChangesAsync();

			return NoContent();
		}

		private bool StudentsExists(int id)
		{
			return (_context.Students?.Any(e => e.Id == id)).GetValueOrDefault();
		}

		private static string? GenerateFacultyNumber(DateTime enrolment, int department, List<long> excludeList)
		{
			if (!excludeList.Any())
				excludeList.Add(0);
			long? facultyNum = null;
			try
			{
				for (long i = 0; i < excludeList.Count; i++)
				{
					facultyNum = long.Parse(enrolment.Date.ToString("yyMM") + department.ToString("D2"))
						* 1000000 + new Random().Next(0, 999999);

					if (!excludeList.Contains((long)facultyNum))
						break;
				}
			}
			catch (FormatException) { }

			return facultyNum.ToString();
		}
	}
}
