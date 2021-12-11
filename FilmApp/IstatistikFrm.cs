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
    public partial class IstatistikFrm : Form
    {
        public IstatistikFrm()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-DG2OBOI;Initial Catalog=FilmApp;Integrated Security=True");


        private void IstatistikFrm_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut1 = new SqlCommand("select count(*) from film_bilgi", baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lblToplamFilm.Text = dr1[0].ToString();
            }

            baglanti.Close();


            baglanti.Open();

            SqlCommand komut2 = new SqlCommand("select count(*) from film_users", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                lblKullanici.Text = dr2[0].ToString();
            }

            baglanti.Close();
        }
    }
}
