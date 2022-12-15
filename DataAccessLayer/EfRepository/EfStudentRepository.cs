using DataAccessLayer.Concrete;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Repository;
using EntityLayer;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EfRepository
{
    public class EfStudentRepository : GenericRepository<Student>, IStudentDAL
    {
        Context c = new Context();
        public List<Lesson> GetLesssonByStudentID(int id)
        {
            var values = c.Lessons.Where(s => s.Students.Any(s => s.StudentID == id)).ToList();
            //var values = c.Students.Where(s => s.Lessons.Any(l => l.LessonID == id)).ToList();

            //var values = c.Lessons.Where(s => s.Students.Any(s => s.StudentID == ).Include(y => y.kitaplar)
            //                        .ThenInclude(k => k.Kitap)
            //                        .ToList();
            return values;
        }
    
    
       

        public List<Student> GetLessonFriends(int id)
        {
            //var values = c.Lessons.Where(s => s.Students.Any(s => s.StudentID == id)).ToList();

            var values = c.Students.Where(s => s.Lessons.Any(l => l.LessonID == id)).ToList();//Çalışan

            List<int> sayilar = new List<int>() { 1, 2 };
            //var values = c.Students.Where(s => s.Lessons.Any(l => l.LessonID == id) && s=> s.).ToList();

            return values;
        }

        public List<int> GetLessonsIDByStudentID(int id)
        {
            throw new NotImplementedException();
        }

        //public List<Lesson> GetLessonAll()
        //{
        //    return c.Lessons.ToList();
        //}

        public List<LessonStudent> ListLessonNotes(int id)
        {
            using (var c = new Context())
            {
                return c.lessonStudents.Include(ls => ls.Lesson).Where(ls => ls.StudentID == id).ToList();
            }
        }
    }
}
