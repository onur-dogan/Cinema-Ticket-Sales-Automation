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
    public partial class Uye_Ol : Form
    {
        public Uye_Ol()
        {
            InitializeComponent();
            



        }
        public void kontrol()
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        SqlConnection cnt = new SqlConnection(@"server=LAPTOP-L5U40NOS\ONUR_SQL;Initial Catalog=sinema;Integrated Security=true");
            ErrorProvider provider1 = new ErrorProvider();
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text==string.Empty)
            {
                provider1.SetError(textBox1, "Boş Geçilemez");
            }
            else
            {
                provider1.Clear();
            }
             if (textBox2.Text.Trim() == "")
            {
                provider1.SetError(textBox2, "Boş Geçilemez");
            }
             else if (textBox3.Text == "")
            {
                provider1.SetError(textBox3, "Boş Geçilemez");
            }
            else if (textBox4.Text.Trim() == "")
            {
                provider1.SetError(textBox4, "Boş Geçilemez");
            }
            else  if (textBox5.Text.Trim() == "")
            {
                provider1.SetError(textBox5, "Boş Geçilemez");
            }
            else if (textBox6.Text.Trim() == "")
            {
                provider1.SetError(textBox6, "Boş Geçilemez");
            }
            else if (textBox7.Text.Trim() == "")
            {
                provider1.SetError(textBox7, "Boş Geçilemez");
            }
            else if(comboBox1.Text=="")
            {
                provider1.SetError(comboBox1, "Boş Geçilemez");
            }
             else if(comboBox2.Text=="")
            {
                provider1.SetError(comboBox2, "Boş Geçilemez");
            }
             else if(textBox9.Text.Trim()=="")
            {
                provider1.SetError(textBox9, "Boş Geçilemez");
            }
             else if(textBox6.Text.Length<10)
            {
                provider1.SetError(textBox6, "Şifrenizin en az 10 karakterden oluşması gerekmektedir");
            }
            else if (textBox6.Text != textBox7.Text)
            {
                provider1.SetError(textBox7, "Şifrelerin Aynı Olması Gerekmektedir");
            }
            else
            {
                provider1.Clear();
                string sml = "insert into kullanicilar (kullanici_ismi, kullanici_soyadi, kullanici_yasi, kullanici_mail,kullanici_adi,kullanici_sifre,guvenlik_sorusu,guvenlik_cevabi) values(@kullanici_ismi,@kullanici_soyadi,@kullanici_yasi,@kullanici_mail,@kullanici_adi,@kullanici_sifre,@guvenlik_sorusu,@guvenlik_cevabi)";
                SqlCommand kmd = new SqlCommand(sml, cnt);
                kmd.Parameters.AddWithValue("kullanici_adi", textBox1.Text);
                kmd.Parameters.AddWithValue("kullanici_soyadi", textBox2.Text);
                kmd.Parameters.AddWithValue("kullanici_yasi", textBox3.Text);
                kmd.Parameters.AddWithValue("kullanici_sifre", textBox6.Text);
                kmd.Parameters.AddWithValue("guvenlik_sorusu", comboBox2.Text);
                kmd.Parameters.AddWithValue("guvenlik_cevabi", textBox9.Text);
                cnt.Open();
                kmd.CommandText = "SELECT * FROM kullanicilar WHERE kullanici_ismi=@kullanici_ismi";
                kmd.Parameters.AddWithValue("@kullanici_ismi", textBox5.Text);
                object kullanici_ismi_sorgulama = kmd.ExecuteScalar();
                kmd.Parameters.Clear();
                kmd.CommandText = "SELECT * FROM kullanicilar WHERE kullanici_mail=@kullanici_mail";
                kmd.Parameters.AddWithValue("kullanici_mail", (textBox4.Text + label9.Text + comboBox1.Text));
                object mail_sorgulama = kmd.ExecuteScalar();
                kmd.Parameters.Clear();

                if (kullanici_ismi_sorgulama != null)
                {
                    MessageBox.Show("Bu kullanıcı zaten var.!.");
                    cnt.Close();
                }
                else if(mail_sorgulama!=null)
                {
                    MessageBox.Show("Bu mail ile açılmış bir hesap bulunmakta");
                    cnt.Close();
                }
                else
                {
                    kmd.Parameters.AddWithValue("kullanici_ismi", textBox5.Text);
                    kmd.Parameters.AddWithValue("kullanici_mail", (textBox4.Text + label9.Text + comboBox1.Text));
                    kmd.ExecuteNonQuery();
                    cnt.Close();
                    MessageBox.Show("Kaydınız Tamamlandı.Hayırlı Olsun Dileklerimizi İletir Mutlu Günler Dileriz..Giriş Yapabilirsiniz ");
                    kullanici_formu ss = new kullanici_formu();
                    ss.Show();
                    this.Hide();
                }
            }
            

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {

                if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
                {
                    e.Handled = false;//eğer rakamsa  yazdır.
                }

                else if ((int)e.KeyChar == 8)
                {
                    e.Handled = false;//eğer basılan tuş backspace ise yazdır.
                }
                else
                {
                    e.Handled = true;//bunların dışındaysa hiçbirisini yazdırma
                provider1.SetError(textBox1, "Boş Geçilemez");

            }

        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
               if((int)e.KeyChar>=65 &&(int)e.KeyChar<=90 ||(int) e.KeyChar>=97 &&(int) e.KeyChar<=122)
            {

                e.Handled = false;
            }
                else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;//eğer basılan tuş backspace ise yazdır.
            }
               else
            {
                e.Handled = true;

                provider1.SetError(textBox1, "Boş Geçilemez");

            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Uye_Ol_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            kullanici_formu b = new kullanici_formu();
            b.Show();
            this.Hide();
        }
    }
}
