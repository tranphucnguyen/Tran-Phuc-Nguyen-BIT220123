using Kiemtra90.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Kiemtra90.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HanghoaController : ControllerBase
    {
        private readonly AppDbContext _context;

        public HanghoaController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Hanghoa
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Hanghoa>>> GetHanghoa()
        {
            return await _context.Hanghoa.ToListAsync();
        }

        // GET: api/Hanghoa/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Hanghoa>> GetHanghoa(int id)
        {
            var hanghoa = await _context.Hanghoa.FindAsync(id);

            if (hanghoa == null)
            {
                return NotFound();
            }

            return hanghoa;
        }

        // POST: api/Hanghoa
        [HttpPost]
        public async Task<ActionResult<Hanghoa>> PostHanghoa(Hanghoa hanghoa)
        {
            _context.Hanghoa.Add(hanghoa);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHanghoa", new { id = hanghoa.HH_ID }, hanghoa);
        }

        // PUT: api/Hanghoa/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHanghoa(int id, Hanghoa hanghoa)
        {
            if (id != hanghoa.HH_ID)
            {
                return BadRequest();
            }

            _context.Entry(hanghoa).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HanghoaExists(id))
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

        // DELETE: api/Hanghoa/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Hanghoa>> DeleteHanghoa(int id)
        {
            var hanghoa = await _context.Hanghoa.FindAsync(id);
            if (hanghoa == null)
            {
                return NotFound();
            }

            _context.Hanghoa.Remove(hanghoa);
            await _context.SaveChangesAsync();

            return hanghoa;
        }

        private bool HanghoaExists(int id)
        {
            return _context.Hanghoa.Any(e => e.HH_ID == id);
        }
    }
}
