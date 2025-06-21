using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosMaestros_Modelos
{
    public class MantenimientoProgramado
    {
        [Key] public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string TipoMantenimiento {  get; set; }

        public int CamionId {  get; set; }
        public Camion Camion { get; set; }
    }
}
