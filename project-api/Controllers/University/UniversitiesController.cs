using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using project_api.Contexts;
using project_api.Entities;

namespace project_api.Controllers.University
{
	[Route("api/[controller]")]
	[ApiController]
	public class UniversitiesController : ControllerBase
	{
		private readonly DatabaseContext _context;

		public UniversitiesController(DatabaseContext context)
		{
			_context = context;
		}

		// GET: api/Universities
		[HttpGet]
		public async Task<ActionResult<IEnumerable<Universities>>> GetUniversities()
		{
			if (_context.Universities == null)
			{
				return NotFound();
			}
			return await _context.Universities.ToListAsync();
		}

		// GET: api/Universities/5
		[HttpGet("{id}")]
		public async Task<ActionResult<Universities>> GetUniversities(int id)
		{
			if (_context.Universities == null)
			{
				return NotFound();
			}
			var universities = await _context.Universities.FindAsync(id);

			if (universities == null)
			{
				return NotFound();
			}

			return universities;
		}

		// PUT: api/Universities/5
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPut("{id}")]
		public async Task<IActionResult> PutUniversities(int id, Universities universities)
		{
			if (id != universities.Id)
			{
				return BadRequest();
			}

			_context.Entry(universities).State = EntityState.Modified;

			try
			{
				await _context.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!UniversitiesExists(id))
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

		// POST: api/Universities
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPost]
		public async Task<ActionResult<Universities>> PostUniversities(Universities universities)
		{
			if (_context.Universities == null)
			{
				return Problem("Entity set 'DatabaseContext.Universities'  is null.");
			}
			_context.Universities.Add(universities);
			await _context.SaveChangesAsync();

			return CreatedAtAction("GetUniversities", new { id = universities.Id }, universities);
		}

		// DELETE: api/Universities/5
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteUniversities(int id)
		{
			if (_context.Universities == null)
			{
				return NotFound();
			}
			var universities = await _context.Universities.FindAsync(id);
			if (universities == null)
			{
				return NotFound();
			}

			_context.Students.Include(s => s.Universities).Where(s => s.Universities.Id == id).Load();
			_context.Teachers.Include(s => s.Universities).Where(s => s.Universities.Id == id).Load();
			_context.Universities.Remove(universities);
			await _context.SaveChangesAsync();

			return NoContent();
		}

		private bool UniversitiesExists(int id)
		{
			return (_context.Universities?.Any(e => e.Id == id)).GetValueOrDefault();
		}
	}
}
