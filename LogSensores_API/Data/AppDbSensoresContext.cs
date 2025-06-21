using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Log_Modelos;

    public class AppDbSensoresContext : DbContext
    {
        public AppDbSensoresContext (DbContextOptions<AppDbSensoresContext> options)
            : base(options)
        {
        }

        public DbSet<Log_Modelos.AlertaMantenimiento> AlertaMantenimiento { get; set; } = default!;

        public DbSet<Log_Modelos.Sensor> Sensor { get; set; } = default!;
    }
