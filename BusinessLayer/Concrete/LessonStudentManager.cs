using BusinessLayer.Interface;
using DataAccessLayer.Interfaces;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;



namespace BusinessLayer.Concrete
{
    public class LessonStudentManager : ILessonStudentService
    {
        ILessonStudentDAL _lessonStudentDAL;
        IStudentDAL _studentDAL;

        public LessonStudentManager(ILessonStudentDAL lessonStudentDAL, IStudentDAL studentDAL)
        {
            _lessonStudentDAL = lessonStudentDAL;
            _studentDAL = studentDAL;
        }

        public void JoinLessonById(LessonStudent ls)
        {



            _lessonStudentDAL.AddLessonStudent(ls);
        }

        public void LeaveLessonById(LessonStudent ls)
        {
            _lessonStudentDAL.RemoveLessonStudent(ls);
        }

        public List<LessonStudent> ListLessonNotes(int id)
        {
            var lessons = _studentDAL.ListLessonNotes(id);
            return lessons;
        }

    }
}
