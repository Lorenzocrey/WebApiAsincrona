using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiAsincrona.Model
{
    public class Modulo
    {
        [Key]
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public virtual IEnumerable<Modulo_Alumno> Modulo_Alumno { get; set; }
        public virtual IEnumerable<Profesor> Profesor { get; set; }
    }
}
