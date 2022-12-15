using DataAccessLayer.DTO;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
   public interface ITeacherNotificationDAL
    {
        void AddJoinNotificationDAL(JoinLessonDTO tn);

    }
}
