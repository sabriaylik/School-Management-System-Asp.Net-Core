using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DTO
{
    public class DropDownListLesson
    {
        public int LessonID { get; set; }
        public List<SelectListItem> LessonList { get; set; }
    }
}
