using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Log_Modelos;

namespace LogSensores_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlertaMantenimientosController : ControllerBase
    {
        private readonly AppDbSensoresContext _context;

        public AlertaMantenimientosController(AppDbSensoresContext context)
        {
            _context = context;
        }

        // GET: api/AlertaMantenimientos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AlertaMantenimiento>>> GetAlertaMantenimiento()
        {
            return await _context.AlertaMantenimiento.ToListAsync();
        }

        // GET: api/AlertaMantenimientos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AlertaMantenimiento>> GetAlertaMantenimiento(int id)
        {
            var alertaMantenimiento = await _context.AlertaMantenimiento.FindAsync(id);

            if (alertaMantenimiento == null)
            {
                return NotFound();
            }

            return alertaMantenimiento;
        }

        // PUT: api/AlertaMantenimientos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAlertaMantenimiento(int id, AlertaMantenimiento alertaMantenimiento)
        {
            if (id != alertaMantenimiento.Id)
            {
                return BadRequest();
            }

            _context.Entry(alertaMantenimiento).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AlertaMantenimientoExists(id))
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

        // POST: api/AlertaMantenimientos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AlertaMantenimiento>> PostAlertaMantenimiento(AlertaMantenimiento alertaMantenimiento)
        {
            _context.AlertaMantenimiento.Add(alertaMantenimiento);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAlertaMantenimiento", new { id = alertaMantenimiento.Id }, alertaMantenimiento);
        }

        // DELETE: api/AlertaMantenimientos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAlertaMantenimiento(int id)
        {
            var alertaMantenimiento = await _context.AlertaMantenimiento.FindAsync(id);
            if (alertaMantenimiento == null)
            {
                return NotFound();
            }

            _context.AlertaMantenimiento.Remove(alertaMantenimiento);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AlertaMantenimientoExists(int id)
        {
            return _context.AlertaMantenimiento.Any(e => e.Id == id);
        }
    }
}
