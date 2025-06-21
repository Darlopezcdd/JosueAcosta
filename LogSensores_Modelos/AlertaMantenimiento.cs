using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log_Modelos
{
    public class AlertaMantenimiento
    {
        [Key] public int Id { get; set; }

        public int SensorId { get; set; }
        public Sensor Sensor { get; set; }
        public bool AlertaReparacion { get; set; }
        public bool Cambio { get; set; }
        public DateTime Fecha { get; set; }
        public string Mensaje { get; set; }
    }
}
