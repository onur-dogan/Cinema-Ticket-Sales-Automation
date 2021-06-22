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

namespace WindowsFormsApp18
{
    public partial class Hesap_Güncelleme : Form
    {
        public Hesap_Güncelleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"server=LAPTOP-L5U40NOS\ONUR_SQL;Initial Catalog=sinema;Integrated Security=true");
        ErrorProvider provider1 = new ErrorProvider();
        private void Hesap_Güncelleme_Load(object sender, EventArgs e)
        {
            label1.Text = kullanici_formu.gonderilecekveri;
            button1.Visible = false;
            textBox7.Visible = false;
            button2.Visible = false;
            textBox8.Visible = false;
            button3.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            button4.Visible = false;
            textBox11.Visible = false;
            button5.Visible = false;
            güvenlik_sorusu.Visible = false;
            textBox12.Visible = false;
            bilgilerigöster();
        }

        void bilgilerigöster()
        {

            baglanti.Open();
            string kayit = "SELECT * from kullanicilar where kullanici_ismi=@kullanici_ismi";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@kullanici_ismi", label1.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                textBox1.Text = dr["kullanici_adi"].ToString();
                textBox2.Text = dr["kullanici_soyadi"].ToString();
                textBox3.Text = dr["kullanici_sifre"].ToString();
                textBox4.Text = dr["kullanici_yasi"].ToString();
                textBox5.Text = dr["guvenlik_sorusu"].ToString();
                textBox6.Text = dr["guvenlik_cevabi"].ToString();
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                textBox5.Enabled = false;
                textBox6.Enabled = false;

            }
            baglanti.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            textBox7.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox7.Text.Trim() == "")
            {
                provider1.SetError(textBox7, "Boş Geçilemez");
            }
            else
            {
                baglanti.Open();
                string kayit = "update kullanicilar set kullanici_adi=@kullanici_adi where kullanici_ismi=@kullanici_ismi";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                komut.Parameters.AddWithValue("@kullanici_ismi", label1.Text);
                komut.Parameters.AddWithValue("@kullanici_adi", textBox7.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kullanıcı adınız güncellendi.");
                button1.Visible = false;
                textBox7.Visible = false;
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            textBox8.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox8.Text.Trim() == "")
            {
                provider1.SetError(textBox8, "Boş Geçilemez");
            }
            else
            {
                baglanti.Open();
                string kayit = "update kullanicilar set kullanici_soyadi=@kullanici_soyadi where kullanici_ismi=@kullanici_ismi";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                komut.Parameters.AddWithValue("@kullanici_ismi", label1.Text);
                komut.Parameters.AddWithValue("@kullanici_soyadi", textBox8.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kullanıcı soyadınız güncellendi.");
                button2.Visible = false;
                textBox8.Visible = false;
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            button3.Visible = true;
            textBox9.Visible = true;
            textBox10.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox9.Text.Trim() == "")
            {
                provider1.SetError(textBox9, "Boş Geçilemez");
            }
            if (textBox10.Text.Trim() == "")
            {
                provider1.SetError(textBox10, "Boş Geçilemez");
            }
            else if (textBox9.Text != textBox9.Text)
            {
                provider1.SetError(textBox9, "Şifrelerin Aynı Olması Gerekmektedir");
            }
            else if (textBox9.Text.Length < 10 && textBox10.Text.Length < 10)
            {
                provider1.SetError(textBox9, "Şifrenizin en az 10 karakterden oluşması gerekmektedir");
            }
            else
            {
                baglanti.Open();
                string kayit = "update kullanicilar set kullanici_sifre=@kullanici_sifre where kullanici_ismi=@kullanici_ismi";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                komut.Parameters.AddWithValue("@kullanici_ismi", label1.Text);
                komut.Parameters.AddWithValue("@kullanici_sifre", textBox9.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kullanıcı şifreniz güncellendi.");
                button3.Visible = false;
                textBox9.Visible = false;
                textBox10.Visible = false;
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            button4.Visible = true;
            textBox11.Visible = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox11.Text.Trim() == "")
            {
                provider1.SetError(textBox11, "Boş Geçilemez");
            }
            else
            {
                baglanti.Open();
                string kayit = "update kullanicilar set kullanici_yasi=@kullanici_yasi where kullanici_ismi=@kullanici_ismi";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                komut.Parameters.AddWithValue("@kullanici_ismi", label1.Text);
                komut.Parameters.AddWithValue("@kullanici_yasi", textBox11.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kullanıcı yaşınız güncellendi.");
                button4.Visible = false;
                textBox11.Visible = false;
            }

        }

        private void label14_Click(object sender, EventArgs e)
        {
            button5.Visible = true;
            güvenlik_sorusu.Visible = true;
            textBox12.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (güvenlik_sorusu.Text.Trim() == "")
            {
                provider1.SetError(güvenlik_sorusu, "Boş Geçilemez");
            }
            else if (textBox12.Text.Trim() == "")
            {
                provider1.SetError(textBox12, "Boş Geçilemez");
            }
            else
            {
                baglanti.Open();
                string kayit = "update kullanicilar set güvenlik_sorusu=@güvenlik_sorusu where kullanici_ismi=@kullanici_ismi";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                komut.Parameters.AddWithValue("@kullanici_ismi", label1.Text);
                komut.Parameters.AddWithValue("@guvenlik_sorusu", güvenlik_sorusu.Text);
                komut.Parameters.AddWithValue("@guvenlik_cevabi", textBox12.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kullanıcı güvenlik sorunuz güncellendi.");
                button5.Visible = false;
                güvenlik_sorusu.Visible = false;
                textBox12.Visible = false;
            }
        }


        private void button6_Click_1(object sender, EventArgs e)
        {
            Hesap ss = new Hesap();
            ss.Show();
            this.Hide();
        }
        private void label15_Click(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
