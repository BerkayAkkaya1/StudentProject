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
    public partial class OgrenciSil : Form
    {
        StudentDbContext db = new StudentDbContext();
        public OgrenciSil()
        {
            InitializeComponent();
        }

        private void OgrenciSil_Load(object sender, EventArgs e)
        {
            var studentlist = db.Students.ToList();
            dataGridView1.DataSource = studentlist;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedStudent = dataGridView1.SelectedRows[0].DataBoundItem as Students;

                using (StudentDbContext db = new StudentDbContext())
                {
                    db.Students.Remove(selectedStudent);
                    db.SaveChanges();
                }
                dataGridView1.DataSource = db.Students.ToList();
                MessageBox.Show("Kayıt silindi");
            }
        }
    }
}
