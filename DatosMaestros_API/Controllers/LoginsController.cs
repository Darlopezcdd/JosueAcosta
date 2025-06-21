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
    public class LoginsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public LoginsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Logins
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Login>>> GetLogins()
        {
            return await _context.Login.ToListAsync();
        }

        // GET: api/Logins/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Login>> GetLogin(int id)
        {
            var login = await _context.Login.FindAsync(id);

            if (login == null)
            {
                return NotFound();
            }

            return login;
        }



        // POST: api/Logins
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Login>> PostLogin(Login login)
        {


            var log = await _context.Usuario.ToListAsync();

            foreach (var item in log)
            {
                if (login.NombreUsuario.Equals(item.NombreUsuario))
                {
                    if (login.Contraseña.Equals(item.Contraseña))
                    {
                        login.ResultadoLogin = true;
                    }
                    else
                    {
                        login.ResultadoLogin = false;

                    }
                }
                else
                {
                    login.ResultadoLogin = false;

                }
            }

            _context.Login.Add(login);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetLogin", new { id = login.Id }, login);
        }


    }
}
