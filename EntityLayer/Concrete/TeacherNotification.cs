using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class TeacherNotification
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey(nameof(StudentID))]
        public int StudentID { get; set; }
        [ForeignKey(nameof(TeacherID))]
        public int TeacherID { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public bool Status { get; set; } = true;
        public Student student { get; set; }
        public Teacher teacher { get; set; }
    }
}
