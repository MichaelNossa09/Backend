using Backend.Models.DataModels;
using Microsoft.EntityFrameworkCore;

namespace Backend.DataAccess
{
    public class UniversityDBContext :  DbContext
    {
        public UniversityDBContext(DbContextOptions<UniversityDBContext> options): base(options)
        {

        }

        // TODO : Add DbSets (Tables of our Data Base)
        public DbSet<User>? Users { get; set; } 
        public DbSet<Curso>? Cursos { get; set; }   
        public DbSet<Categoria>? Categorias { get; set; }
        public DbSet<Estudiante>? Estudiantes { get; set; }
        public DbSet<Chapter>? Chapters { get; set; }

    }
}
