using BusinessLayer.Concrete;
using DataAccessLayer.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer.EfRepository;
using EntityLayer;
using Microsoft.AspNetCore.Authorization;

namespace School.Controllers
{
    //[Authorize]
    [AllowAnonymous]
    public class TeacherController : Controller
    {
        TeacherManager tm = new TeacherManager(new EfTeacherRepository());
        public IActionResult Index(int userid=1)
        {
           
           var values = new Dictionary<string, int>();
            //kullanicilar.Add("derssayisi", tm.NumberLessons(userid));
            //kullanicilar.Add("userid", userid);
            //ViewBag.values = kullanicilar;
            
            values.Add("user", 1);
            values.Add("countlesson", tm.NumberLessons(userid));
            values.Add("countstudent", tm.NumberStudent(userid));

            ViewBag.variable = values;

            return View();
        }
    
        public IActionResult ListLessons()
        {

            var lessons = tm.GetLessons(1);
            return View(lessons);
        }
    
        public IActionResult ListStudents()
        {
            var students = tm.GetStudents(1);

            IDictionary<int, string> dersler = new Dictionary<int, string>();
            dersler.Add(1, "Veri Yapıları");
            dersler.Add(2, "Algoritmalar");

            //List<sinif> dersler = new()
            //{
            //    new sinif { LessonID = 1, Name = "Veri Yapıları" },
            //    new sinif { LessonID = 2, Name = "Algoritmalar" },
            //    new sinif { LessonID = 3, Name = "Veri Tabanı" },
            //    new sinif { LessonID = 4, Name = "OOP" },
            //    new sinif { LessonID = 5, Name = "Veri Analizi" },
            //};
            ViewBag.dersler = dersler;
            return View(students);
        }
    
        public IActionResult ListNotes()
        {
            var values = tm.GetNotes(1);
            return View(values);
        }
    
      
    
    
    
    }
}
