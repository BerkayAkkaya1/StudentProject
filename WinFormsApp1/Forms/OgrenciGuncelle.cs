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
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsApp1.Forms
{
    public partial class OgrenciGuncelle : Form
    {
        public OgrenciGuncelle()
        {
            InitializeComponent();
        }

        StudentDbContext db = new StudentDbContext();

        private void OgrenciGuncelle_Load(object sender, EventArgs e)
        {
            var studentlist = db.Students.ToList();
            dataGridView1.DataSource = studentlist;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string guncelAd = textBox1.Text;
            string guncelSoyad = textBox2.Text;
            string guncelFotograf = textBox3.Text;

            if (int.TryParse(textBox4.Text, out int StudentNo))
            {
                var student = db.Students.FirstOrDefault(s => s.StudentNo == StudentNo);

                if (student != null)
                {
                    student.StudentNo = StudentNo;
                    student.StudentName = guncelAd;
                    student.StudentSurname = guncelSoyad;
                    student.StudentImage = guncelFotograf;

                    db.SaveChanges();

                    MessageBox.Show("Öğrenci bilgileri güncellendi.");

                    dataGridView1.DataSource = db.Students.ToList();
                }
                else
                {
                    MessageBox.Show("Öğrenci bulunamadı.");
                }
            }
            else
            {
                MessageBox.Show("StudentNo bulunamadı.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBox3.Text = openFileDialog1.FileName;
        }
    }
}
