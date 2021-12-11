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
        public string userisim;
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-DG2OBOI;Initial Catalog=FilmApp;Integrated Security=True");


        private void UsersFrm_Load(object sender, EventArgs e)
        {
            label1.Text = "Hoşgeldin, " + userisim;
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            //baglanti.Open();

            //SqlCommand komut = new SqlCommand("select filmresim from film_bilgi", baglanti);          

            //SqlDataReader dr = komut.ExecuteReader();
            //pictureBox1.ImageLocation = dr[0].ToString();
            
            
            //baglanti.Close();
        }
    }
}
