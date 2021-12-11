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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-DG2OBOI;Initial Catalog=FilmApp;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut1 = new SqlCommand("select * from film_admin where kullaniciad=@k1 and sifre=@k2", baglanti);
            komut1.Parameters.AddWithValue("@k1", txtKullaniciAd.Text);
            komut1.Parameters.AddWithValue("@k2", txtSifre.Text);

            SqlDataReader dr = komut1.ExecuteReader();
            if (dr.Read())
            {
                Admin frm = new Admin();
                this.Hide();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı ya da şifre!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            baglanti.Close();
        }

        private void linkUyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KayıtFrm frm2 = new KayıtFrm();
            this.Hide();
            frm2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            baglanti.Open();

            SqlCommand komut2 = new SqlCommand("select * from film_users where usernickname=@u1 and userpass=@u2", baglanti);
            komut2.Parameters.AddWithValue("@u1", txtKullaniciAd.Text);
            komut2.Parameters.AddWithValue("@u2", txtSifre.Text);

            SqlDataReader dr2 = komut2.ExecuteReader();
            if (dr2.Read())
            {
                UsersFrm frm5 = new UsersFrm();
                frm5.userisim = dr2[1].ToString();
                this.Hide();
                frm5.Show();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı ya da şifre!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            baglanti.Close();

        }


    }
}
