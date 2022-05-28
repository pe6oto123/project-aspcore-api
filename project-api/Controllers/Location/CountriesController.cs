using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using project_api.Contexts;
using project_api.Entities;

namespace project_api.Controllers.Location
{
	[Route("api/[controller]")]
	[ApiController]
	public class CountriesController : ControllerBase
	{
		private readonly DatabaseContext _context;

		public CountriesController(DatabaseContext context)
		{
			_context = context;
		}

		// GET: api/Countries
		[HttpGet]
		public async Task<ActionResult<IEnumerable<Countries>>> GetCountries()
		{
			if (_context.Countries == null)
			{
				return NotFound();
			}
			return await _context.Countries.ToListAsync();
		}

		// GET: api/Countries/5
		[HttpGet("{id}")]
		public async Task<ActionResult<Countries>> GetCountries(int id)
		{
			if (_context.Countries == null)
			{
				return NotFound();
			}
			var countries = await _context.Countries.FindAsync(id);

			if (countries == null)
			{
				return NotFound();
			}

			return countries;
		}

		// PUT: api/Countries/5
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPut("{id}")]
		public async Task<IActionResult> PutCountries(int id, Countries countries)
		{
			if (id != countries.Id)
			{
				return BadRequest();
			}

			_context.Entry(countries).State = EntityState.Modified;

			try
			{
				await _context.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!CountriesExists(id))
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

		// POST: api/Countries
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPost]
		public async Task<ActionResult<Countries>> PostCountries(Countries countries)
		{
			if (_context.Countries == null)
			{
				return Problem("Entity set 'DatabaseContext.Countries'  is null.");
			}
			_context.Countries.Add(countries);
			await _context.SaveChangesAsync();

			return CreatedAtAction("GetCountries", new { id = countries.Id }, countries);
		}

		// DELETE: api/Countries/5
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteCountries(int id, bool forceDelete = false)
		{
			if (_context.Countries == null)
			{
				return NotFound();
			}
			var countries = await _context.Countries.FindAsync(id);
			if (countries == null)
			{
				return NotFound();
			}

			_context.Countries.Remove(countries);
			try
			{
				await _context.SaveChangesAsync();
			}
			catch (DbUpdateException ex)
			when (ex?.InnerException?.Message.Contains("foreign key constraint fails") ?? false)
			{
				if (forceDelete)
				{
					_context.Cities.Include(s => s.Country).Where(s => s.Country.Id == id).Single().Country = null;
					await _context.SaveChangesAsync();
					return NoContent();
				}

				return Conflict();
			}

			return NoContent();
		}

		private bool CountriesExists(int id)
		{
			return (_context.Countries?.Any(e => e.Id == id)).GetValueOrDefault();
		}
	}
}
