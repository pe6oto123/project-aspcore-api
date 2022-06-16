using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using project_api.Contexts;
using project_api.Entities;

namespace project_api.Controllers.University
{
	[Route("api/[controller]")]
	[ApiController]
	public class SubjectsController : ControllerBase
	{
		private readonly DatabaseContext _context;

		public SubjectsController(DatabaseContext context)
		{
			_context = context;
		}

		// GET: api/Subjects
		[HttpGet]
		public async Task<ActionResult<IEnumerable<Subjects>>> GetSubjects()
		{
			if (_context.Subjects == null)
			{
				return NotFound();
			}

			return await _context.Subjects.Include(s => s.Department).ToListAsync();
		}

		// GET: api/Subjects/5
		[HttpGet("{id}")]
		public async Task<ActionResult<Subjects>> GetSubjects(int id)
		{
			if (_context.Subjects == null)
			{
				return NotFound();
			}

			var subjects = await _context.Subjects.Include(s => s.Department).Where(s => s.Id == id).SingleAsync();

			if (subjects == null)
			{
				return NotFound();
			}

			return subjects;
		}

		// GET: api/Subjects/Department/5
		[HttpGet("Department/{departmentId}")]
		public async Task<ActionResult<IEnumerable<Subjects>>> GetSubjectsInDepartment(int departmentId, bool isAlsoFree = false)
		{
			if (_context.Departments == null || _context.Subjects == null)
			{
				return NotFound();
			}

			if (isAlsoFree)
				return await _context.Subjects
				.Include(s => s.Department)
				.Where(s => s.Department.Id == departmentId || s.Department == null)
				.ToListAsync();

			return await _context.Subjects
				.Include(s => s.Department)
				.Where(s => s.Department.Id == departmentId)
				.ToListAsync();
		}

		// PUT: api/Subjects/5
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPut("{id}")]
		public async Task<IActionResult> PutSubjects(int id, Subjects subjects)
		{
			if (id != subjects.Id)
			{
				return BadRequest();
			}

			_context.Subjects.Attach(subjects);
			_context.Entry(subjects).Reference(s => s.Department).IsModified = true;
			if (subjects.Department != null)
				_context.Entry(subjects.Department).Reference(s => s.University).IsModified = false;
			_context.Entry(subjects).State = EntityState.Modified;

			try
			{
				await _context.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!SubjectsExists(id))
				{
					return NotFound();
				}
				else
				{
					throw;
				}

			}
			catch (DbUpdateException ex)
			{
				return BadRequest(
					new
					{
						title = "Bad Request",
						status = 400,
						reason = ex.InnerException.Message,
					});
			}

			return NoContent();
		}

		// POST: api/Subjects
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPost]
		public async Task<ActionResult<Subjects>> PostSubjects(Subjects subjects)
		{
			if (_context.Subjects == null)
			{
				return Problem("Entity set 'DatabaseContext.Subjects'  is null.");
			}
			_context.Entry(subjects).Reference(s => s.Department).IsModified = true;
			_context.Subjects.Attach(subjects);
			_context.Entry(subjects).State = EntityState.Added;
			//_context.Subjects.Add(subjects);
			await _context.SaveChangesAsync();

			return CreatedAtAction("GetSubjects", new { id = subjects.Id }, subjects);
		}

		// DELETE: api/Subjects/5
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteSubjects(int id)
		{
			if (_context.Subjects == null)
			{
				return NotFound();
			}
			var subjects = await _context.Subjects.FindAsync(id);
			if (subjects == null)
			{
				return NotFound();
			}

			_context.Subjects.Remove(subjects);
			await _context.SaveChangesAsync();

			return NoContent();
		}

		private bool SubjectsExists(int id)
		{
			return (_context.Subjects?.Any(e => e.Id == id)).GetValueOrDefault();
		}
	}
}
