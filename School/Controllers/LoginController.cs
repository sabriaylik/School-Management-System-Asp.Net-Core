using DataAccessLayer.Concrete;
using DataAccessLayer.DTO;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace School.Controllers
{
    public class LoginController : Controller
    {
        Context c = new Context();
        public IActionResult LoginStudent()
        {
            return View();
        }


        [HttpPost]
        public IActionResult LoginStudent(Login login)
        {
            var user = c.Students.FirstOrDefault(t => t.UserName == login.username && t.Password == login.password);
            if (user != null)
            {
                //COOKİE İLE OTURUM İŞLEMİ
                CookieOptions options = new CookieOptions();
                options.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Append("name", "Ahmet", options);

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,user.Name),
                    
                    //new Claim("UserName",user.Name),
                    //new Claim("AuthorID",user.StudentID.ToString()),
                    //new Claim(ClaimTypes.Role,"q")
                };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var auth_properties = new AuthenticationProperties()
                {
                    ExpiresUtc = System.DateTimeOffset.UtcNow.AddMinutes(60)
                };
                HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity),
                    auth_properties
                    );



                return RedirectToAction("Main", "Student");
            }
            else
            {

            }

            //      Delete Cookie
            if(Request.Cookies["name"] != null)
            {
                Response.Cookies.Delete("name");
            }


            return View();
        }





        //[HttpPost]
        //public IActionResult LoginStudent(Login login)
        //{
        //    var user = c.Students.FirstOrDefault(t => t.UserName == login.username && t.Password == login.password);
        //    if(user!=null)
        //    {
        //        //COOKİE İLE OTURUM İŞLEMİ
        //        var claims = new List<Claim>
        //        {
        //            //new Claim(ClaimTypes.Name,user.Name),
        //            new Claim("UserName",user.Name),
        //            new Claim("AuthorID",user.StudentID.ToString()),
        //            //new Claim(ClaimTypes.Role,"q")
        //        };

        //        var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
        //        var auth_properties = new AuthenticationProperties
        //        {
        //            ExpiresUtc = System.DateTimeOffset.UtcNow.AddMinutes(60)
        //        };
        //        HttpContext.SignInAsync(
        //            CookieAuthenticationDefaults.AuthenticationScheme,
        //            new ClaimsPrincipal(claimsIdentity),
        //            auth_properties
        //            );

        //        /*
        //            LOGOUT
        //        HttpContext.SignOutAsync ();
        //         */


        //        //SESSİON İLE OTURUM İŞLEMİ
        //        //HttpContext.Session.SetString("user", login.username);
        //        return RedirectToAction("Main", "Student");
        //    }
        //    else
        //    {
            
        //    }
        //    return View();
        //}
       
        
        
        
        
        public IActionResult LoginTeacher()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LoginTeacher(Login login)
        {
            //var user = c.Teachers.FirstOrDefault(t => t.UserName == login.username && t.Password == login.password);
            var user = c.Teachers.Where(t => t.UserName == login.username && t.Password == login.password).First();

            if (user != null)
            {
                HttpContext.Session.SetString("user", login.username);
                return RedirectToAction("Index","Teacher",new { userid = user.TeacherID});
            }
            else
            {
                return View();
            }
            
        }

    }
}
