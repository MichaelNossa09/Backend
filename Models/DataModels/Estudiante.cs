using System.ComponentModel.DataAnnotations;

namespace Backend.Models.DataModels
{
    public class Estudiante : BaseEntity
    {
        [Required]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;
        [Required]
        public DateTime Dob { get; set; }

        [Required]
        public ICollection<Curso> Cursos { get; set; } = new List<Curso>();

    }
}
