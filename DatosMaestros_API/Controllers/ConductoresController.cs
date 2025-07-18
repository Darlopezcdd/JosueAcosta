﻿using System;
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
    public class ConductoresController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ConductoresController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Conductores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Conductor>>> GetConductor()
        {
            return await _context.Conductor.ToListAsync();
        }

        // GET: api/Conductores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Conductor>> GetConductor(int id)
        {
            var conductor = await _context.Conductor.FindAsync(id);

            if (conductor == null)
            {
                return NotFound();
            }

            return conductor;
        }

        // PUT: api/Conductores/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutConductor(int id, Conductor conductor)
        {
            if (id != conductor.Id)
            {
                return BadRequest();
            }

            _context.Entry(conductor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ConductorExists(id))
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

        // POST: api/Conductores
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Conductor>> PostConductor(Conductor conductor)
        {
            _context.Conductor.Add(conductor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetConductor", new { id = conductor.Id }, conductor);
        }

        // DELETE: api/Conductores/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteConductor(int id)
        {
            var conductor = await _context.Conductor.FindAsync(id);
            if (conductor == null)
            {
                return NotFound();
            }

            _context.Conductor.Remove(conductor);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ConductorExists(int id)
        {
            return _context.Conductor.Any(e => e.Id == id);
        }
    }
}
