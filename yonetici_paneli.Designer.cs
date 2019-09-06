namespace Sorumatik_Projesi
{
    partial class yonetici_paneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yonetici_paneli));
            this.txt_gid = new System.Windows.Forms.TextBox();
            this.txt_gsif = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pb_geri = new System.Windows.Forms.PictureBox();
            this.pb_giris = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_geri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_giris)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_gid
            // 
            this.txt_gid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_gid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gid.Location = new System.Drawing.Point(421, 467);
            this.txt_gid.Name = "txt_gid";
            this.txt_gid.Size = new System.Drawing.Size(209, 19);
            this.txt_gid.TabIndex = 13;
            // 
            // txt_gsif
            // 
            this.txt_gsif.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_gsif.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_gsif.Location = new System.Drawing.Point(419, 524);
            this.txt_gsif.Name = "txt_gsif";
            this.txt_gsif.PasswordChar = '*';
            this.txt_gsif.Size = new System.Drawing.Size(209, 22);
            this.txt_gsif.TabIndex = 15;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Sorumatik_Projesi.Properties.Resources.YöneticiPaneliBilgi_fw;
            this.pictureBox5.Location = new System.Drawing.Point(-148, 325);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(1137, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 17;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Sorumatik_Projesi.Properties.Resources.YöneticiPaneliBanner;
            this.pictureBox4.Location = new System.Drawing.Point(5, 33);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(951, 288);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // pb_geri
            // 
            this.pb_geri.Image = global::Sorumatik_Projesi.Properties.Resources.GeriButon;
            this.pb_geri.Location = new System.Drawing.Point(23, 616);
            this.pb_geri.Name = "pb_geri";
            this.pb_geri.Size = new System.Drawing.Size(66, 50);
            this.pb_geri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_geri.TabIndex = 14;
            this.pb_geri.TabStop = false;
            this.pb_geri.Click += new System.EventHandler(this.pb_geri_Click);
            // 
            // pb_giris
            // 
            this.pb_giris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(77)))), ((int)(((byte)(91)))));
            this.pb_giris.Image = global::Sorumatik_Projesi.Properties.Resources.GirisButon_fw;
            this.pb_giris.Location = new System.Drawing.Point(534, 587);
            this.pb_giris.Name = "pb_giris";
            this.pb_giris.Size = new System.Drawing.Size(96, 29);
            this.pb_giris.TabIndex = 12;
            this.pb_giris.TabStop = false;
            this.pb_giris.Click += new System.EventHandler(this.pb_giris_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sorumatik_Projesi.Properties.Resources.GirisFormHosgeldinn_fw;
            this.pictureBox1.Location = new System.Drawing.Point(297, 381);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(393, 272);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // yonetici_paneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 694);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.txt_gsif);
            this.Controls.Add(this.pb_geri);
            this.Controls.Add(this.txt_gid);
            this.Controls.Add(this.pb_giris);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "yonetici_paneli";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.yonetici_paneli_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_geri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_giris)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pb_giris;
        private System.Windows.Forms.TextBox txt_gid;
        private System.Windows.Forms.PictureBox pb_geri;
        private System.Windows.Forms.TextBox txt_gsif;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}