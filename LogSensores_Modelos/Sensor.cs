using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log_Modelos
{
    public class Sensor
    {
        [Key] public int Id { get; set; }

        public int? CamionId { get; set; }
        public double Kilometraje { get; set; }
        public string EstadoMotor { get; set; }
        public bool EstadoSensor { get; set; }
        public DateTime Fecha { get; set; }
        public List<AlertaMantenimiento>? AlertasMantenimiento { get; set; }
    }
}
