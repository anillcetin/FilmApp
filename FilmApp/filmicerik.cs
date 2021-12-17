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
    public partial class filmicerik : Form
    {
        public filmicerik()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-DG2OBOI;Initial Catalog=FilmApp;Integrated Security=True");


        private void filmicerik_Load(object sender, EventArgs e)
        {
            //icerikrsmPicBox.ImageLocation = imgloc.Text;
            //MessageBox.Show(imgloc.Text);

             baglanti.Open();

             SqlCommand komut = new SqlCommand("select * from film_bilgi where filmresim=@r1", baglanti);
             komut.Parameters.AddWithValue("@r1", imgloc.Text);

              SqlDataReader dr = komut.ExecuteReader();
             
             if (dr.Read())
             {
                float puan = float.Parse( dr[7].ToString());
                float kisisayisi = float.Parse(dr[8].ToString());

                label2.Text = puan.ToString();
                label3.Text = kisisayisi.ToString();

                
                icerikismLbl.Text = dr[1].ToString();
                lblYonetmen.Text = "Yönetmen: " +  dr[3].ToString();
                lblYil.Text = "Yapım yılı: " +  dr[4].ToString();
                icerikkonutxtBox.Text = dr[5].ToString();
                icerikrsmPicBox.ImageLocation = dr[6].ToString();
                puanlbl.Text = "Puan: " + (float.Parse(label2.Text) / float.Parse(label3.Text)) +"/5";




            }

       
             
            baglanti.Close();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Herhangi bir puan seçmediniz!", "Değer Seçilmedi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                label4.Text = comboBox1.SelectedItem.ToString();

                baglanti.Open();

                float a = float.Parse(label2.Text);
                float b = float.Parse(label3.Text);
                float c = float.Parse(label4.Text);


                SqlCommand komut2 = new SqlCommand("update film_bilgi set filmpuan=@a1,oyveren=@a2 where filmresim=@d1", baglanti);

                komut2.Parameters.AddWithValue("@a1", a + c);
                komut2.Parameters.AddWithValue("@a2", b + 1);
                komut2.Parameters.AddWithValue("@d1", imgloc.Text);


                komut2.ExecuteNonQuery();
                baglanti.Close();
            }
            

            
        }


    }
}
