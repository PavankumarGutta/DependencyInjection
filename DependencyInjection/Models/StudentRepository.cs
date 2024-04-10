namespace DependencyInjection.Models
{
    public class StudentRepository:IStudentRepository
    {
        public List<Student> StudentsData()
        {
            return new List<Student>()
            {
                new Student(){Id=1,Name="pavan",Age=23,Class="A"},
                new Student(){Id=2,Name="sai",Age=23,Class="B"},
            };
        }
       
        public List<Student> GetAllStudents()
        {
            return StudentsData();
        }

        public Student GetByID(int id)
        {
            return StudentsData().FirstOrDefault(x => x.Id == id) ?? new Student();
        }
    }
}
