using Microsoft.EntityFrameworkCore;
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
using WinFormsApp1.Migrations;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1.Forms
{
    public partial class SinavNotuEkle : Form
    {
        public SinavNotuEkle()
        {
            InitializeComponent();
        }
        StudentDbContext db = new StudentDbContext();

        private void button1_Click(object sender, EventArgs e)
        {
            int sinav1, sinav2, sinav3;
            if (int.TryParse(textBox1.Text, out sinav1) &&
                int.TryParse(textBox2.Text, out sinav2) &&
                int.TryParse(textBox3.Text, out sinav3))
            {
                int ortalama = (sinav1 + sinav2 + sinav3) / 3;
                textBox4.Text = ortalama.ToString();

                if (ortalama >= 50)
                {
                    textBox5.Text = "Geçti";
                }
                else
                {
                    textBox5.Text = "Kaldı";
                }
            }
            else
            {
                MessageBox.Show("Not Giriniz.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int studentNo, exam1, exam2, exam3;
            if (int.TryParse(textBox6.Text, out studentNo) &&
                int.TryParse(textBox1.Text, out exam1) &&
                int.TryParse(textBox2.Text, out exam2) &&
                int.TryParse(textBox3.Text, out exam3))
            {
                ExamMarks examMarks = new ExamMarks
                {
                    Exam1 = exam1,
                    Exam2 = exam2,
                    Exam3 = exam3,
                    GPA = (exam1 + exam2 + exam3) / 3,
                    Status = (exam1 + exam2 + exam3) / 3 >= 50 ? "Geçti" : "Kaldı"
                };
                db.ExamMarks.Add(examMarks);
                db.SaveChanges();

                var exammark = db.ExamMarks.ToList();
                dataGridView1.DataSource = exammark;

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ogrenciID, sinav1, sinav2, sinav3;
            if (int.TryParse(textBox6.Text, out ogrenciID) &&
                int.TryParse(textBox1.Text, out sinav1) &&
                int.TryParse(textBox2.Text, out sinav2) &&
                int.TryParse(textBox3.Text, out sinav3))
            {
                var mevcutOgrenci = db.ExamMarks.FirstOrDefault(s => s.StudentIDMark == ogrenciID);

                if (mevcutOgrenci != null)
                {
                    mevcutOgrenci.Exam1 = sinav1;
                    mevcutOgrenci.Exam2 = sinav2;
                    mevcutOgrenci.Exam3 = sinav3;
                    mevcutOgrenci.GPA = (sinav1 + sinav2 + sinav3) / 3;
                    mevcutOgrenci.Status = (sinav1 + sinav2 + sinav3) / 3 >= 50 ? "Geçti" : "Kaldı";

                    db.SaveChanges();

                    SinavNotuEkle_Load(sender, e);

                    MessageBox.Show("Not güncellendi.");
                }
                else
                {
                    MessageBox.Show("Öğrenci bulunamadı.");
                }
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
            }
        }

        private void SinavNotuEkle_Load(object sender, EventArgs e)
        {
            var sinavNotlari = from student in db.Students
                               join examMark in db.ExamMarks on student.StudentNo equals examMark.StudentIDMark into marks
                               from mark in marks.DefaultIfEmpty()
                               join lesson in db.Lessons on student.StudentNo equals lesson.LessonID
                               select new
                               {
                                   StudentNo = student.StudentNo,
                                   StudentName = student.StudentName,
                                   StudentSurname = student.StudentSurname,
                                   LessonName = lesson.LessonName,  // Ders adını ekleyin
                                   Exam1 = mark != null ? mark.Exam1 : 0,
                                   Exam2 = mark != null ? mark.Exam2 : 0,
                                   Exam3 = mark != null ? mark.Exam3 : 0,
                                   GPA = mark != null ? mark.GPA : 0,
                                   Status = mark != null ? mark.Status : "Girilmedi"
                               };

            dataGridView1.DataSource = sinavNotlari.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                textBox1.Text = selectedRow.Cells["Exam1"].Value.ToString();
                textBox2.Text = selectedRow.Cells["Exam2"].Value.ToString();
                textBox3.Text = selectedRow.Cells["Exam3"].Value.ToString();
                textBox6.Text = selectedRow.Cells["StudentNo"].Value.ToString();
                textBox4.Text = selectedRow.Cells["GPA"].Value.ToString();
                textBox5.Text = selectedRow.Cells["Status"].Value.ToString();
            }
        }
    }
}
