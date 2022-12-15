using BusinessLayer.Interface;
using DataAccessLayer.Interfaces;
using EntityLayer;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class TeacherManager : ITeacherService
    {
        ITeacherDAL _teacherDAL;

        public TeacherManager(ITeacherDAL teacherDAL)
        {
            _teacherDAL = teacherDAL;
        }

        public List<Lesson> GetLessons(int id)
        {
            return _teacherDAL.GetLessonsEFDAL(id);
        }

        public List<LessonStudent> GetNotes(int id)
        {
            return _teacherDAL.GetNotesEFDAL(id);
        }

        public List<LessonStudent> GetStudents(int id)
        {
            return _teacherDAL.GetStudentsEFDAL(id);
        }

        public int NumberLessons(int id)
        {
            int sayi = _teacherDAL.NumberLessonsEFDAL(id);
            return sayi;
        }
    
        public int NumberStudent(int id)
        {
            return _teacherDAL.NumberStudentEFDAL(id);
        }
    
    
    }
}
