using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using tp4_.net.Models;

namespace tp4_.net.Data
{
    public class StudentRepository
    {

        UniversityContext universityContext;
        public StudentRepository()
        {
            universityContext = UniversityContext.getInstance();
        }
       
        public List<Student> getStudentsByCourse(string course)
        {
            List<Student> student = universityContext.Student.Where((Student student) => student.course == course).ToList();
            
            return student;
        }
        public List<String> getCourses()
        {
            var courses = new List<String>();
            var student = universityContext.Student.ToList();
            foreach (Student s in student)
            {
                if (!courses.Contains(s.course)) courses.Add(s.course);
            }
            return courses;
        }


       
    }
}
