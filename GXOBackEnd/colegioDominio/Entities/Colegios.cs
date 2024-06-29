using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colegioDominio.Entities
{
    public class Colegios
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string TipoColegio { get; set; }
        public ICollection<Materia>? Materias { get; set; }
        public ICollection<Calificacion>? Calificaciones { get; set; }
    }

}

