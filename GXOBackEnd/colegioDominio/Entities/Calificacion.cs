using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colegioDominio.Entities
{
    public class Calificacion
    {
        public int Id { get; set; }
        public int IdColegio { get; set; }
        [ForeignKey("IdColegio")]
        public Colegios? Colegio { get; set; }
        public int IdMateria { get; set; }
        [ForeignKey("IdMateria")]
        public Materia? Materia { get; set; }
        public int IdUsuario { get; set; }
        [ForeignKey("IdUsuario")]
        public Usuario? Usuario { get; set; }
        public decimal Calificaciones { get; set; }
    }
}
