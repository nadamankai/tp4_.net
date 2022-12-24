using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using tp4_.net.Data;
using tp4_.net.Models;

namespace tp4_.net.Controllers
{
    public class University : Controller
    {

        public ActionResult test1()
        {
            UniversityContext universityContext1 = UniversityContext.getInstance();

            return View();
        }
        public ActionResult test2()
        {
            UniversityContext universityContext2 = UniversityContext.getInstance();

            return View();
        }

        public ActionResult Index()
        {
            UniversityContext universityContext = UniversityContext.getInstance();
            List<Student> s = universityContext.Student.ToList();

            return View(s);


        }
        public ActionResult Courses(string id)
        {
            StudentRepository s = new StudentRepository();
            return View(s.getCourses());
        }

        [HttpGet("University/Course/{course}")]
        public ActionResult Course(String course)
        {
            StudentRepository s = new StudentRepository();
            
            return View(s.getStudentsByCourse(course));
        }

    }
}
