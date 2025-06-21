using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosMaestros_Modelos
{
    public class Camion
    {
        [Key] public int Id { get; set; }
        public string Marca {  get; set; }
        public string Modelo {  get; set; }
        public int Año {  get; set; }
        public string Placa {  get; set; }
        public double KilometrajeActual {  get; set; }
        public string Estado {  get; set; }

        public int ConductorId {  get; set; }
        public int TallerId { get; set; }

        public Conductor Conductor { get; set; }
        public Taller? Taller { get; set; }

        public List<MantenimientoProgramado>? MantenimientosProgramados { get; set; }
    }
}
