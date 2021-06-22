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

        public static string gonderilecekveri;
        SqlConnection baglanti = new SqlConnection(@"server=LAPTOP-L5U40NOS\ONUR_SQL;Initial Catalog=sinema;Integrated Security=true");
        private void button1_Click(object sender, EventArgs e)
        {

            int cnt = 0;
            if (kullanici_adi.Text == "")
            {
                errorProvider2.SetError(kullanici_adi, "Boş Bırakılamaz");
            }
            else if (kullanici_sifre.Text == "" && kullanici_adi.Text!="")
            {
                errorProvider2.Clear();
                errorProvider2.SetError(kullanici_sifre, "Boş Bırakılamaz");
            }
            else if(kullanici_sifre.Text=="")
            {
                errorProvider2.SetError(kullanici_sifre, "Boş Bırakılamaz");
            }
            else
            {
                baglanti.Open();
                string sql = "Select * from kullanicilar ";
                SqlCommand kmd = new SqlCommand(sql, baglanti);
                SqlDataReader kullanicilar = kmd.ExecuteReader();
                while (kullanicilar.Read())
                {
                    if (kullanici_adi.Text == kullanicilar["kullanici_ismi"].ToString() && kullanici_sifre.Text == kullanicilar["kullanici_sifre"].ToString())
                    {
                        gonderilecekveri = kullanici_adi.Text;
                        cnt = 1;
                        MessageBox.Show("Sistemimize Hoşgeldiniz");
                        Film_Secimi ss = new Film_Secimi();
                        ss.Show();
                        this.Hide();
                    }

                }
                if (cnt != 1)

                {
                    MessageBox.Show("Hatalı Giriş.. Lütfen Tekrar Deneyiniz.. Eğer şifrenizi unuttuysanıza Şifremi Unuttum butonunu tıklayarak yardım alabilirsiniz..");
                }
                baglanti.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Uye_Ol form = new Uye_Ol();
            form.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {

            Sifremi_Unuttum frm = new Sifremi_Unuttum();
            frm.Show();
            this.Hide();
        }

        private void kullanici_formu_Load(object sender, EventArgs e)
        {

        }
    }
}