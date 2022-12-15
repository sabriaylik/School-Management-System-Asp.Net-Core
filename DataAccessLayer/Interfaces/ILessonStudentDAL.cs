using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface ILessonStudentDAL
    {
        //LessonStudent GetLessonByID(int id);//Verilen idye ait lesson nesnesini döndür

        void AddLessonStudent(LessonStudent ls);
        void RemoveLessonStudent(LessonStudent ls);
        //List<LessonStudent> ListLessonNotes(int id);


    }
}
