using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosMaestros_Modelos
{
    public class Login
    {
        [Key] public int Id { get; set;}
        public string NombreUsuario { get; set;}
        public string Contraseña {  get; set;}
        public bool ResultadoLogin {  get; set;}
        public DateTime Fecha {  get; set;}= DateTime.Now;

    }
}
