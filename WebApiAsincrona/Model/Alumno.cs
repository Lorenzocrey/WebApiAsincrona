using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiAsincrona.Model
{
    public class Alumno
    {
        [Key]
        public int Expediente { get; set; }
        public string Nombre { get; set; }
        public string ApellidoP { get; set; }
        public string ApellidoM { get; set; }
        public DateTime FechaNac { get; set; }
        public Byte Delegado { get; set; }
        public virtual IEnumerable<Modulo_Alumno> Modulo_Alumno { get; set; }
    }
}
