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
    public partial class DersSil : Form
    {
        StudentDbContext db = new StudentDbContext();
        public DersSil()
        {
            InitializeComponent();
            dataGridView1.DataSource = db.Lessons.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedLesson = dataGridView1.SelectedRows[0].DataBoundItem as Lessons;

                using (StudentDbContext db = new StudentDbContext())
                {
                    db.Lessons.Remove(selectedLesson);
                    db.SaveChanges();
                }
                dataGridView1.DataSource = db.Lessons.ToList();
                MessageBox.Show("Ders silindi.");
            }
        }
    }
}
