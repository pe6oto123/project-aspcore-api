using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
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
          if (_context.Addresss == null)
          {
              return NotFound();
          }
            return await _context.Addresss.ToListAsync();
        }

        // GET: api/Addresses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Addresses>> GetAddresses(int id)
        {
          if (_context.Addresss == null)
          {
              return NotFound();
          }
            var addresses = await _context.Addresss.FindAsync(id);

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
          if (_context.Addresss == null)
          {
              return Problem("Entity set 'DatabaseContext.Addresss'  is null.");
          }
            _context.Addresss.Add(addresses);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAddresses", new { id = addresses.Id }, addresses);
        }

        // DELETE: api/Addresses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAddresses(int id)
        {
            if (_context.Addresss == null)
            {
                return NotFound();
            }
            var addresses = await _context.Addresss.FindAsync(id);
            if (addresses == null)
            {
                return NotFound();
            }

            _context.Addresss.Remove(addresses);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AddressesExists(int id)
        {
            return (_context.Addresss?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
