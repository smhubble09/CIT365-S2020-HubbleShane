using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Models;

namespace MyScriptureJournal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScripturesController : ControllerBase
    {
        private readonly MyScriptureJournalContext _context;

        public ScripturesController(MyScriptureJournalContext context)
        {
            _context = context;
        }

        // GET: api/Scriptures
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Scripture>>> GetScripture()
        {
            return await _context.Scripture.ToListAsync();
        }

        // GET: api/Scriptures/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Scripture>> GetScripture(int id)
        {
            var scripture = await _context.Scripture.FindAsync(id);

            if (scripture == null)
            {
                return NotFound();
            }

            return scripture;
        }

        // PUT: api/Scriptures/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutScripture(int id, Scripture scripture)
        {
            if (id != scripture.ID)
            {
                return BadRequest();
            }

            _context.Entry(scripture).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ScriptureExists(id))
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

        // POST: api/Scriptures
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Scripture>> PostScripture(Scripture scripture)
        {
            _context.Scripture.Add(scripture);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetScripture", new { id = scripture.ID }, scripture);
        }

        // DELETE: api/Scriptures/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Scripture>> DeleteScripture(int id)
        {
            var scripture = await _context.Scripture.FindAsync(id);
            if (scripture == null)
            {
                return NotFound();
            }

            _context.Scripture.Remove(scripture);
            await _context.SaveChangesAsync();

            return scripture;
        }

        private bool ScriptureExists(int id)
        {
            return _context.Scripture.Any(e => e.ID == id);
        }
    }
}
