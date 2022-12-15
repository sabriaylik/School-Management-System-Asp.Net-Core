using DataAccessLayer.DTO;
using EntityLayer;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interface
{
    public interface IStudentService
    {
        
        List<Lesson> GetLessonByStudentID(int id);
        List<Student> GetLessonFriends(int id);
        //List<Lesson> GetLessonAll();

        void AddJoinNotification(JoinLessonDTO ls);


    }
}
