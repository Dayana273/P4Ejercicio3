using System;
using System.Collections.Generic;
using SQLite;
using System.Text;
using System.Numerics;

namespace P4Ejercicio3.Datos
{
    public class Personas
    {



        public int Id { get; set; }

        [MaxLength(100),]
        public string nombres { get; set; }
         
        [MaxLength(100)]
        public string apellidos { get; set; }
        
        public BigInteger edad { get; set; }

        public string correo { get; set; }

        [MaxLength(200),]
        public string Direccion { get; set; }

    }
}
