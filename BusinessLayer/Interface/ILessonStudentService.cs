using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interface
{
    public interface ILessonStudentService
    {
        void JoinLessonById(LessonStudent ls);//Id lesson id student id'yi session üzerinden alacaz
        void LeaveLessonById(LessonStudent ls);// Id lesson id student id'yi session üzerinden alacaz

        List<LessonStudent> ListLessonNotes(int id);




    }
}
