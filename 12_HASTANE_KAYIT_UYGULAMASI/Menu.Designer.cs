
namespace _12_HASTANE_KAYIT_UYGULAMASI
{
    partial class Menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_randevu_olustur = new System.Windows.Forms.Button();
            this.btn_kullanici_bilgileri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(435, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU SAYFASIDIR";
            // 
            // btn_randevu_olustur
            // 
            this.btn_randevu_olustur.Location = new System.Drawing.Point(283, 96);
            this.btn_randevu_olustur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_randevu_olustur.Name = "btn_randevu_olustur";
            this.btn_randevu_olustur.Size = new System.Drawing.Size(436, 97);
            this.btn_randevu_olustur.TabIndex = 1;
            this.btn_randevu_olustur.Text = "Randevu Oluştur";
            this.btn_randevu_olustur.UseVisualStyleBackColor = true;
            this.btn_randevu_olustur.Click += new System.EventHandler(this.btn_randevu_olustur_Click);
            // 
            // btn_kullanici_bilgileri
            // 
            this.btn_kullanici_bilgileri.Location = new System.Drawing.Point(283, 220);
            this.btn_kullanici_bilgileri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_kullanici_bilgileri.Name = "btn_kullanici_bilgileri";
            this.btn_kullanici_bilgileri.Size = new System.Drawing.Size(436, 97);
            this.btn_kullanici_bilgileri.TabIndex = 2;
            this.btn_kullanici_bilgileri.Text = "Kullanıcı Bilgileri";
            this.btn_kullanici_bilgileri.UseVisualStyleBackColor = true;
            this.btn_kullanici_bilgileri.Click += new System.EventHandler(this.btn_kullanici_bilgileri_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 554);
            this.Controls.Add(this.btn_kullanici_bilgileri);
            this.Controls.Add(this.btn_randevu_olustur);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_randevu_olustur;
        private System.Windows.Forms.Button btn_kullanici_bilgileri;
    }
}