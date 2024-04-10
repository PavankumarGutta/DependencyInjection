namespace DependencyInjection.Models
{
    public interface IStudentRepository
    {
        Student GetByID(int id);
        List<Student> GetAllStudents();
    }
}
