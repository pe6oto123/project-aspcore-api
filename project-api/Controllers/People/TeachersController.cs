using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using project_api.Contexts;
using project_api.Entities;

namespace project_api.Controllers.People
{
	[Route("api/[controller]")]
	[ApiController]
	public class TeachersController : ControllerBase
	{
		private readonly DatabaseContext _context;

		public TeachersController(DatabaseContext context)
		{
			_context = context;
		}

		// GET: api/Teachers
		[HttpGet]
		public async Task<ActionResult<IEnumerable<Teachers>>> GetTeachers()
		{
			if (_context.Teachers == null)
			{
				return NotFound();
			}
			return await _context.Teachers
				.Include(s => s.Address)
				.Include(s => s.Address.City)
				.Include(s => s.Universities)
				.ToListAsync();
		}

		// GET: api/Teachers/5
		[HttpGet("{id}")]
		public async Task<ActionResult<Teachers>> GetTeachers(int id)
		{
			if (_context.Teachers == null)
			{
				return NotFound();
			}
			var teachers = await _context.Teachers
				.Include(s => s.Address)
				.Include(s => s.Address.City)
				.Include(s => s.Universities)
				.Include(s => s.TeachersDepartments)
				.SingleOrDefaultAsync(s => s.Id == id);

			if (teachers == null)
			{
				return NotFound();
			}

			return teachers;
		}

		[HttpGet("DepartmentsIds/{id}")]
		public async Task<ActionResult<IEnumerable<int>>> GetDepartmentsIds(int id)
		{
			if (_context.Teachers == null)
			{
				return NotFound();
			}

			var teachersDepartments = await _context.TeachersDepartments
				.Where(s => s.TeachersId == id)
				.ToListAsync();

			var ids = teachersDepartments.Select(s => s.DepartmentsId).ToList();

			return ids.ToList();
		}

		// PUT: api/Teachers/5
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPut("{id}")]
		public async Task<IActionResult> PutTeachers(int id, Teachers teachers)
		{
			if (id != teachers.Id)
			{
				return BadRequest();
			}
			#region Backup
			/*_context.Teachers.Attach(teachers);
			*//*foreach (var item in teachers.TeachersDepartments)
				_context.TeachersDepartments.Attach(item);*//*
			var test = new List<TeachersDepartments>();
			test = teachers.TeachersDepartments.ToList();
			_context.TeachersDepartments.AttachRange(test);

			await _context.TeachersDepartments.LoadAsync();

			if (await _context.TeachersDepartments.Where(s => s.TeachersId == teachers.Id).AnyAsync())
				teachers.TeachersDepartments.Clear();
			//(await _context.TeachersDepartments.Where(s => s.TeachersId == teachers.Id).ToListAsync()).Clear();
			//teachers.TeachersDepartments.Clear();

			*//*if (teachers.TeachersDepartments != null)
				await _context.TeachersDepartments.AddRangeAsync(test);*//*

			if (teachers.Universities.Address != null)
				_context.Entry(teachers.Universities.Address).Reference(s => s.City).IsModified = true;

			_context.Update(teachers).State = EntityState.Modified;

			try
			{
				await _context.SaveChangesAsync();
				_context.Entry(teachers).State = EntityState.Detached;
				//_context.Update(test).State = EntityState.Modified;
				foreach (var item in test)
					_context.Entry(item).State = EntityState.Added;
				await _context.SaveChangesAsync();
			}*/
			#endregion
			try
			{
				var teachersDepartments = new List<TeachersDepartments>();
				if (teachers.TeachersDepartments != null)
					teachersDepartments.AddRange(teachers.TeachersDepartments);

				await _context.TeachersDepartments.LoadAsync();
				if (await _context.TeachersDepartments.Where(s => s.TeachersId == teachers.Id).AnyAsync())
				{
					var teacherParent = await _context.Teachers
						.Include(s => s.TeachersDepartments)
						.SingleAsync(s => s.Id == teachers.Id);

					foreach (var department in teacherParent.TeachersDepartments)
						_context.Entry(department).State = EntityState.Deleted;
				}

				await _context.SaveChangesAsync();
				_context.ChangeTracker.Clear();
				//_context.Teachers.Attach(teachers);

				if (teachers.Address != null)
					_context.Entry(teachers.Address).Reference(s => s.City).IsModified = true;
				if (teachers.Address.City != null)
					_context.Update(teachers.Address.City).State = EntityState.Modified;
				_context.Update(teachers).State = EntityState.Modified;

				await _context.SaveChangesAsync();
				_context.Entry(teachers).State = EntityState.Detached;
				_context.ChangeTracker.Clear();

				if (teachersDepartments != null)
				{
					_context.TeachersDepartments.AttachRange(teachersDepartments);
					foreach (var item in teachersDepartments)
						_context.Entry(item).State = EntityState.Added;

					await _context.SaveChangesAsync();
				}
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!TeachersExists(id))
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

		// POST: api/Teachers
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPost]
		public async Task<ActionResult<Teachers>> PostTeachers(Teachers teachers)
		{
			if (_context.Teachers == null)
			{
				return Problem("Entity set 'DatabaseContext.Teachers'  is null.");
			}

			_context.Teachers.Attach(teachers);

			if (teachers.Universities.Address != null)
				_context.Entry(teachers.Universities.Address).Reference(s => s.City).IsModified = true;

			_context.Teachers.Add(teachers);
			await _context.SaveChangesAsync();

			return CreatedAtAction("GetTeachers", new { id = teachers.Id }, teachers);
		}

		// DELETE: api/Teachers/5
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteTeachers(int id)
		{
			if (_context.Teachers == null)
			{
				return NotFound();
			}
			var teachers = await _context.Teachers
				.Include(s => s.Address)
				.SingleOrDefaultAsync(s => s.Id == id);
			if (teachers == null)
			{
				return NotFound();
			}

			if (teachers.Address != null)
				_context.Entry(teachers.Address).State = EntityState.Deleted;
			_context.Teachers.Remove(teachers);
			await _context.SaveChangesAsync();

			return NoContent();
		}

		private bool TeachersExists(int id)
		{
			return (_context.Teachers?.Any(e => e.Id == id)).GetValueOrDefault();
		}
	}
}
