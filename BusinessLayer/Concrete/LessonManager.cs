using BusinessLayer.Interface;
using DataAccessLayer.EfRepository;
using DataAccessLayer.Interfaces;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class LessonManager : ILessonService
    {

        ILessonDAL _lessonDAL;

        public LessonManager(ILessonDAL lessonDAL)
        {
            _lessonDAL = lessonDAL;
        }

        public List<Lesson> GetLessonAll()//Tüm derslerin listesini döndür
        {
            return _lessonDAL.GetLessonAllDAL();
        }
      

    }
}
