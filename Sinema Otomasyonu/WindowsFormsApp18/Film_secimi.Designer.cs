namespace WindowsFormsApp18
{
    partial class Film_Secimi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Film_Secimi));
            this.film_ismi = new System.Windows.Forms.Label();
            this.kullaniciadi = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.saga_git = new System.Windows.Forms.Button();
            this.sola_git = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // film_ismi
            // 
            this.film_ismi.AutoSize = true;
            this.film_ismi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.film_ismi.Location = new System.Drawing.Point(187, 37);
            this.film_ismi.Name = "film_ismi";
            this.film_ismi.Size = new System.Drawing.Size(91, 18);
            this.film_ismi.TabIndex = 0;
            this.film_ismi.Text = "FİLM_İSİMİ";
            this.film_ismi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.film_ismi.Click += new System.EventHandler(this.film_ismi_Click);
            // 
            // kullaniciadi
            // 
            this.kullaniciadi.AutoSize = true;
            this.kullaniciadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciadi.Location = new System.Drawing.Point(679, 9);
            this.kullaniciadi.Name = "kullaniciadi";
            this.kullaniciadi.Size = new System.Drawing.Size(109, 18);
            this.kullaniciadi.TabIndex = 1;
            this.kullaniciadi.Text = "kullanici_ismi";
            this.kullaniciadi.Click += new System.EventHandler(this.kullaniciadi_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(49, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.White;
            this.ımageList1.Images.SetKeyName(0, "Lord Of The Rings.jpg");
            this.ımageList1.Images.SetKeyName(1, "Pirates of the Caribbean.jpg");
            this.ımageList1.Images.SetKeyName(2, "The_Hobbit.jpg");
            this.ımageList1.Images.SetKeyName(3, "The Avatar.jpg");
            // 
            // saga_git
            // 
            this.saga_git.Location = new System.Drawing.Point(349, 198);
            this.saga_git.Name = "saga_git";
            this.saga_git.Size = new System.Drawing.Size(28, 23);
            this.saga_git.TabIndex = 5;
            this.saga_git.Text = "˃˃";
            this.saga_git.UseVisualStyleBackColor = true;
            this.saga_git.Click += new System.EventHandler(this.saga_git_Click);
            // 
            // sola_git
            // 
            this.sola_git.Location = new System.Drawing.Point(15, 198);
            this.sola_git.Name = "sola_git";
            this.sola_git.Size = new System.Drawing.Size(28, 23);
            this.sola_git.TabIndex = 6;
            this.sola_git.Text = "<<";
            this.sola_git.UseVisualStyleBackColor = true;
            this.sola_git.Click += new System.EventHandler(this.sola_git_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Black;
            this.richTextBox1.Location = new System.Drawing.Point(402, 78);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(303, 256);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "13:00-15:30",
            "17:30-20:00",
            "20:30-23:00"});
            this.comboBox1.Location = new System.Drawing.Point(165, 356);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(149, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Seans Saatleri :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(190, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Bilet Al";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(520, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(520, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(529, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "label4";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 387);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Geri Gel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Film_Secimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 422);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.sola_git);
            this.Controls.Add(this.saga_git);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.kullaniciadi);
            this.Controls.Add(this.film_ismi);
            this.Name = "Film_Secimi";
            this.Text = "Film Seçimi";
            this.Load += new System.EventHandler(this.Film_secimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label film_ismi;
        private System.Windows.Forms.Label kullaniciadi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button saga_git;
        private System.Windows.Forms.Button sola_git;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
    }
}