using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.DbContextStudent
{
    public class StudentDbContext : DbContext
    {
        public DbSet<Students> Students { get; set; }
        public DbSet<Lessons> Lessons { get; set; }
        public DbSet<ExamMarks> ExamMarks { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-N5JHVVH;Initial Catalog=STUDENT_PROJECT;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
    }
}