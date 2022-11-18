using Backend.Models.DataModels;

namespace Backend.Services
{
    public interface IStudentsService
    {
        IEnumerable<Estudiante> GetStudentsWithCourses();
        IEnumerable<Estudiante> GetStudentsWithNoCourses();
    }
}
