using EntityLayer;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IStudentDAL
    {

        List<Lesson> GetLesssonByStudentID(int id); // Öğrenciye ait derslerin listesi
        List<int> GetLessonsIDByStudentID(int id); //Öğrencinin aldığı derslerin id değerlerinin bir listesi.
        List<Student> GetLessonFriends(int id); //Öğrenci ile aynı dersi alanların listei //Ders idlerinin GetLessonsIDByStudentID metodundan alır.
        //List<Lesson> GetLessonAll(); // Tüm Derslerin Listesini Döndür
        List<LessonStudent> ListLessonNotes(int id);

        //void Insert();
        //void Delete();
        //void Update();
        //Student GetAllList();
        //Student GetByID(int id);

        //List<Lesson> GetLessonByID(int id);



    }
}
