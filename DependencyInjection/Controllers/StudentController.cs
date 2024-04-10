using DependencyInjection.Models;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    public class StudentController : Controller
    {
       private readonly IStudentRepository _st;
       public StudentController(IStudentRepository studentRepository)
        {
            _st = studentRepository;

        }
        public JsonResult Index()
        {

            List<Student> S = _st.GetAllStudents();
            return Json(S);
        }
        public JsonResult Details(int id) 
        {
            Student s=_st.GetByID(id);
            return Json(s); 

        }

        //NORMAl Injection
        //public JsonResult Index()
        //{
        //   StudentRepository studentRepository = new StudentRepository();
        //    var s=studentRepository.StudentsData();
        //    return Json(s); 
        //}
        //public JsonResult Students(int id)
        //{
        //    StudentRepository studentRepository = new StudentRepository();
        //    var s=studentRepository.GetByID(id);
        //    return Json(s);
        //}
    }
}
