using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class LessonStudent
    {
        public int LessonID { get; set; }
        public int StudentID { get; set; }

        public int Exam1 { get; set; }
        public int Exam2 { get; set; }
        public int Result { get; set; }
        public Student Student { get; set; }
        public Lesson Lesson { get; set; }

    }
}
