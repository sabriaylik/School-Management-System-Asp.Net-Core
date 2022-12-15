using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Controllers
{
    public class LessonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult CreateLesson()
        {

            return View();
        }



    }
}
