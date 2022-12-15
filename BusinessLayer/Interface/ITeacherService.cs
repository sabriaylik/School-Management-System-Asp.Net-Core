using EntityLayer;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interface
{
    public interface ITeacherService
    {
        int NumberLessons(int id);

        int NumberStudent(int id);

        List<Lesson> GetLessons(int id);

        List<LessonStudent> GetStudents(int id);

        List<LessonStudent> GetNotes(int id);
    }
}
