﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosMaestros_Modelos
{
    public class Taller
    {
        [Key] public int Id {  get; set; }
        public string Nombre { get; set; }
        public string Ciudad {  get; set; }
        public int CapMaxReparacionesSimultaneas {  get; set; } 

        public List<Camion>? Camiones { get; set; }

    }
}
