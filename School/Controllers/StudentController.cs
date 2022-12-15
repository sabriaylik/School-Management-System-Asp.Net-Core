using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Http;
using BusinessLayer.Concrete;
using DataAccessLayer.EfRepository;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using DataAccessLayer.DTO;

namespace School.Controllers
{
   // [Authorize]
   [AllowAnonymous]
    public class StudentController : Controller
    {

        StudentManager _sm = new StudentManager(new EfStudentRepository(),new EfTeacherNotificationRepository());
        LessonStudentManager _lsm = new LessonStudentManager(new EfLessonStudentRepository() , new EfStudentRepository());
        LessonManager _lm = new LessonManager(new EfLessonRepository());

      
        public IActionResult Main()
        {
            //HttpContext.Session.SetInt32("user", 1);

            //string id = Request.Cookies["Name"];
            //string id = HttpContext.Request.Cookies[""];

            //var id = HttpContext.Request.Cookies["name"].ToString();

            //var isim = User.Identity.Name;

            //var isim = varible.Name;
            int id = 1;
            IDictionary<string, string> values = new Dictionary<string, string>();
            values.Add("id", id.ToString());
            values.Add("isim", "1453"); 
            values.Add("soyisim", "571");

            ViewBag.variable = values;

            return View();
        }

        public IActionResult ListLesson()// Alınan Dersleri Listele
        {
            //var user = HttpContext.Session.GetString("user");
            var lessons = _sm.GetLessonByStudentID(1);
            return View(lessons);
        }

        public IActionResult ListLessonFriend()
        {
            var students = _sm.GetLessonFriends(1);
            return View(students);
        } // Ders Arkadaşları listele

        public IActionResult ListLessonAll() // Tüm Dersleri Listele
        {
            var values = _lm.GetLessonAll();
            return View(values);
        }
        


        public IActionResult JoinLesson(int id)//Derse Katıl
        {
            HttpContext.Session.SetInt32("user", 4);
            var userid = Convert.ToInt32(HttpContext.Session.GetInt32("user"));
            var lessonid = id;

            var tn = new JoinLessonDTO() { StudentID = userid,Subject = "Join Lesson", Message = "I want to join your lesson!",Status=true, };
            //var ls = new LessonStudent() { LessonID = lessonid, StudentID = userid };
            //_lm.JoinLessonById(ls);
            return View();
        } 

        public IActionResult LeaveLesson(int id)//Dersten Ayrıl
        {
            HttpContext.Session.SetInt32("user", 4);
            var userid = Convert.ToInt32(HttpContext.Session.GetInt32("user"));
            var lessonid = id;
            var ls = new LessonStudent() { LessonID = lessonid, StudentID = userid };
            _lsm.LeaveLessonById(ls);
            return View();
        }



        public IActionResult ListLessonNotes()
        {
            HttpContext.Session.SetInt32("user",1);
            int user = (int)HttpContext.Session.GetInt32("user");
            var lessons = _lsm.ListLessonNotes(user);
            return View(lessons);
        }




    }
}
