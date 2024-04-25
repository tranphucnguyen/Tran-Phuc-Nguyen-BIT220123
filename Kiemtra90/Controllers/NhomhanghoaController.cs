using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kiemtra90.Model;

namespace Kiemtra90.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NhomhanghoaController : ControllerBase
    {
        private readonly AppDbContext _context;

        public NhomhanghoaController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Nhomhanghoa
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Nhomhanghoa>>> GetNhomhanghoa()
        {
            return await _context.Nhomhanghoa.ToListAsync();
        }

        // GET: api/Nhomhanghoa/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Nhomhanghoa>> GetNhomhanghoa(int id)
        {
            var nhomhanghoa = await _context.Nhomhanghoa.FindAsync(id);

            if (nhomhanghoa == null)
            {
                return NotFound();
            }

            return nhomhanghoa;
        }

        // POST: api/Nhomhanghoa
        [HttpPost]
        public async Task<ActionResult<Nhomhanghoa>> PostNhomhanghoa(Nhomhanghoa nhomhanghoa)
        {
            _context.Nhomhanghoa.Add(nhomhanghoa);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetNhomhanghoa", new { id = nhomhanghoa.NHH_ID }, nhomhanghoa);
        }

        // PUT: api/Nhomhanghoa/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNhomhanghoa(int id, Nhomhanghoa nhomhanghoa)
        {
            if (id != nhomhanghoa.NHH_ID)
            {
                return BadRequest();
            }

            _context.Entry(nhomhanghoa).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NhomhanghoaExists(id))
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

        // DELETE: api/Nhomhanghoa/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Nhomhanghoa>> DeleteNhomhanghoa(int id)
        {
            var nhomhanghoa = await _context.Nhomhanghoa.FindAsync(id);
            if (nhomhanghoa == null)
            {
                return NotFound();
            }

            _context.Nhomhanghoa.Remove(nhomhanghoa);
            await _context.SaveChangesAsync();

            return nhomhanghoa;
        }

        private bool NhomhanghoaExists(int id)
        {
            return _context.Nhomhanghoa.Any(e => e.NHH_ID == id);
        }
    }
}
