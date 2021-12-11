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
    public partial class KayıtFrm : Form
    {
        public KayıtFrm()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-DG2OBOI;Initial Catalog=FilmApp;Integrated Security=True");


        private void button2_Click(object sender, EventArgs e)
        {

            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into film_users (username,usersurname,usergender,userdateofbirth,usermail,usernickname,userpass) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", baglanti);

            komut.Parameters.AddWithValue("@p1", txtname.Text);
            komut.Parameters.AddWithValue("@p2", txtsurname.Text);
            komut.Parameters.AddWithValue("@p3", label9.Text);
            komut.Parameters.AddWithValue("@p4", dateTimePicker1.Value);
            komut.Parameters.AddWithValue("@p5", txtmail.Text);
            komut.Parameters.AddWithValue("@p6", txtKullaniciAd.Text);
            komut.Parameters.AddWithValue("@p7", txtSifre.Text);
            komut.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Başarıyla Kayıt Olundu...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label9.Text = "True";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label9.Text = "False";
        }

        private void label9_TextChanged(object sender, EventArgs e)
        {
            if(label9.Text == "True")
            {
                radioButton1.Checked = true;
                radioButton2.Checked = false;
            }
            else if (label9.Text == "False")
            {
                radioButton1.Checked = false;
                radioButton2.Checked = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form1 frm3 = new Form1();
            this.Close();
            frm3.Show();
        }
    }
}
