using System.ComponentModel.DataAnnotations;

namespace Backend.Models.DataModels
{
    public class Chapter : BaseEntity
    {
        public int CursoId { get; set; }
        public virtual Curso Curso { get; set; } = new Curso();

        [Required]
        public string List { get; set; } = string.Empty;
    }
}
