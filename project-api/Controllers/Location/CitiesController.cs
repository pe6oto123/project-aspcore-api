using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using project_api.Contexts;
using project_api.Entities;

namespace project_api.Controllers.Location
{
	[Route("api/[controller]")]
	[ApiController]
	public class CitiesController : ControllerBase
	{
		private readonly DatabaseContext _context;

		public CitiesController(DatabaseContext context)
		{
			_context = context;
		}

		// GET: api/Cities
		[HttpGet]
		public async Task<ActionResult<IEnumerable<Cities>>> GetCities(int? countryId)
		{
			if (_context.Cities == null)
			{
				return NotFound();
			}
			if (countryId != null)
			{
				var cities = await _context.Cities.Include(s => s.Country).Where(s => s.Country.Id == countryId).ToListAsync();
				if (!cities.Any())
					return NotFound();
				return cities;
			}
			return await _context.Cities.Include(s => s.Country).ToListAsync();
		}

		// GET: api/Cities/5
		[HttpGet("{id}")]
		public async Task<ActionResult<Cities>> GetCities(int id)
		{
			if (_context.Cities == null)
			{
				return NotFound();
			}
			var cities = await _context.Cities.Include(s => s.Country).Where(s => s.Id == id).FirstOrDefaultAsync();

			if (cities == null)
			{
				return NotFound();
			}

			return cities;
		}

		// PUT: api/Cities/5
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPut("{id}")]
		public async Task<IActionResult> PutCities(int id, Cities cities)
		{
			if (id != cities.Id)
				return BadRequest();

			//	AsNoTracking() => creates a read-only entry and its not tracked when updating the state
			var country = await _context.Countries.AsNoTracking().Where(s => s.Id == cities.Country.Id).FirstOrDefaultAsync();
			if (JsonConvert.SerializeObject(cities.Country) != JsonConvert.SerializeObject(country))
				return BadRequest(new
				{
					title = "Bad Request",
					status = 400,
					reason = "Country with set parameters do not exist"
				});

			_context.Update(cities).State = EntityState.Modified;
			try
			{
				await _context.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!CitiesExists(id))
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

		// POST: api/Cities
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPost]
		public async Task<ActionResult<Cities>> PostCities(Cities cities)
		{
			if (_context.Cities == null)
			{
				return Problem("Entity set 'DatabaseContext.Cities'  is null.");
			}

			//	EntityState.Added => used to add an exsiting entry linked to the primary and only checks the id
			_context.Entry(cities).State = EntityState.Added;
			_context.Cities.Add(cities);
			await _context.SaveChangesAsync();

			return CreatedAtAction("GetCities", new { id = cities.Id }, cities);
		}

		// DELETE: api/Cities/5
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteCities(int id)
		{
			if (_context.Cities == null)
			{
				return NotFound();
			}
			var cities = await _context.Cities.FindAsync(id);
			if (cities == null)
			{
				return NotFound();
			}

			_context.Address.Include(s => s.City).Where(s => s.City.Id == id).Load();
			_context.Cities.Remove(cities);
			await _context.SaveChangesAsync();

			return NoContent();
		}

		private bool CitiesExists(int id)
		{
			return (_context.Cities?.Any(e => e.Id == id)).GetValueOrDefault();
		}
	}
}
