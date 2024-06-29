using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colegioDominio.Entities
{
    public class Materia
    {
        public int Id { get; set; }
        public int IdColegio { get; set; }
        [ForeignKey("IdColegio")]
        public Colegios? Colegio { get; set; }
        public string Nombre { get; set; }
        public string Area { get; set; }
        public int NumeroEstudiantes { get; set; }
        public string DocenteAsignado { get; set; }
        public string Curso { get; set; }
        public string Paralelo { get; set; }
        public ICollection<Calificacion>? Calificaciones { get; set; }
    }
}
