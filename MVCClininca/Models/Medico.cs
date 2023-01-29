using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using MVCClininca.Validators;
namespace MVCClininca.Models
{
    public class Medico
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [Column(TypeName = "varchar(50)")]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [Column(TypeName = "varchar(50)")]
        [StringLength(50)]
        public string Apellido{ get; set; }

        [CheckValidMatriculaAtributte]
        public string Matricula { get; set; }

    }
}
