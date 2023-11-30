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
    public partial class NotListesi : Form
    {
        StudentDbContext db = new StudentDbContext();
        public NotListesi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var examMarksList = db.ExamMarks.ToList();
            dataGridView1.DataSource = examMarksList;
        }
    }
}
