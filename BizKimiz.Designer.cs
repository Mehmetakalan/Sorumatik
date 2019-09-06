namespace Sorumatik_Projesi
{
    partial class BizKimiz
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
            this.pb_salim = new System.Windows.Forms.PictureBox();
            this.pb_kartvizit = new System.Windows.Forms.PictureBox();
            this.pb_mehmet = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pb_geri = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_salim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_kartvizit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_mehmet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_geri)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_salim
            // 
            this.pb_salim.Image = global::Sorumatik_Projesi.Properties.Resources.Salim_fw;
            this.pb_salim.Location = new System.Drawing.Point(887, 26);
            this.pb_salim.Name = "pb_salim";
            this.pb_salim.Size = new System.Drawing.Size(184, 427);
            this.pb_salim.TabIndex = 2;
            this.pb_salim.TabStop = false;
            this.pb_salim.MouseLeave += new System.EventHandler(this.pb_salim_MouseLeave);
            this.pb_salim.MouseHover += new System.EventHandler(this.pb_salim_MouseHover);
            // 
            // pb_kartvizit
            // 
            this.pb_kartvizit.Image = global::Sorumatik_Projesi.Properties.Resources.MehmetArka;
            this.pb_kartvizit.Location = new System.Drawing.Point(334, 155);
            this.pb_kartvizit.Name = "pb_kartvizit";
            this.pb_kartvizit.Size = new System.Drawing.Size(440, 233);
            this.pb_kartvizit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_kartvizit.TabIndex = 1;
            this.pb_kartvizit.TabStop = false;
            // 
            // pb_mehmet
            // 
            this.pb_mehmet.Image = global::Sorumatik_Projesi.Properties.Resources.Mehmet_fw;
            this.pb_mehmet.Location = new System.Drawing.Point(23, 26);
            this.pb_mehmet.Name = "pb_mehmet";
            this.pb_mehmet.Size = new System.Drawing.Size(153, 431);
            this.pb_mehmet.TabIndex = 0;
            this.pb_mehmet.TabStop = false;
            this.pb_mehmet.MouseLeave += new System.EventHandler(this.pb_mehmet_MouseLeave);
            this.pb_mehmet.MouseHover += new System.EventHandler(this.pb_mehmet_MouseHover);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Sorumatik_Projesi.Properties.Resources.UstBaslikSorumati;
            this.pictureBox4.Location = new System.Drawing.Point(276, 26);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(561, 108);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pb_geri
            // 
            this.pb_geri.Image = global::Sorumatik_Projesi.Properties.Resources.GeriButon1;
            this.pb_geri.Location = new System.Drawing.Point(205, 369);
            this.pb_geri.Name = "pb_geri";
            this.pb_geri.Size = new System.Drawing.Size(108, 84);
            this.pb_geri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_geri.TabIndex = 4;
            this.pb_geri.TabStop = false;
            this.pb_geri.Click += new System.EventHandler(this.pb_geri_Click);
            // 
            // BizKimiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 471);
            this.Controls.Add(this.pb_geri);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pb_salim);
            this.Controls.Add(this.pb_kartvizit);
            this.Controls.Add(this.pb_mehmet);
            this.Name = "BizKimiz";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BizKimiz_FormClosing);
            this.Load += new System.EventHandler(this.BizKimiz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_salim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_kartvizit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_mehmet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_geri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_mehmet;
        private System.Windows.Forms.PictureBox pb_kartvizit;
        private System.Windows.Forms.PictureBox pb_salim;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pb_geri;
    }
}