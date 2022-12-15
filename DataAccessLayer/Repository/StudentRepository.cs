using DataAccessLayer.Concrete;
using DataAccessLayer.Interfaces;
using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class StudentRepository //: IStudentDAL
    {
        Context c = new Context();

        public List<Student> GetLessonFriends(int id)
        {
            throw new NotImplementedException();
        }

        public List<Lesson> GetLesssonByStudentID(int id)
        {
            //return c.Students.Include(l => l.Lessons).ThenInclude(l => l.LessonID == id)
            var values = c.Lessons.Where(s => s.Students.Any(l => l.StudentID == id)).ToList();
            return (List<Lesson>)values;
        }
    }
}
