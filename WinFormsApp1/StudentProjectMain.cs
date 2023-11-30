using WinFormsApp1.DbContextStudent;
using WinFormsApp1.Forms;

namespace WinFormsApp1
{
    public partial class StudentProjectMain : Form
    {
        public StudentProjectMain()
        {
            InitializeComponent();
        }
        StudentDbContext db = new StudentDbContext();

        private void button1_Click(object sender, EventArgs e)
        {
            OgrenciListele ogrencilistele = new OgrenciListele();
            ogrencilistele.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OgrenciKayit ogrencikayit = new OgrenciKayit();
            ogrencikayit.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OgrenciSil ogrencisil = new OgrenciSil();
            ogrencisil.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OgrenciGuncelle ogrenciguncelle = new OgrenciGuncelle();
            ogrenciguncelle.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OgrenciBul ogrencibul = new OgrenciBul();
            ogrencibul.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DersListesi derslistesi = new DersListesi();
            derslistesi.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DersKayit derskayit = new DersKayit();
            derskayit.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            NotListesi notListesi = new NotListesi();
            notListesi.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DersSil derssil = new DersSil();
            derssil.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SinavNotuEkle sinavnotuekle = new SinavNotuEkle();
            sinavnotuekle.Show();
        }
    }
}