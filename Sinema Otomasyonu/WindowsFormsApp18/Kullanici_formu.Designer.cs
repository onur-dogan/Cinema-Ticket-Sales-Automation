namespace WindowsFormsApp18
{
    partial class kullanici_formu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label6 = new System.Windows.Forms.Label();
            this.kullanici_adi = new System.Windows.Forms.TextBox();
            this.kullanici_sifre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(37, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "SİTEMİZE HOŞGELDİNİZ";
            // 
            // kullanici_adi
            // 
            this.kullanici_adi.Location = new System.Drawing.Point(89, 55);
            this.kullanici_adi.Name = "kullanici_adi";
            this.kullanici_adi.Size = new System.Drawing.Size(100, 20);
            this.kullanici_adi.TabIndex = 1;
            // 
            // kullanici_sifre
            // 
            this.kullanici_sifre.Location = new System.Drawing.Point(89, 90);
            this.kullanici_sifre.Name = "kullanici_sifre";
            this.kullanici_sifre.PasswordChar = '*';
            this.kullanici_sifre.Size = new System.Drawing.Size(100, 20);
            this.kullanici_sifre.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Kullanıcı Adı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Şifre";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Giriş";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(98, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Şifremi Unuttum";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(101, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Üye Ol";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // kullanici_formu
            // 
            this.AcceptButton = this.button1;
            this.ClientSize = new System.Drawing.Size(297, 288);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.kullanici_sifre);
            this.Controls.Add(this.kullanici_adi);
            this.Controls.Add(this.label6);
            this.Name = "kullanici_formu";
            this.Text = "Kullanıcı Formu";
            this.Load += new System.EventHandler(this.kullanici_formu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox kullanici_adi;
        private System.Windows.Forms.TextBox kullanici_sifre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}