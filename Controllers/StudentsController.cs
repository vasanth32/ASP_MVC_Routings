using Routings.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Routings.Controllers
{
    //[RoutePrefix("students")]//RoutePrefix
    //[Route("action = Index")]
    public class StudentsController : Controller
    {
        static List<Student> students = new List<Student>()
        {
            new Student() { Id = 1, Name = "Pranaya" },
            new Student() { Id = 2, Name = "Priyanka" },
            new Student() { Id = 3, Name = "Anurag" },
            new Student() { Id = 4, Name = "Sambit" }
        };

        public ActionResult Index()
        {
            ViewBag.Message = "Index Page";
            return View();
        }

        [HttpGet]
        [Route("~/tech/teachers")]
        //https://localhost:44316/students/GetAllStudents
        public ActionResult GetAllStudents()
        {
            return View(students);
        }
        [HttpGet]
        [Route("studentID/{studentID:int:min(1)}")]
        public ActionResult GetStudentByID(int studentID)
        {
            Student studentDetails = students.FirstOrDefault(s => s.Id == studentID);
            return View(studentDetails);
        }
        [HttpGet]
        [Route("students/{studentID}/courses")]
        public ActionResult GetStudentCourses(int studentID)
        {
            List<string> CourseList = new List<string>();
            if (studentID == 1)
                CourseList = new List<string>() { "ASP.NET", "C#.NET", "SQL Server" };
            else if (studentID == 2)
                CourseList = new List<string>() { "ASP.NET MVC", "C#.NET", "ADO.NET" };
            else if (studentID == 3)
                CourseList = new List<string>() { "ASP.NET WEB API", "C#.NET", "Entity Framework" };
            else
                CourseList = new List<string>() { "Bootstrap", "jQuery", "AngularJs" };
            ViewBag.CourseList = CourseList;
            return View();
        }
    }
}