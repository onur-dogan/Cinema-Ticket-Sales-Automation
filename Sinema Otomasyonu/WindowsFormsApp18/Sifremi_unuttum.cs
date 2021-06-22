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
using System.Net.Mail;
using System.IO;

namespace WindowsFormsApp18
{
    public partial class Sifremi_Unuttum : Form
    {
        public Sifremi_Unuttum()
        {
            InitializeComponent();
        }
        SqlConnection cnt = new SqlConnection(@"server=LAPTOP-L5U40NOS\ONUR_SQL;Initial Catalog=sinema;Integrated Security=true");

        private void button1_Click(object sender, EventArgs e)
        {
            cnt.Open();
            SqlCommand SqlKomut;
            SqlKomut = new SqlCommand("SELECT * from kullanicilar WHERE kullanici_ismi='" + textBox1.Text + "' and kullanici_mail='" + textBox2.Text + "' and guvenlik_sorusu='" + comboBox1.Text + "' and guvenlik_cevabi='" + textBox3.Text + "'", cnt);
            SqlDataReader kullanicilar = SqlKomut.ExecuteReader();
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Hiçbir Kutucuk Boş Geçilemez");
            }
            else if (kullanicilar.Read())
            {
                string icerik = kullanicilar["kullanici_sifre"].ToString();
            try
            {
                SmtpClient smtp = new SmtpClient();
                smtp.Credentials = new System.Net.NetworkCredential("aindres1461@gmail.com","*******");
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                MailMessage ePosta = new MailMessage();
                ePosta.From = new MailAddress("aindres1461@gmail.com",textBox1.Text);
                ePosta.To.Add(textBox2.Text);
                ePosta.Subject = "Şifremi Unuttum";
                ePosta.Body = icerik;
                smtp.Send(ePosta);
                MessageBox.Show("it is okey");
            }
            catch
            {
                MessageBox.Show("Bilgilerinizi Yanlış Girmiş Bulunmaktasınız..");
                    cnt.Close();
            }
                
            }
            cnt.Close();
        }

        }
    
}
