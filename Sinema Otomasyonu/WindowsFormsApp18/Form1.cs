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
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();


        }
        
        
        
        int count = 0;
        string[] koltuknumarasi = new string[42];

        public void renkdegisimi(object sender, EventArgs e)
        {
            Button cmd = (Button)sender;
            if (cmd.BackColor == Color.Orange)
            {
                cmd.BackColor = Color.White;
                koltuknumarasi[count] = "";
                count--;

            }
            else if(cmd.BackColor==Color.White)
            {
                cmd.BackColor = Color.Orange;
                count++;
                int b = int.Parse(cmd.Text);
                if (b < 9)
                {
                    koltuknumarasi[count] = b + "/A";
                }
                else if (b < 17 && b > 8)
                {

                    koltuknumarasi[count] = b + "/B";
                }
                else if (b > 16 && b < 24)
                {

                    koltuknumarasi[count] = b + "/C";
                }
                else if (b > 23 && b < 31)
                {

                    koltuknumarasi[count] = b + "/D";
                }
                else if (b > 30 && b < 37)
                {

                    koltuknumarasi[count] = b + "/E";
                }
                else
                {

                    koltuknumarasi[count] = b + "/F";
                }
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
            if (count > 1)
            {
                int a = 1;
                label2.Text = "";

                while (a <= count)
                {
                    label2.Text += (" " + koltuknumarasi[a]);
                    a++;
                }


            }
            else if (count == 1)
            {
                label2.Text = "";
                label2.Text += (koltuknumarasi[count] + " koltuk numaranız");
            }
            else
            {
                label2.Text = "Koltuk numaranızı seçiniz";
            }

            label3.Text = "";
            label3.Text = (count + "adet");

        }
        public void Form1_Load(object sender, EventArgs e)
        {


        }
        public void buttonsec_Click(object sender, EventArgs e)
        {
            if(button1.BackColor==Color.Orange)
            {
                button1.BackColor = Color.Red;
                button1.ForeColor = Color.Blue;
                button1.Enabled = false;
            }

            if (button2.BackColor == Color.Orange)
            {
                button2.BackColor = Color.Red;
                button2.ForeColor = Color.Blue;
                button2.Enabled = false;
            }
            if (button3.BackColor == Color.Orange)
            {
                button3.BackColor = Color.Red;
                button3.ForeColor = Color.Blue;
                button3.Enabled = false;
            }

            if (button4.BackColor == Color.Orange)
            {
                button4.BackColor = Color.Red;
                button4.ForeColor = Color.Blue;
                button4.Enabled = false;
            }
            if (button5.BackColor == Color.Orange)
            {
                button5.BackColor = Color.Red;
                button5.ForeColor = Color.Blue;
                button5.Enabled = false;

            }
            if (button6.BackColor == Color.Orange)
            {
                button6.BackColor = Color.Red;
                button6.ForeColor = Color.Blue;
                button6.Enabled = false;
            }
            if (button7.BackColor == Color.Orange)
            {
                button7.BackColor = Color.Red;
                button7.ForeColor = Color.Blue;
                button7.Enabled = false;
            }
            if (button8.BackColor == Color.Orange)
            {
                button8.BackColor = Color.Red;
                button8.ForeColor = Color.Blue;
                button8.Enabled = false;
            }
            if (button9.BackColor == Color.Orange)
            {
                button9.BackColor = Color.Red;
                button9.ForeColor = Color.Blue;
                button9.Enabled = false;
            }
            if (button10.BackColor == Color.Orange)
            {
                button10.BackColor = Color.Red;
                button10.ForeColor = Color.Blue;
                button10.Enabled = false;
            }
            if (button11.BackColor == Color.Orange)
            {
                button11.BackColor = Color.Red;
                button11.ForeColor = Color.Blue;
                button11.Enabled = false;
            }
            if (button12.BackColor == Color.Orange)
            {
                button12.BackColor = Color.Red;
                button12.ForeColor = Color.Blue;
                button12.Enabled = false;
            }
            if (button13.BackColor == Color.Orange)
            {
                button13.BackColor = Color.Red;
                button13.ForeColor = Color.Blue;
                button13.Enabled = false;
            }
            if (button14.BackColor == Color.Orange)
            {
                button14.BackColor = Color.Red;
                button14.ForeColor = Color.Blue;
                button14.Enabled = false;
            }
            if (button15.BackColor == Color.Orange)
            {
                button15.BackColor = Color.Red;
                button15.ForeColor = Color.Blue;
                button15.Enabled = false;
            }
            if (button16.BackColor == Color.Orange)
            {
                button16.BackColor = Color.Red;
                button16.ForeColor = Color.Blue;
                button16.Enabled = false;
            }
            if (button17.BackColor == Color.Orange)
            {
                button17.BackColor = Color.Red;
                button17.ForeColor = Color.Blue;
                button17.Enabled = false;
            }
            if (button18.BackColor == Color.Orange)
            {
                button18.BackColor = Color.Red;
                button18.ForeColor = Color.Blue;
                button18.Enabled = false;
            }
            if (button19.BackColor == Color.Orange)
            {
                button19.BackColor = Color.Red;
                button19.ForeColor = Color.Blue;
                button19.Enabled = false;
            }
            if (button20.BackColor == Color.Orange)
            {
                button20.BackColor = Color.Red;
                button20.ForeColor = Color.Blue;
                button20.Enabled = false;
            }
            if (button21.BackColor == Color.Orange)
            {
                button21.BackColor = Color.Red;
                button21.ForeColor = Color.Blue;
                button21.Enabled = false;
            }
            if (button22.BackColor == Color.Orange)
            {
                button22.BackColor = Color.Red;
                button22.ForeColor = Color.Blue;
                button22.Enabled = false;
            }
            if (button23.BackColor == Color.Orange)
            {
                button23.BackColor = Color.Red;
                button23.ForeColor = Color.Blue;
                button23.Enabled = false;
            }
            if (button24.BackColor == Color.Orange)
            {
                button24.BackColor = Color.Red;
                button24.ForeColor = Color.Blue;
                button24.Enabled = false;
            }
            if (button25.BackColor == Color.Orange)
            {
                button25.BackColor = Color.Red;
                button25.ForeColor = Color.Blue;
                button25.Enabled = false;
            }
            if (button26.BackColor == Color.Orange)
            {
                button26.BackColor = Color.Red;
                button26.ForeColor = Color.Blue;
                button26.Enabled = false;
            }
            if (button27.BackColor == Color.Orange)
            {
                button27.BackColor = Color.Red;
                button27.ForeColor = Color.Blue;
                button27.Enabled = false;
            }
            if (button28.BackColor == Color.Orange)
            {
                button28.BackColor = Color.Red;
                button28.ForeColor = Color.Blue;
                button28.Enabled = false;
            }
            if (button29.BackColor == Color.Orange)
            {
                button29.BackColor = Color.Red;
                button29.ForeColor = Color.Blue;
                button29.Enabled = false;
            }
            if (button30.BackColor == Color.Orange)
            {
                button30.BackColor = Color.Red;
                button30.ForeColor = Color.Blue;
                button30.Enabled = false;
            }
            if (button31.BackColor == Color.Orange)
            {
                button31.BackColor = Color.Red;
                button31.ForeColor = Color.Blue;
                button31.Enabled = false;
            }
            if (button32.BackColor == Color.Orange)
            {
                button32.BackColor = Color.Red;
                button32.ForeColor = Color.Blue;
                button32.Enabled = false;
            }
            if (button33.BackColor == Color.Orange)
            {
                button33.BackColor = Color.Red;
                button33.ForeColor = Color.Blue;
                button33.Enabled = false;
            }
            if (button34.BackColor == Color.Orange)
            {
                button34.BackColor = Color.Red;
                button34.ForeColor = Color.Blue;
                button34.Enabled = false;
            }
            if (button35.BackColor == Color.Orange)
            {
                button35.BackColor = Color.Red;
                button35.ForeColor = Color.Blue;
                button35.Enabled = false;
            }
            if (button36.BackColor == Color.Orange)
            {
                button36.BackColor = Color.Red;
                button36.ForeColor = Color.Blue;
                button36.Enabled = false;
            }
            if (button37.BackColor == Color.Orange)
            {
                button37.BackColor = Color.Red;
                button37.ForeColor = Color.Blue;
                button37.Enabled = false;
            }
            if (button38.BackColor == Color.Orange)
            {
                button38.BackColor = Color.Red;
                button38.ForeColor = Color.Blue;
                button38.Enabled = false;
            }
            if (button39.BackColor == Color.Orange)
            {
                button39.BackColor = Color.Red;
                button39.ForeColor = Color.Blue;
                button39.Enabled = false;
            }
            if (button40.BackColor == Color.Orange)
            {
                button40.BackColor = Color.Red;
                button40.ForeColor = Color.Blue;
                button40.Enabled = false;
            }
            if (button41.BackColor == Color.Orange)
            {
                button41.BackColor = Color.Red;
                button41.ForeColor = Color.Blue;
                button41.Enabled = false;
            }
            if (button42.BackColor == Color.Orange)
            {
                button42.BackColor = Color.Red;
                button42.ForeColor = Color.Blue;
                button42.Enabled = false;
            }
        }
        }
    }