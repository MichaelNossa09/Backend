using System.ComponentModel.DataAnnotations;

namespace Backend.Models.DataModels
{
    public class Curso : BaseEntity
    {
        [Required, StringLength(50)]
        public string Name { get; set; } = string.Empty;

        [Required, StringLength(280)]
        public string DescriptionSmall { get; set; } = string.Empty;

        [Required]
        public string DescriptionLarge { get; set; } = string.Empty;

        [Required]
        public string PublicObject { get; set; } = string.Empty;

        [Required]
        public string Objects { get; set; } = string.Empty;

        [Required]
        public string Requirements { get; set; } = string.Empty;

        [Required]
        public Nivel Nivel { get; set; } = Nivel.Básico;

        [Required]
        public ICollection<Categoria> Categorias { get; set; } = new List<Categoria>();
        [Required]
        public Chapter Chapter { get; set; } = new Chapter();
        [Required]
        public ICollection<Estudiante> Estudiantes { get; set; } = new List<Estudiante>();
    }
    public enum Nivel
    {
        Básico,
        Intermedio,
        Avanazado
    }

}
