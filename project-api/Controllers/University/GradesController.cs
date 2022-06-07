using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using project_api.Contexts;
using project_api.Entities;

namespace project_api.Controllers.University
{
	[Route("api/[controller]")]
	[ApiController]
	public class GradesController : ControllerBase
	{
		private readonly DatabaseContext _context;

		public GradesController(DatabaseContext context)
		{
			_context = context;
		}

		// GET: api/StudentsSubjects
		[HttpGet]
		public async Task<ActionResult<IEnumerable<StudentsSubjects>>> GetStudentsSubjects()
		{
			if (_context.StudentsSubjects == null)
			{
				return NotFound();
			}
			return await _context.StudentsSubjects.ToListAsync();
		}

		// GET: api/StudentsSubjects/5
		[HttpGet("{id}")]
		public async Task<ActionResult<StudentsSubjects>> GetStudentsSubjects(int id)
		{
			if (_context.StudentsSubjects == null)
			{
				return NotFound();
			}
			var studentsSubjects = await _context.StudentsSubjects.FindAsync(id);

			if (studentsSubjects == null)
			{
				return NotFound();
			}

			return studentsSubjects;
		}

		// PUT: api/StudentsSubjects/5
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPut("{id}")]
		public async Task<IActionResult> PutStudentsSubjects(int id, StudentsSubjects studentsSubjects)
		{
			if (id != studentsSubjects.StudentsId)
			{
				return BadRequest();
			}

			_context.Entry(studentsSubjects).State = EntityState.Modified;

			try
			{
				await _context.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!StudentsSubjectsExists(id))
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

		// POST: api/StudentsSubjects
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPost]
		public async Task<ActionResult<StudentsSubjects>> PostStudentsSubjects(StudentsSubjects studentsSubjects)
		{
			if (_context.StudentsSubjects == null)
			{
				return Problem("Entity set 'DatabaseContext.StudentsSubjects'  is null.");
			}
			_context.StudentsSubjects.Add(studentsSubjects);
			try
			{
				await _context.SaveChangesAsync();
			}
			catch (DbUpdateException)
			{
				if (StudentsSubjectsExists(studentsSubjects.StudentsId))
				{
					return Conflict();
				}
				else
				{
					throw;
				}
			}

			return CreatedAtAction("GetStudentsSubjects", new { id = studentsSubjects.StudentsId }, studentsSubjects);
		}

		private bool StudentsSubjectsExists(int id)
		{
			return (_context.StudentsSubjects?.Any(e => e.StudentsId == id)).GetValueOrDefault();
		}
	}
}
