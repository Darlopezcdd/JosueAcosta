using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DatosMaestros_Modelos;

namespace DatosMaestros_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MantenimientoProgramadosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MantenimientoProgramadosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/MantenimientoProgramados
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MantenimientoProgramado>>> GetMantenimientoProgramado()
        {
            return await _context.MantenimientoProgramado.ToListAsync();
        }

        // GET: api/MantenimientoProgramados/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MantenimientoProgramado>> GetMantenimientoProgramado(int id)
        {
            var mantenimientoProgramado = await _context.MantenimientoProgramado.FindAsync(id);

            if (mantenimientoProgramado == null)
            {
                return NotFound();
            }

            return mantenimientoProgramado;
        }

        // PUT: api/MantenimientoProgramados/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMantenimientoProgramado(int id, MantenimientoProgramado mantenimientoProgramado)
        {
            if (id != mantenimientoProgramado.Id)
            {
                return BadRequest();
            }

            _context.Entry(mantenimientoProgramado).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MantenimientoProgramadoExists(id))
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

        // POST: api/MantenimientoProgramados
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MantenimientoProgramado>> PostMantenimientoProgramado(MantenimientoProgramado mantenimientoProgramado)
        {
            _context.MantenimientoProgramado.Add(mantenimientoProgramado);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMantenimientoProgramado", new { id = mantenimientoProgramado.Id }, mantenimientoProgramado);
        }

        // DELETE: api/MantenimientoProgramados/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMantenimientoProgramado(int id)
        {
            var mantenimientoProgramado = await _context.MantenimientoProgramado.FindAsync(id);
            if (mantenimientoProgramado == null)
            {
                return NotFound();
            }

            _context.MantenimientoProgramado.Remove(mantenimientoProgramado);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MantenimientoProgramadoExists(int id)
        {
            return _context.MantenimientoProgramado.Any(e => e.Id == id);
        }
    }
}
