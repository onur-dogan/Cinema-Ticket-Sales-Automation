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
    public partial class Hesap : Form
    {
        public Hesap()
        {
            InitializeComponent();
        }
        SqlConnection cnt = new SqlConnection(@"server=LAPTOP-L5U40NOS\ONUR_SQL;Initial Catalog=sinema;Integrated Security=true");
                SqlCommand komut = new SqlCommand();
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Hesap_Load(object sender, EventArgs e)
        {
            kullaniciadi.Text = kullanici_formu.gonderilecekveri;
            biletlerigoster();
        }
        void biletlerigoster()
        {

            cnt.Open();
            string kayit = "Select * from biletler where kullanici_ismi=@kullanici_ismi";
            SqlCommand command = new SqlCommand(kayit, cnt);
            command.Parameters.AddWithValue("@kullanici_ismi", kullaniciadi.Text);
            SqlDataAdapter adapt = new SqlDataAdapter(command);
            DataTable d = new DataTable();
            adapt.Fill(d);
            dataGridView1.DataSource = d;
            cnt.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult cevap;
            cevap = MessageBox.Show("Kaydı Silmek İstediğinizden Eminmisiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cevap == DialogResult.Yes)
            {
                cnt.Open();
                komut.Connection = cnt;
                komut.CommandText = "DELETE from biletler where bilet_numarasi='" + dataGridView1.CurrentRow.Cells["bilet_numarasi"].Value.ToString() + "'and salon_nosu= '" + dataGridView1.CurrentRow.Cells["salon_nosu"].Value.ToString() +"'";
                komut.ExecuteNonQuery();
                cnt.Close();
            }
            biletlerigoster();
                }

        private void button2_Click(object sender, EventArgs e)
        {
            Film_Secimi ss = new Film_Secimi();
            ss.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Hesap_Güncelleme ss = new Hesap_Güncelleme();
            ss.Show();
            this.Hide();
        }
    }
        }
