using Microsoft.AspNetCore.Mvc;
using System.Formats.Asn1;
using tp4dotnet.Data;
using tp4dotnet.Models;

namespace tp4dotnet.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
            var context = UniversityContext.Instantiate_UniversityContext();
            var repository= new StudentRepository(context); 
            return View(repository.GetCourses());   
        }
        public IActionResult GetCourse(string c)
        {
            UniversityContext universityContext = UniversityContext.Instantiate_UniversityContext();
          
            StudentRepository studentRepository = new StudentRepository(universityContext);

            IEnumerable<Student> students = (IEnumerable<Student>)studentRepository.Find(s => s.course.ToLower() == c.ToLower());
        
            return View(students);
        }
    }
}
