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
    public partial class OgrenciListele : Form
    {
        StudentDbContext db = new StudentDbContext();
        public OgrenciListele()
        {
            InitializeComponent();
        }

        private void OgrenciListele_Load(object sender, EventArgs e)
        {
            var studentlist = db.Students.ToList();
            dataGridView1.DataSource = studentlist;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            var azSiralama = db.Students.OrderBy(s => s.StudentName).ToList();
            dataGridView1.DataSource = azSiralama;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            var zaSiralama = db.Students.OrderByDescending(s => s.StudentName).ToList();
            dataGridView1.DataSource = zaSiralama;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            var ilkUcOgrenci = db.Students.OrderBy(s => s.StudentName).Take(3).ToList();
            dataGridView1.DataSource = ilkUcOgrenci;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            var aIleBaslayanlar = db.Students.Where(s => s.StudentName.StartsWith("A")).ToList();
            dataGridView1.DataSource = aIleBaslayanlar;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            int toplamOgrenciSayisi = db.Students.Count();
            dataGridView1.DataSource = new List<object> { new { ToplamOgrenciSayisi = toplamOgrenciSayisi } };
        }
    }
}
