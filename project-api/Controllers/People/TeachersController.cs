using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
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
            return await _context.Teachers.ToListAsync();
        }

        // GET: api/Teachers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Teachers>> GetTeachers(int id)
        {
          if (_context.Teachers == null)
          {
              return NotFound();
          }
            var teachers = await _context.Teachers.FindAsync(id);

            if (teachers == null)
            {
                return NotFound();
            }

            return teachers;
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

            _context.Entry(teachers).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
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
            var teachers = await _context.Teachers.FindAsync(id);
            if (teachers == null)
            {
                return NotFound();
            }

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
