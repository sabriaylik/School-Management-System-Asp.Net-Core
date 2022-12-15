using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface ILessonDAL
        
    {
        //void Insert();
        //void Delete();
        //void Update();
        //Lesson GetAllList();
        //Lesson GetByID(int id);

        List<Lesson> GetLessonAllDAL(); // Tüm Derslerin Listesini Döndür


    }
}
