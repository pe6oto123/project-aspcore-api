using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using project_api.Contexts;
using project_api.Entities;

namespace project_api.Controllers.Location
{
	[Route("api/[controller]")]
	[ApiController]
	public class AddressesController : ControllerBase
	{
		private readonly DatabaseContext _context;

		public AddressesController(DatabaseContext context)
		{
			_context = context;
		}

		// GET: api/Addresses
		[HttpGet]
		public async Task<ActionResult<IEnumerable<Addresses>>> GetAddresss()
		{
			if (_context.Address == null)
			{
				return NotFound();
			}
			return await _context.Address.Include(s => s.City).ThenInclude(s => s.Country).ToListAsync();
		}

		// GET: api/Addresses/5
		[HttpGet("{id}")]
		public async Task<ActionResult<Addresses>> GetAddresses(int id)
		{
			if (_context.Address == null)
			{
				return NotFound();
			}
			var addresses = await _context.Address.FindAsync(id);

			if (addresses == null)
			{
				return NotFound();
			}

			return addresses;
		}

		// PUT: api/Addresses/5
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPut("{id}")]
		public async Task<IActionResult> PutAddresses(int id, Addresses addresses)
		{
			if (id != addresses.Id)
			{
				return BadRequest();
			}

			_context.Entry(addresses).State = EntityState.Modified;

			try
			{
				await _context.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!AddressesExists(id))
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

		// POST: api/Addresses
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPost]
		public async Task<ActionResult<Addresses>> PostAddresses(Addresses addresses)
		{
			if (_context.Address == null)
			{
				return Problem("Entity set 'DatabaseContext.Addresss'  is null.");
			}
			_context.Address.Add(addresses);
			await _context.SaveChangesAsync();

			return CreatedAtAction("GetAddresses", new { id = addresses.Id }, addresses);
		}

		// DELETE: api/Addresses/5
		[HttpDelete("{id}&{parentTable}")]
		public async Task<IActionResult> DeleteAddresses(int id, string? parentTable = null)
		{
			List<string> parentTables = new()
			{
				"universities",
				"teachers",
				"students"
			};

			if (!parentTables.Contains(parentTable != null ? parentTable.ToString() : ""))
				return BadRequest();

			if (_context.Address == null)
			{
				return NotFound();
			}
			var addresses = await _context.Address.FindAsync(id);
			if (addresses == null)
			{
				return NotFound();
			}

			switch (parentTable)
			{
				case "universities":
					_context.Universities.Include(s => s.Address).Where(s => s.Address.Id == id).Load();
					break;

				case "teachers":
					_context.Teachers.Include(s => s.Address).Where(s => s.Address.Id == id).Load();
					break;

				case "students":
					_context.Students.Include(s => s.Address).Where(s => s.Address.Id == id).Load();
					break;
				default:
					return BadRequest();
			}

			_context.Address.Remove(addresses);

			return NoContent();
		}

		private bool AddressesExists(int id)
		{
			return (_context.Address?.Any(e => e.Id == id)).GetValueOrDefault();
		}
	}
}
