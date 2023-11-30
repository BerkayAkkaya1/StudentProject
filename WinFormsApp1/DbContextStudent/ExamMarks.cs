using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.DbContextStudent
{
    public class ExamMarks
    {
        [Key]
        public int StudentIDMark { get; set; }
        public int Exam1 { get; set; }
        public int Exam2 { get; set; }
        public int Exam3 { get; set; }
        public double GPA { get; set; }
        public string Status { get; set; }
    }
}
