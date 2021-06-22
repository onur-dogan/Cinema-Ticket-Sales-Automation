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
using System.Collections;

namespace WindowsFormsApp18
{
    public partial class Bilet_Alma : Form
    {
        public Bilet_Alma()
        {

            InitializeComponent();


        }
        SqlConnection cnt = new SqlConnection(@"server=LAPTOP-L5U40NOS\ONUR_SQL;Initial Catalog=sinema;Integrated Security=true");
        
        public static string gonderilecekveri;
        
        int kirmizi_koltuk = 0;
        int fiyat;
        int count = 0;
        int[] koltuknumarasi = new int[42];
        int[] secilen_koltuk = new int[42];
        
        public void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = kullanici_formu.gonderilecekveri;
            label4.Text = Film_Secimi.gonderilecekveri;
            label6.Text = Film_Secimi.gonderilecekveri2;
            label8.Text = Film_Secimi.gonderilecekveri3;

            cnt.Open();
            string kayit = "SELECT bilet_numarasi from biletler where salon_nosu=@salon_nosu and bilet_saati=@bilet_saati";
            SqlCommand komut = new SqlCommand(kayit, cnt);
            komut.Parameters.AddWithValue("@bilet_saati", label6.Text);
            komut.Parameters.AddWithValue("@salon_nosu", label8.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                    foreach (Control item in this.Controls)
                    {
                        if (item is Button)
                        {
                            Button Btn = item as Button;
                            if (Btn.Text ==dr["bilet_numarasi"].ToString())
                            {
                                Btn.BackColor = Color.Red;
                                Btn.ForeColor = Color.Blue;
                                Btn.Enabled = false;
                        }
                    }
                }
            }
                cnt.Close();
        }
        public void renkdegisimi(object sender, EventArgs e)
        {
            Button cmd = (Button)sender;

            if (cmd.BackColor == Color.White)
            {
                count++;
                cmd.BackColor = Color.Orange;
                int b = int.Parse(cmd.Text);
                koltuknumarasi[count] = b;
                if (count > 1)
                {
                    int a = 1;
                    label3.Text = "";

                    while (a <= count)
                    {
                        int nmber = koltuknumarasi[a];
                        if (nmber > 0 && nmber < 9)
                        {
                            label3.Text += ( koltuknumarasi[a] + " ");
                        }
                        else if (nmber < 17 && nmber > 8)
                        {
                            label3.Text += (koltuknumarasi[a]+" "  );
                        }
                        else if (nmber > 16 && nmber < 24)
                        {
                            label3.Text += ( koltuknumarasi[a] + " ");
                        }
                        else if (nmber > 23 && nmber < 31)
                        {
                            label3.Text += ( koltuknumarasi[a] + " ");
                        }
                        else if (nmber > 30 && nmber < 37)
                        {
                            label3.Text += ( koltuknumarasi[a] + " ");
                        }
                        else if(nmber > 37 && nmber < 42)
                        {
                            label3.Text += (koltuknumarasi[a] + " ");
                        }
                        a++;
                    }
                }
                else if (count == 1)
                {
                    label3.Text = "";
                    label3.Text = (koltuknumarasi[count] + "");
                }
                else
                {
                    label3.Text = "Koltuk numaranızı seçiniz";
                }
                label2.Text = "";
                label2.Text = count.ToString();
            }
        
            else if (cmd.BackColor == Color.Orange)
            {
                cmd.BackColor = Color.White;
                for (int a = count; a>0; a--)
                {
                    int k = int.Parse(cmd.Text);
                    if (k == koltuknumarasi[a])
                    {
                        for (int p = a; p <= count; p++)
                        {
                            koltuknumarasi[p] = koltuknumarasi[p + 1];
                        }
                        count--;
                    }
                    else
                        continue;
                }
                if (count > 1)
                {
                    int a = 0;
                    label3.Text = "";

                    while (a <= count)
                    {
                        int nmber = koltuknumarasi[a];
                        if (nmber > 0 && nmber < 9)
                        {
                            label3.Text += (koltuknumarasi[a] + " ");
                        }
                        else if (nmber < 17 && nmber > 8)
                        {
                            label3.Text += ( koltuknumarasi[a] + " ");
                        }
                        else if (nmber > 16 && nmber < 24)
                        {
                            label3.Text += ( koltuknumarasi[a] + " ");
                        }
                        else if (nmber > 23 && nmber < 31)
                        {
                            label3.Text += ( koltuknumarasi[a] + " ");
                        }
                        else if (nmber > 30 && nmber < 37)
                        {
                            label3.Text += ( koltuknumarasi[a] + " ");
                        }
                        else if(nmber > 37 && nmber < 42)
                        {
                            label3.Text += ( koltuknumarasi[a] + " ");
                        }
                        
                        a++;
                    }


                }
                else if (count == 1)
                {
                    label3.Text = "";
                    label3.Text = (koltuknumarasi[count] + "");
                }
                else
                {
                    label3.Text = "Koltuk numaranızı seçiniz";
                }

                label2.Text = "";
                label2.Text = count .ToString();


            }

            else 
            {
                toolTip1.Active = true;
                toolTip1.InitialDelay = 1000;
                toolTip1.ReshowDelay = 2000;
                toolTip1.UseAnimation = true;
                toolTip1.ToolTipTitle = "İt has already taken.";
                toolTip1.ToolTipIcon = ToolTipIcon.Warning;
                toolTip1.BackColor = Color.Red;
                toolTip1.ForeColor = Color.Black;
            }
           
        }
        public void buttonsec_Click(object sender, EventArgs e)
        {
            int syc = -1;
            if (radioButton1.Checked != true && radioButton2.Checked != true)
            {
                MessageBox.Show("Choose for the one of buying choices ( Student or Normal )");
                }
            else
            {

                foreach (Control item in this.Controls)// eger butonlar panel içindeyse this yerine panel1
                {
                    if (item is Button)
                    {
                        Button Btn = item as Button;
                        if (Btn.BackColor == Color.Orange)
                        {
                            syc++;
                            Btn.BackColor = Color.Red;
                            Btn.ForeColor = Color.Blue;
                            Btn.Enabled = false;
                            kirmizi_koltuk++;
                            secilen_koltuk[syc] =int.Parse( Btn.Text);
                        }
                       
                    }
                }
                if (kirmizi_koltuk == 0)
                {
                    MessageBox.Show("You have to choose one of the chairs");
                }
                else if (kirmizi_koltuk == 1)
                {
                    if (radioButton1.Checked == true)
                    {
                        fiyat =  10;
                        MessageBox.Show("Ticket is bought . The price you will pay : "+fiyat);
                    }
                    else if (radioButton2.Checked == true && kirmizi_koltuk == 1)
                    {
                        fiyat = 14;
                        MessageBox.Show("Ticket is bought . The price you will pay : "+fiyat);
                    }
                    string sml = "insert into biletler(kullanici_ismi,bilet_numarasi,bilet_saati,film_ismi,bilet_ücreti,salon_nosu)values (@kullanici_ismi,@bilet_numarasi,@bilet_saati,@film_ismi,@bilet_ücreti,@salon_nosu)";
                    SqlCommand kmd = new SqlCommand(sml, cnt);
                    kmd.Parameters.AddWithValue("kullanici_ismi", label1.Text);
                    kmd.Parameters.AddWithValue("bilet_numarasi", secilen_koltuk[syc]);
                    kmd.Parameters.AddWithValue("bilet_saati", label6.Text);
                    kmd.Parameters.AddWithValue("film_ismi", label4.Text);
                    kmd.Parameters.AddWithValue("bilet_ücreti", fiyat);
                    kmd.Parameters.AddWithValue("salon_nosu", label8.Text);
                    cnt.Open();
                    kmd.ExecuteNonQuery();
                    cnt.Close();
                Hesap ss = new Hesap();
                            ss.Show();
                            this.Hide();
                }
                else if (kirmizi_koltuk > 1)
                {
                    if (radioButton1.Checked == true )
                    {
                        fiyat = 10;
                        MessageBox.Show("Tickets are bought . The price you will pay :  " + (fiyat*kirmizi_koltuk));
                    }
                    else if (radioButton2.Checked == true)
                    {
                        fiyat =14;
                        MessageBox.Show("Tickets are bought . The price you will pay :  " + (fiyat*kirmizi_koltuk));
                    }
                    for (int c = 0; c <=syc; c++)
                    {
                        int a = secilen_koltuk[c];
                        string sml = "insert into biletler(kullanici_ismi,bilet_numarasi,bilet_saati,film_ismi,bilet_ücreti,salon_nosu)values (@kullanici_ismi,@bilet_numarasi,@bilet_saati,@film_ismi,@bilet_ücreti,@salon_nosu)";
                        SqlCommand kmd = new SqlCommand(sml, cnt);
                        kmd.Parameters.AddWithValue("kullanici_ismi", label1.Text);
                        kmd.Parameters.AddWithValue("bilet_numarasi", a);
                        kmd.Parameters.AddWithValue("bilet_saati", label6.Text);
                        kmd.Parameters.AddWithValue("film_ismi", label4.Text);
                        kmd.Parameters.AddWithValue("bilet_ücreti", fiyat);
                        kmd.Parameters.AddWithValue("salon_nosu", label8.Text);
                        cnt.Open();
                        kmd.ExecuteNonQuery();
                        cnt.Close();
                    }
                    Hesap ss = new Hesap();
                    ss.Show();
                    this.Hide();
                }
            }
        }
        private void button43_Click(object sender, EventArgs e)
        {
            Film_Secimi ss = new Film_Secimi();
            ss.Show();
            this.Hide();
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

    }
    }