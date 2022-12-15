using BusinessLayer.Interface;
using DataAccessLayer.DTO;
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
    public class StudentManager : IStudentService
    {

        public IStudentDAL _studentDAL;
        public ITeacherNotificationDAL _teacherNotificationDAL;

        public StudentManager(IStudentDAL studentDAL, ITeacherNotificationDAL teacherNotificationDAL)
        {
            _studentDAL = studentDAL;
            _teacherNotificationDAL = teacherNotificationDAL;
        }

        public List<Lesson> GetLessonByStudentID(int id)
        {
            return _studentDAL.GetLesssonByStudentID(id);
        }

        public List<Student> GetLessonFriends(int id)
        {
            return _studentDAL.GetLessonFriends(id);
        }

        //public List<Lesson> GetLessonAll()// Tüm Derslerin Listesi
        //{
        //    return _studentDAL.GetLessonAll();
        //}

        public void AddJoinNotification(JoinLessonDTO jl)
        {

            jl.TeacherID = 1;


            _teacherNotificationDAL.AddJoinNotificationDAL(jl);
        }




    }
}
