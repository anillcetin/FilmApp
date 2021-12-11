using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FilmApp
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-DG2OBOI;Initial Catalog=FilmApp;Integrated Security=True");


        private void button7_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into film_bilgi (filmad,filmtur,yonetmen,yapimyili,filmkonu,filmresim) values (@a1,@a2,@a3,@a4,@a5,@a6)",baglanti);
            komut.Parameters.AddWithValue("@a1", txtFilmAd.Text);
            komut.Parameters.AddWithValue("@a2", txtFilmTur.Text);
            komut.Parameters.AddWithValue("@a3", txtYonetmen.Text);
            komut.Parameters.AddWithValue("@a4", txtYapimYili.Text);
            komut.Parameters.AddWithValue("@a5", txtKonu.Text);
            komut.Parameters.AddWithValue("@a6", pictureBox1.ImageLocation);

            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Film eklendi...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'filmAppDataSet2.film_bilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.film_bilgiTableAdapter.Fill(this.filmAppDataSet2.film_bilgi);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtFilmId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtFilmAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtFilmTur.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtYonetmen.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtYapimYili.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtKonu.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            pictureBox1.ImageLocation = dataGridView1.Rows[secilen].Cells[6].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'filmAppDataSet2.film_bilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.film_bilgiTableAdapter.Fill(this.filmAppDataSet2.film_bilgi);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtFilmId.Text = "";
            txtFilmAd.Text = "";
            txtFilmTur.Text = "";
            txtYonetmen.Text = "";
            txtYapimYili.Text = "";
            txtKonu.Text = "";
            pictureBox1.ImageLocation = "";
            txtFilmAd.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komutsil = new SqlCommand("delete from film_bilgi where filmid=@k1", baglanti);
            komutsil.Parameters.AddWithValue("@k1", txtFilmId.Text);
            komutsil.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Film silindi...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komutguncelle = new SqlCommand("update film_bilgi set filmad=@b1,filmtur=@b2,yonetmen=@b3,yapimyili=@b4,filmkonu=@b5,filmresim=@b6 where filmid=@b7", baglanti);
            komutguncelle.Parameters.AddWithValue("@b1", txtFilmAd.Text);
            komutguncelle.Parameters.AddWithValue("@b2", txtFilmTur.Text);
            komutguncelle.Parameters.AddWithValue("@b3", txtYonetmen.Text);
            komutguncelle.Parameters.AddWithValue("@b4", txtYapimYili.Text);
            komutguncelle.Parameters.AddWithValue("@b5", txtKonu.Text);
            komutguncelle.Parameters.AddWithValue("@b6", pictureBox1.ImageLocation);
            komutguncelle.Parameters.AddWithValue("@b7", txtFilmId.Text);



            komutguncelle.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Film güncellendi...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            IstatistikFrm frm = new IstatistikFrm();
            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm9 = new Form1();
            frm9.Show();
        }
    }
}
