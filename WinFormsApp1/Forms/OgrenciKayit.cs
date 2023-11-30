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
    public partial class OgrenciKayit : Form
    {
        StudentDbContext db = new StudentDbContext();
        public OgrenciKayit()
        {
            InitializeComponent();
        }

        private void OgrenciKayit_Load(object sender, EventArgs e)
        {
            var studentlist = db.Students.ToList();

            dataGridView1.DataSource = studentlist;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Students students = new Students();
            {
                students.StudentName = textBox1.Text;
                students.StudentSurname = textBox2.Text;
                students.StudentImage = textBox3.Text;

            }

            db.Students.Add(students);
            db.SaveChanges();

            var studentlist = db.Students.ToList();
            dataGridView1.DataSource = studentlist;

            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBox3.Text = openFileDialog1.FileName;
        }
    }
}
