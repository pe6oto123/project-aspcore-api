using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using project_api.Contexts;
using project_api.Entities;

namespace project_api.Controllers.University
{
	[Route("api/[controller]")]
	[ApiController]
	public class DepartmentsController : ControllerBase
	{
		private readonly DatabaseContext _context;

		public DepartmentsController(DatabaseContext context)
		{
			_context = context;
		}

		// GET: api/Departments
		[HttpGet]
		public async Task<ActionResult<IEnumerable<Departments>>> GetDepartments()
		{
			if (_context.Departments == null)
			{
				return NotFound();
			}
			return await _context.Departments
				.Include(s => s.University)
				.Include(s => s.University.Address)
				.ToListAsync();
		}

		// GET: api/Departments/5
		[HttpGet("{id}")]
		public async Task<ActionResult<Departments>> GetDepartments(int id)
		{
			if (_context.Departments == null)
			{
				return NotFound();
			}
			var departments = await _context.Departments
				.Include(s => s.University)
				.Include(s => s.University.Address)
				.SingleOrDefaultAsync(s => s.Id == id);

			if (departments == null)
			{
				return NotFound();
			}

			return departments;
		}

		[HttpGet("University/{universityId}")]
		public async Task<ActionResult<IEnumerable<Departments>>> GetDepartmentsInUniversity(int universityId)
		{
			if (_context.Departments == null || _context.Universities == null)
			{
				return NotFound();
			}

			return await _context.Departments
				.Include(s => s.University)
				.Where(s => s.University.Id == universityId)
				.ToListAsync();
		}

		// PUT: api/Departments/5
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPut("{id}")]
		public async Task<IActionResult> PutDepartments(int id, Departments departments)
		{
			if (id != departments.Id)
			{
				return BadRequest();
			}

			_context.Departments.Attach(departments);
			_context.Entry(departments).Reference(s => s.University).IsModified = true;
			if (departments.University != null)
				_context.Entry(departments.University).Reference(s => s.Address).IsModified = true;
			_context.Entry(departments).State = EntityState.Modified;

			try
			{
				await _context.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!DepartmentsExists(id))
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

		// POST: api/Departments
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPost]
		public async Task<ActionResult<Departments>> PostDepartments(Departments departments)
		{
			if (_context.Departments == null)
			{
				return Problem("Entity set 'DatabaseContext.Departments'  is null.");
			}

			if (departments.University == null)
				_context.Entry(departments).Reference(s => s.University).IsModified = true;
			_context.Departments.Attach(departments);
			_context.Departments.Add(departments);
			await _context.SaveChangesAsync();

			return CreatedAtAction("GetDepartments", new { id = departments.Id }, departments);
		}

		// DELETE: api/Departments/5
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteDepartments(int id)
		{
			if (_context.Departments == null)
			{
				return NotFound();
			}
			var departments = await _context.Departments.FindAsync(id);
			if (departments == null)
			{
				return NotFound();
			}

			_context.Subjects.Include(s => s.Department).Where(s => s.Department.Id == id).Load();
			_context.Departments.Remove(departments);
			await _context.SaveChangesAsync();

			return NoContent();
		}

		private bool DepartmentsExists(int id)
		{
			return (_context.Departments?.Any(e => e.Id == id)).GetValueOrDefault();
		}
	}
}
