using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.DbContextStudent
{
    public class Lessons
    {
        [Key]
        public int LessonID { get; set; }
        public string LessonName { get; set; }
    }
}
