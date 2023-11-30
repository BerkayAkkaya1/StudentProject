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
    public partial class OgrenciBul : Form
    {
        public OgrenciBul()
        {
            InitializeComponent();
        }

        StudentDbContext db = new StudentDbContext();

        private void button1_Click(object sender, EventArgs e)
        {
            string StudentName = textBox1.Text;
            string StudentSurname = textBox2.Text;

            var student = db.Students.FirstOrDefault(s => s.StudentName == StudentName);
            var student1 = db.Students.FirstOrDefault(s => s.StudentSurname == StudentSurname);

            if (student != null)
            {
                dataGridView1.DataSource = new List<Students> { student };
            }
            else
            {
                MessageBox.Show("Öğrenci bulunamadı.");
                var studentlist = db.Students.ToList();
                dataGridView1.DataSource = studentlist;
            }
            textBox1.Clear();
            textBox2.Clear();

        }

        private void OgrenciBul_Load(object sender, EventArgs e)
        {
            var studentlist = db.Students.ToList();
            dataGridView1.DataSource = studentlist;
        }
    }
}
