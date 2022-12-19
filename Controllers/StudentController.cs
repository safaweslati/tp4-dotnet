using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using tp4dotnet.Data;
using tp4dotnet.Models;

namespace tp4dotnet.Controllers
{
    public class StudentController : Controller
    {
        public ActionResult Index()
        {
            UniversityContext context = UniversityContext.Instantiate_UniversityContext();
            List<Student> students = context.Student.ToList();

            return View(students);
        }


       
    }
}
