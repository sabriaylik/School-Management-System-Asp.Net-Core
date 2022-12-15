using EntityLayer;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface ITeacherDAL
    {
        //void Insert();
        //void Delete();
        //void Update();
        //Teacher GetAllList();
        //Teacher GetByID(int id);


        int NumberLessonsEFDAL(int id);
        int NumberStudentEFDAL(int id);
        List<Lesson> GetLessonsEFDAL(int id);
        List<LessonStudent> GetStudentsEFDAL(int id);

        List<LessonStudent> GetNotesEFDAL(int id);

    }
}
