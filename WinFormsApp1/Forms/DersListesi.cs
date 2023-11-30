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

namespace WinFormsApp1.Forms
{
    public partial class DersListesi : Form
    {
        StudentDbContext db = new StudentDbContext();
        public DersListesi()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string lessonName = textBox1.Text;

            if (string.IsNullOrEmpty(lessonName))
            {
                MessageBox.Show("Lütfen bir ders adı girin.");
                return;
            }

            var derslistesi = from ders in db.Lessons
                              where ders.LessonName.Contains(lessonName)
                              select ders;

            dataGridView1.DataSource = derslistesi.ToList();
        }

        private void DersListesi_Load(object sender, EventArgs e)
        {
            var lessonslist = db.Lessons.ToList();
            dataGridView1.DataSource = lessonslist;
        }
    }
}
