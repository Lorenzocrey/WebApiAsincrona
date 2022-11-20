using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiAsincrona.Model
{
    public class Modulo_Alumno
    {
        [Key]
        public int IdModulo_Alumno { get; set; }
        public int Codigo_Alumno { get; set; }
        public int Codigo_Modulo { get; set; }
        public virtual Alumno Alumno { get; set; }
        public virtual Modulo Modulo { get; set; }
    }
}
