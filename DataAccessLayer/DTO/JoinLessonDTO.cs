using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DTO
{
    public class JoinLessonDTO
    {
        public int StudentID { get; set; }
        public int TeacherID { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public bool Status { get; set; } = true;
    }
}
