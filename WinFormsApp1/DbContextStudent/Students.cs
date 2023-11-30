using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.DbContextStudent
{
    public class Students
    {
        [Key]
        public int StudentNo { get; set; }
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public string StudentImage { get; set; }
    }
}
