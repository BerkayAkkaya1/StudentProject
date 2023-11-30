using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.DbContextStudent;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1.Forms
{
    public partial class DersKayit : Form
    {
        public DersKayit()
        {
            InitializeComponent();
        }

        StudentDbContext db = new StudentDbContext();

        private void DersKayit_Load(object sender, EventArgs e)
        {
            var lessonslist = db.Lessons.ToList();
            dataGridView1.DataSource = lessonslist;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lessons lessons = new Lessons();
            {
                lessons.LessonName = textBox1.Text;
            }

            db.Lessons.Add(lessons);
            db.SaveChanges();

            var lessonslist = db.Lessons.ToList();
            dataGridView1.DataSource = lessonslist;

            textBox1.Text = string.Empty;
        }
    }
}
