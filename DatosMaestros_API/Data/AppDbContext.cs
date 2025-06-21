using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DatosMaestros_Modelos;

    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

public DbSet<DatosMaestros_Modelos.Camion> Camion { get; set; } = default!;

public DbSet<DatosMaestros_Modelos.Conductor> Conductor { get; set; } = default!;

public DbSet<DatosMaestros_Modelos.MantenimientoProgramado> MantenimientoProgramado { get; set; } = default!;

public DbSet<DatosMaestros_Modelos.Taller> Taller { get; set; } = default!;

public DbSet<DatosMaestros_Modelos.Login> Login { get; set; } = default!;

public DbSet<DatosMaestros_Modelos.Usuario> Usuario { get; set; } = default!;


        
    }
