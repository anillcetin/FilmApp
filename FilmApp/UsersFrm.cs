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
    public partial class UsersFrm : Form
    {
        public UsersFrm()
        {
            InitializeComponent();
        }

        void temizle()
        {
            foreach(PictureBox nesne in filmler)
            {
                nesne.Visible = false;
            }
        }

        public string userisim;
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-DG2OBOI;Initial Catalog=FilmApp;Integrated Security=True");


        List<string> resimler = new List<string>();
        public List<PictureBox> filmler = new List<PictureBox>();

        

        private void UsersFrm_Load(object sender, EventArgs e)
        {
            label1.Text = "Hoşgeldin, " + userisim;

            filmler.Add(pictureBox1);
            filmler.Add(pictureBox2);
            filmler.Add(pictureBox3);
            filmler.Add(pictureBox4);
            filmler.Add(pictureBox5);
            filmler.Add(pictureBox6);
            filmler.Add(pictureBox7);
            filmler.Add(pictureBox8);
            filmler.Add(pictureBox9);
            filmler.Add(pictureBox10);
            filmler.Add(pictureBox11);
            filmler.Add(pictureBox12);
            filmler.Add(pictureBox13);
            filmler.Add(pictureBox14);
            filmler.Add(pictureBox15);

            temizle();

            baglanti.Open();

            SqlCommand komut = new SqlCommand("select filmresim from film_bilgi", baglanti);

            SqlDataReader dr = komut.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {

                resimler.Add(dr["filmresim"].ToString());
                i++;

            }
            
            for(int a = 0; a < resimler.Count; a++)
            {
                filmler[a].ImageLocation = resimler[a];
                filmler[a].Visible = true;
                
            }

           
            baglanti.Close();


        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {

            temizle();
            baglanti.Open();

            SqlCommand komut = new SqlCommand("select filmresim from film_bilgi", baglanti);

            SqlDataReader dr = komut.ExecuteReader();
            
            int k = 0;
            while (dr.Read())
            {
                resimler[k] = dr["filmresim"].ToString();
                k++;
            }

            for (int a = 0; a < resimler.Count; a++)
            {
                filmler[a].ImageLocation = resimler[a];
                filmler[a].Visible = true;

            }


            baglanti.Close();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAksiyon_Click(object sender, EventArgs e)
        {

            temizle();
            baglanti.Open();

            SqlCommand komut2 = new SqlCommand("select filmresim from film_bilgi where filmtur=@x1", baglanti);
            komut2.Parameters.AddWithValue("@x1", "Aksiyon");

            SqlDataReader dr2 = komut2.ExecuteReader();

     
            int k = 0;
            while (dr2.Read())
            {
                resimler[k] = dr2["filmresim"].ToString();
                k++;
            }

               

            for (int a = 0; a < k; a++)
            {
                filmler[a].ImageLocation = resimler[a];
                filmler[a].Visible = true;

            }


            baglanti.Close();
        }

        private void btnRomantik_Click(object sender, EventArgs e)
        {
            temizle();
            baglanti.Open();

            SqlCommand komut4 = new SqlCommand("select filmresim from film_bilgi where filmtur=@x1", baglanti);
            komut4.Parameters.AddWithValue("@x1", "Romantik");

            SqlDataReader dr4 = komut4.ExecuteReader();


            int k = 0;
            while (dr4.Read())
            {
                resimler[k] = dr4["filmresim"].ToString();
                k++;
            }



            for (int a = 0; a < k; a++)
            {
                filmler[a].ImageLocation = resimler[a];
                filmler[a].Visible = true;

            }


            baglanti.Close();
        }

        private void btnKorku_Click(object sender, EventArgs e)
        {
            temizle();
            baglanti.Open();

            SqlCommand komut5 = new SqlCommand("select filmresim from film_bilgi where filmtur=@x1", baglanti);
            komut5.Parameters.AddWithValue("@x1", "Korku");

            SqlDataReader dr5 = komut5.ExecuteReader();


            int k = 0;
            while (dr5.Read())
            {
                resimler[k] = dr5["filmresim"].ToString();
                k++;
            }



            for (int a = 0; a < k; a++)
            {
                filmler[a].ImageLocation = resimler[a];
                filmler[a].Visible = true;

            }


            baglanti.Close();
        }

        private void btnDram_Click(object sender, EventArgs e)
        {
            temizle();
            baglanti.Open();

            SqlCommand komut6 = new SqlCommand("select filmresim from film_bilgi where filmtur=@x1", baglanti);
            komut6.Parameters.AddWithValue("@x1", "Dram");

            SqlDataReader dr6 = komut6.ExecuteReader();


            int k = 0;
            while (dr6.Read())
            {
                resimler[k] = dr6["filmresim"].ToString();
                k++;
            }



            for (int a = 0; a < k; a++)
            {
                filmler[a].ImageLocation = resimler[a];
                filmler[a].Visible = true;

            }


            baglanti.Close();
        }

        private void btnCocuk_Click(object sender, EventArgs e)
        {
            temizle();
            baglanti.Open();

            SqlCommand komut7 = new SqlCommand("select filmresim from film_bilgi where filmtur=@x1", baglanti);
            komut7.Parameters.AddWithValue("@x1", "Çocuk");

            SqlDataReader dr7 = komut7.ExecuteReader();


            int k = 0;
            while (dr7.Read())
            {
                resimler[k] = dr7["filmresim"].ToString();
                k++;
            }



            for (int a = 0; a < k; a++)
            {
                filmler[a].ImageLocation = resimler[a];
                filmler[a].Visible = true;

            }


            baglanti.Close();
        }

        private void btnYerli_Click(object sender, EventArgs e)
        {
            temizle();
            baglanti.Open();

            SqlCommand komut8 = new SqlCommand("select filmresim from film_bilgi where filmtur=@x1", baglanti);
            komut8.Parameters.AddWithValue("@x1", "Yerli");

            SqlDataReader dr8 = komut8.ExecuteReader();


            int k = 0;
            while (dr8.Read())
            {
                resimler[k] = dr8["filmresim"].ToString();
                k++;
            }



            for (int a = 0; a < k; a++)
            {
                filmler[a].ImageLocation = resimler[a];
                filmler[a].Visible = true;

            }


            baglanti.Close();
        }

        private void btnKomedi_Click(object sender, EventArgs e)
        {
            temizle();
            baglanti.Open();

            SqlCommand komut9 = new SqlCommand("select filmresim from film_bilgi where filmtur=@x1", baglanti);
            komut9.Parameters.AddWithValue("@x1", "Komedi");

            SqlDataReader dr9 = komut9.ExecuteReader();


            int k = 0;
            while (dr9.Read())
            {
                resimler[k] = dr9["filmresim"].ToString();
                k++;
            }



            for (int a = 0; a < k; a++)
            {
                filmler[a].ImageLocation = resimler[a];
                filmler[a].Visible = true;

            }


            baglanti.Close();
        }



        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            filmicerik icrk = new filmicerik();
            icrk.imgloc.Text = pictureBox1.ImageLocation;

            
            icrk.Show();

            
        }

        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            filmicerik icrk = new filmicerik();
            icrk.imgloc.Text = pictureBox2.ImageLocation;


            icrk.Show();
        }

        private void pictureBox3_DoubleClick(object sender, EventArgs e)
        {
            filmicerik icrk = new filmicerik();
            icrk.imgloc.Text = pictureBox3.ImageLocation;


            icrk.Show();
        }

        private void pictureBox4_DoubleClick(object sender, EventArgs e)
        {
            filmicerik icrk = new filmicerik();
            icrk.imgloc.Text = pictureBox4.ImageLocation;


            icrk.Show();
        }

        private void pictureBox5_DoubleClick(object sender, EventArgs e)
        {
            filmicerik icrk = new filmicerik();
            icrk.imgloc.Text = pictureBox5.ImageLocation;


            icrk.Show();
        }

        private void pictureBox6_DoubleClick(object sender, EventArgs e)
        {
            filmicerik icrk = new filmicerik();
            icrk.imgloc.Text = pictureBox6.ImageLocation;


            icrk.Show();
        }

        private void pictureBox7_DoubleClick(object sender, EventArgs e)
        {
            filmicerik icrk = new filmicerik();
            icrk.imgloc.Text = pictureBox7.ImageLocation;


            icrk.Show();
        }

        private void pictureBox8_DoubleClick(object sender, EventArgs e)
        {
            filmicerik icrk = new filmicerik();
            icrk.imgloc.Text = pictureBox8.ImageLocation;


            icrk.Show();
        }

        private void pictureBox9_DoubleClick(object sender, EventArgs e)
        {
            filmicerik icrk = new filmicerik();
            icrk.imgloc.Text = pictureBox9.ImageLocation;


            icrk.Show();
        }

        private void pictureBox10_DoubleClick(object sender, EventArgs e)
        {
            filmicerik icrk = new filmicerik();
            icrk.imgloc.Text = pictureBox10.ImageLocation;


            icrk.Show();
        }

        private void pictureBox11_DoubleClick(object sender, EventArgs e)
        {
            filmicerik icrk = new filmicerik();
            icrk.imgloc.Text = pictureBox11.ImageLocation;


            icrk.Show();
        }

        private void pictureBox12_DoubleClick(object sender, EventArgs e)
        {
            filmicerik icrk = new filmicerik();
            icrk.imgloc.Text = pictureBox12.ImageLocation;


            icrk.Show();
        }

        private void pictureBox13_DoubleClick(object sender, EventArgs e)
        {
            filmicerik icrk = new filmicerik();
            icrk.imgloc.Text = pictureBox13.ImageLocation;


            icrk.Show();
        }

        private void pictureBox14_DoubleClick(object sender, EventArgs e)
        {
            filmicerik icrk = new filmicerik();
            icrk.imgloc.Text = pictureBox14.ImageLocation;


            icrk.Show();
        }

        private void pictureBox15_DoubleClick(object sender, EventArgs e)
        {
            filmicerik icrk = new filmicerik();
            icrk.imgloc.Text = pictureBox15.ImageLocation;


            icrk.Show();
        }
    }
}
