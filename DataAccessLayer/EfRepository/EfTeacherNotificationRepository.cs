using DataAccessLayer.Concrete;
using DataAccessLayer.DTO;
using DataAccessLayer.Interfaces;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EfRepository
{
    public class EfTeacherNotificationRepository : ITeacherNotificationDAL
    {
        public void AddJoinNotificationDAL(JoinLessonDTO tn)
        {
            using var c = new Context();
            //c.TeacherNotifications.Add(tn);
        }
    }
}
