using DataAccessLayer.Concrete;
using DataAccessLayer.Interfaces;
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
    public class EfTeacherRepository : ITeacherDAL
    {
        public void Delete()
        {
            throw new NotImplementedException();
        }

        public Teacher GetAllList()
        {
            throw new NotImplementedException();
        }

        public Teacher GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Lesson> GetLessonsEFDAL(int id)
        {
            using (var c = new Context())
            {
                var lessons = c.Lessons.Where(l => l.TeacherID == id).ToList();
                return lessons;
            }
        }

        public List<LessonStudent> GetNotesEFDAL(int id)
        {
            using (var c = new Context())
            {
                var lids = c.Lessons.Where(l => l.TeacherID == id).Select(l => l.LessonID).ToList();
                var notes = c.lessonStudents.Where(ls => lids.Contains(ls.LessonID)).Include(ls=>ls.Lesson).Include(ls=>ls.Student).ToList();
                return notes;
            }
        }

        public List<LessonStudent> GetStudentsEFDAL(int id)
        {
            using(var c = new Context())
            {
                var lid = c.Lessons.Where(l => l.TeacherID == id).Select(a => a.LessonID).ToList();
                var lessons = c.lessonStudents.Where(ls => lid.Contains(ls.LessonID)).Include(ls => ls.Student).Include(ls=>ls.Lesson).ToList();
                return lessons;
            }

        }

        public void Insert()
        {
            throw new NotImplementedException();
        }

        public int NumberLessonsEFDAL(int id)
        {
            using(var c = new Context())
            {
                int count = c.Lessons.Where(l => l.TeacherID == id).Count();
                return count;
            }
        }

        public int NumberStudentEFDAL(int id)
        {
            using (var c = new Context())
            {
                var dersids = c.Lessons.Where(l => l.TeacherID == 1).Select(n => n.LessonID).ToList();
                int count = c.lessonStudents.Where(ls => dersids.Contains(ls.LessonID)).Count();
                return count;
            }
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
