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
    }
}
