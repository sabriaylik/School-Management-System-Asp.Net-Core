using DataAccessLayer.Concrete;
using DataAccessLayer.Interfaces;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EfRepository
{
    public class EfLessonRepository : ILessonDAL
    {
        Context c = new Context();

        public List<Lesson> GetLessonAllDAL()
        {
            return c.Lessons.ToList();
        }
        
    }
}
