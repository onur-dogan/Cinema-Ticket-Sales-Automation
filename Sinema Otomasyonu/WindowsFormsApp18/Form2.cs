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
    public partial class kullanici_formu : Form
    {
        public kullanici_formu()
        {
            InitializeComponent();
           

        }
       

        public void kullanici_formu_Load(object sender, EventArgs e)
        {
          
        }

        public void uye_ol_Click(object sender, EventArgs e)
        {
            Uye_Ol form = new Uye_Ol();
            form.Show();
            this.Hide();
            
        }
        SqlConnection baglanti = new SqlConnection(@"server=LAPTOP-L5U40NOS\ONUR_SQL;Initial Catalog=sinema;Integrated Security=true");

        private void giris_butonu_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Boş Bırakılamaz");
            }
            else if (textBox2.Text == "")
            {
                errorProvider1.SetError(textBox2, "Boş Bırakılamaz");
            }
            else
            {
                baglanti.Open();
                string sql = "Select * from kullanicilar ";
                SqlCommand kmd = new SqlCommand(sql, baglanti);
                SqlDataReader kullanicilar = kmd.ExecuteReader();
                while (kullanicilar.Read())
                {
                    if (textBox1.Text == kullanicilar["kullanici_ismi"].ToString() && textBox2.Text == kullanicilar["kullanici_sifre"].ToString())
                    {
                        MessageBox.Show("it is true and done");
                        Form1 ss = new Form1();
                        ss.Show();
                        this.Hide();
                    }

                }

                    {
                        MessageBox.Show("Hatalı Giriş.. Lütfen Tekrar Deneyiniz.. Eğer şifrenizi unuttuysanıza Şifremi Unuttum butonunu tıklayarak yardım alabilirsiniz..");
                    }
                    baglanti.Close();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Sifremi_Unuttum frm = new Sifremi_Unuttum();
            frm.Show();
            this.Hide();
        }
    }
}
