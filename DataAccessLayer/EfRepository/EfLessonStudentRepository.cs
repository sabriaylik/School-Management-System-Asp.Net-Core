using DataAccessLayer.Concrete;
using DataAccessLayer.Interfaces;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccessLayer.EfRepository
{
    public class EfLessonStudentRepository : ILessonStudentDAL
    {
        public void AddLessonStudent(LessonStudent ls)
        {
           using (var c = new Context())
            {
                c.Add(ls);
                c.SaveChanges();
            }
        }

        //public List<LessonStudent> ListLessonNotes(int id)
        //{
        //   using (var c = new Context())
        //    {
        //        return c.lessonStudents.Include(ls=>ls.Lesson).Where(ls => ls.StudentID == id).ToList();
        //    }
        //}

        public void RemoveLessonStudent(LessonStudent ls)
        {
            using(var c = new Context())
            {
                //var deleting = c.lessonStudents.Where(u=>u.LessonID==ls.LessonID && u.StudentID==ls.StudentID).FirstOrDefault();
                LessonStudent sil = c.lessonStudents.Find(ls.StudentID, ls.LessonID);
                c.lessonStudents.Remove(sil);
                //c.lessonStudents.Remove(ls);
                c.SaveChanges();
            }
        } 
    
    
    
    
    
    
    
    }
}
