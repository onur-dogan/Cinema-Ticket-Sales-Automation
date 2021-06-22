using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp18
{
    public partial class Film_Secimi : Form
    {
        int count=0;
        public Film_Secimi()
        {
            InitializeComponent();
        }
        public static string gonderilecekveri;
        public static string gonderilecekveri2;
        public static string gonderilecekveri3;

        void lotr()
        {
            film_ismi.Text = "LORD OF THE RINGS";
            richTextBox1.Text = "Director: Peter Jackson " + Environment.NewLine + "Writers: J.R.R. Tolkien (novel), Fran Walsh (screenplay)" + Environment.NewLine + "Stars: Elijah Wood, Viggo Mortensen, Ian McKellen " + Environment.NewLine + "                                                                                                              Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.";
            label4.Text = "Salon 1";
        }
        void karayipkorsanlari()
        {
            film_ismi.Text = "PIRATES OF THE CARIBBEAN";
            richTextBox1.Text = "Director: Gore Verbinski " + Environment.NewLine + "Writers: Ted Elliott(screen story), Terry Rossio(screen story)" + Environment.NewLine + "Stars: Johnny Depp, Geoffrey Rush, Orlando Bloom" + Environment.NewLine + "                                                                                                              Captain Jack Sparrow is pursued by old rival Captain Salazar and a crew of deadly ghosts who have escaped from the Devil's Triangle. They're determined to kill every pirate at sea...notably Jack.";

            label4.Text = "Salon 2";
        }
        void hobbit()
        {
            film_ismi.Text = "THE HOBBIT";
            richTextBox1.Text = "Director: Peter Jackson " + Environment.NewLine + "Writers: Fran Walsh (screenplay), Philippa Boyens (screenplay) " + Environment.NewLine + "Stars: Ian McKellen, Martin Freeman, Richard Armitage" + Environment.NewLine + "                                                                                                              Bilbo and company are forced to engage in a war against an array of combatants and keep the Lonely Mountain from falling into the hands of a rising darkness.";

            label4.Text = "Salon 3";
        }
        void avatar()
        {
            film_ismi.Text = "THE AVATAR";
            richTextBox1.Text = "Director: James Cameron " + Environment.NewLine + "Writer: James Cameron " + Environment.NewLine + "Stars: Sam Worthington, Zoe Saldana, Sigourney Weaver " + Environment.NewLine + "                                                                                                              A paraplegic Marine dispatched to the moon Pandora on a unique mission becomes torn between following his orders and protecting the world he feels is his home.";

            label4.Text = "Salon 4";
        }
        private void Film_secimi_Load(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
            DateTime dt = DateTime.Now;
            int a = dt.Hour;
            int b = dt.Minute;
            lotr();
            kullaniciadi.Text = kullanici_formu.gonderilecekveri;
            pictureBox1.Image = ımageList1.Images[count];
            DateTime zaman1 = new DateTime(2020, 12, 5, 13, 0, 0);
            DateTime zaman2 = new DateTime(2020, 12, 5, 17, 30, 0);
            DateTime zaman3 = new DateTime(2020, 12, 5, 20, 30, 0);
            int saat = zaman1.Hour;
            int dakika = zaman1.Minute;
            if (saat < a || (saat==a && dakika<b))
            {
                comboBox1.Items[0]+="(Zamanı Geçti)";
                saat = zaman2.Hour;
                dakika = zaman2.Minute;
            }
            if(saat<a || (saat == a && dakika < b))
            {
                comboBox1.Items[1] += "(Zamanı Geçti)";
                saat = zaman3.Hour;
                dakika = zaman3.Minute;
            }
            if(saat<a || (saat == a && dakika < b))
            {
                comboBox1.Items[2] += "(Zamanı Geçti)";
                comboBox1.SelectedIndex = -1;
            }
        }


        private void saga_git_Click(object sender, EventArgs e)
        { 
            
            if(count==3)
            {
                count = 0;
                pictureBox1.Image = ımageList1.Images[count];
            }
            else
            {
                count++;
                pictureBox1.Image = ımageList1.Images[count];
            } 
            if(count==0)
            {
                lotr();
            }
            else if (count == 1)
            {
                karayipkorsanlari();
            }
            else if (count == 2)
            {
                hobbit();
            }
            else if (count == 3)
            {
                avatar();
            }
           
        }

        private void sola_git_Click(object sender, EventArgs e)
        {


            if (count == 0)
            {
                count = 3;
                pictureBox1.Image = ımageList1.Images[count];
            }
            else
            {
                count--;
                pictureBox1.Image = ımageList1.Images[count];
            }
            if (count == 0)
            {
                lotr();
            }
            else if (count == 1)
            {
                karayipkorsanlari();
            }
            else if (count == 2)
            {
                hobbit();
            }
            else if (count == 3)
            {
                avatar();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.Text == "")
            {
                MessageBox.Show("You have to choose on of sessions");
            }
            else
            {
                gonderilecekveri = film_ismi.Text;
                gonderilecekveri2 = comboBox1.Text;
                gonderilecekveri3 = label4.Text;
                Bilet_Alma fors = new Bilet_Alma();
                this.Hide();
                fors.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hesap ss = new Hesap();
            ss.Show();
            this.Hide();
        }
        private void film_ismi_Click(object sender, EventArgs e)
        {
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedIndex == 0 && comboBox1.Text== "13:00-15:30(Zamanı Geçti)") { comboBox1.SelectedIndex = -1; }
            if (comboBox1.SelectedIndex == 1 && comboBox1.Text == "17:30-20:00(Zamanı Geçti)") { comboBox1.SelectedIndex = -1; }
            if (comboBox1.SelectedIndex == 2 && comboBox1.Text == "20:30-23:00(Zamanı Geçti)") { comboBox1.SelectedIndex = -1; }
        }

        private void kullaniciadi_Click(object sender, EventArgs e)
        {

        }
    }
}
