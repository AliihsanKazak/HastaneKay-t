namespace _12_HASTANE_KAYIT_UYGULAMASI
{
    partial class Randevu_Ekrani
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
            this.txt_hasta_ara_tc = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tablo_hastalar = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_tumhastalar = new System.Windows.Forms.Button();
            this.btn_hasta_ara = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_sikayet = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_doktor = new System.Windows.Forms.ComboBox();
            this.cmb_sehir = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_klinik = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_randevu_TC = new System.Windows.Forms.MaskedTextBox();
            this.btn_randevu_olustur = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.txt_soyisim = new System.Windows.Forms.TextBox();
            this.dt_randevu_tarihi = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.tbl_randevular = new System.Windows.Forms.DataGridView();
            this.txt_randevuID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablo_hastalar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_randevular)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_hasta_ara_tc
            // 
            this.txt_hasta_ara_tc.Location = new System.Drawing.Point(267, 19);
            this.txt_hasta_ara_tc.Mask = "99999999999";
            this.txt_hasta_ara_tc.Name = "txt_hasta_ara_tc";
            this.txt_hasta_ara_tc.Size = new System.Drawing.Size(75, 20);
            this.txt_hasta_ara_tc.TabIndex = 0;
            this.txt_hasta_ara_tc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "TC";
            // 
            // tablo_hastalar
            // 
            this.tablo_hastalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablo_hastalar.Location = new System.Drawing.Point(45, 89);
            this.tablo_hastalar.Name = "tablo_hastalar";
            this.tablo_hastalar.Size = new System.Drawing.Size(536, 266);
            this.tablo_hastalar.TabIndex = 2;
            this.tablo_hastalar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablo_randevular_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_tumhastalar);
            this.groupBox1.Controls.Add(this.btn_hasta_ara);
            this.groupBox1.Controls.Add(this.tablo_hastalar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_hasta_ara_tc);
            this.groupBox1.Location = new System.Drawing.Point(764, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(615, 387);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HASTA BİLGİ EKRANI";
            // 
            // btn_tumhastalar
            // 
            this.btn_tumhastalar.Location = new System.Drawing.Point(429, 19);
            this.btn_tumhastalar.Name = "btn_tumhastalar";
            this.btn_tumhastalar.Size = new System.Drawing.Size(131, 23);
            this.btn_tumhastalar.TabIndex = 4;
            this.btn_tumhastalar.Text = "TÜM HASTALAR";
            this.btn_tumhastalar.UseVisualStyleBackColor = true;
            this.btn_tumhastalar.Click += new System.EventHandler(this.btn_tumhastalar_Click);
            // 
            // btn_hasta_ara
            // 
            this.btn_hasta_ara.Location = new System.Drawing.Point(348, 19);
            this.btn_hasta_ara.Name = "btn_hasta_ara";
            this.btn_hasta_ara.Size = new System.Drawing.Size(75, 23);
            this.btn_hasta_ara.TabIndex = 3;
            this.btn_hasta_ara.Text = "ARA";
            this.btn_hasta_ara.UseVisualStyleBackColor = true;
            this.btn_hasta_ara.Click += new System.EventHandler(this.btn_hasta_ara_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şikayet";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_sikayet
            // 
            this.txt_sikayet.Location = new System.Drawing.Point(179, 332);
            this.txt_sikayet.Name = "txt_sikayet";
            this.txt_sikayet.Size = new System.Drawing.Size(178, 96);
            this.txt_sikayet.TabIndex = 5;
            this.txt_sikayet.Text = "";
            this.txt_sikayet.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Doktor";
            // 
            // cmb_doktor
            // 
            this.cmb_doktor.FormattingEnabled = true;
            this.cmb_doktor.Location = new System.Drawing.Point(187, 209);
            this.cmb_doktor.Name = "cmb_doktor";
            this.cmb_doktor.Size = new System.Drawing.Size(144, 21);
            this.cmb_doktor.TabIndex = 7;
            // 
            // cmb_sehir
            // 
            this.cmb_sehir.FormattingEnabled = true;
            this.cmb_sehir.Location = new System.Drawing.Point(187, 171);
            this.cmb_sehir.Name = "cmb_sehir";
            this.cmb_sehir.Size = new System.Drawing.Size(144, 21);
            this.cmb_sehir.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "şehir";
            // 
            // cmb_klinik
            // 
            this.cmb_klinik.FormattingEnabled = true;
            this.cmb_klinik.Location = new System.Drawing.Point(187, 135);
            this.cmb_klinik.Name = "cmb_klinik";
            this.cmb_klinik.Size = new System.Drawing.Size(144, 21);
            this.cmb_klinik.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Klinik";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "TC";
            // 
            // txt_randevu_TC
            // 
            this.txt_randevu_TC.Location = new System.Drawing.Point(187, 26);
            this.txt_randevu_TC.Mask = "99999999999";
            this.txt_randevu_TC.Name = "txt_randevu_TC";
            this.txt_randevu_TC.Size = new System.Drawing.Size(144, 20);
            this.txt_randevu_TC.TabIndex = 13;
            this.txt_randevu_TC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_randevu_olustur
            // 
            this.btn_randevu_olustur.Location = new System.Drawing.Point(82, 459);
            this.btn_randevu_olustur.Name = "btn_randevu_olustur";
            this.btn_randevu_olustur.Size = new System.Drawing.Size(144, 42);
            this.btn_randevu_olustur.TabIndex = 14;
            this.btn_randevu_olustur.Text = "Randevu Oluştur";
            this.btn_randevu_olustur.UseVisualStyleBackColor = true;
            this.btn_randevu_olustur.Click += new System.EventHandler(this.btn_randevu_olustur_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(128, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "İsim";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(108, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Soy isim";
            // 
            // txt_isim
            // 
            this.txt_isim.Location = new System.Drawing.Point(187, 64);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(144, 20);
            this.txt_isim.TabIndex = 17;
            // 
            // txt_soyisim
            // 
            this.txt_soyisim.Location = new System.Drawing.Point(187, 98);
            this.txt_soyisim.Name = "txt_soyisim";
            this.txt_soyisim.Size = new System.Drawing.Size(144, 20);
            this.txt_soyisim.TabIndex = 18;
            // 
            // dt_randevu_tarihi
            // 
            this.dt_randevu_tarihi.Location = new System.Drawing.Point(187, 271);
            this.dt_randevu_tarihi.Name = "dt_randevu_tarihi";
            this.dt_randevu_tarihi.Size = new System.Drawing.Size(170, 20);
            this.dt_randevu_tarihi.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(79, 271);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Randevu Tarihi";
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(232, 459);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(144, 42);
            this.btn_guncelle.TabIndex = 21;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(208, 524);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "ID";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(276, 521);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(100, 20);
            this.txt_ID.TabIndex = 23;
            // 
            // tbl_randevular
            // 
            this.tbl_randevular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_randevular.Location = new System.Drawing.Point(764, 487);
            this.tbl_randevular.Name = "tbl_randevular";
            this.tbl_randevular.Size = new System.Drawing.Size(676, 266);
            this.tbl_randevular.TabIndex = 24;
            this.tbl_randevular.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbl_randevular_CellClick);
            // 
            // txt_randevuID
            // 
            this.txt_randevuID.Location = new System.Drawing.Point(276, 547);
            this.txt_randevuID.Name = "txt_randevuID";
            this.txt_randevuID.Size = new System.Drawing.Size(100, 20);
            this.txt_randevuID.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(208, 550);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "RandevuID";
            // 
            // Randevu_Ekrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1488, 792);
            this.Controls.Add(this.txt_randevuID);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbl_randevular);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dt_randevu_tarihi);
            this.Controls.Add(this.txt_soyisim);
            this.Controls.Add(this.txt_isim);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_randevu_olustur);
            this.Controls.Add(this.txt_randevu_TC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_klinik);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_sehir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_doktor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_sikayet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Randevu_Ekrani";
            this.Text = "Randevu_Ekrani";
            this.Load += new System.EventHandler(this.Randevu_Ekrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablo_hastalar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_randevular)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txt_hasta_ara_tc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tablo_hastalar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_tumhastalar;
        private System.Windows.Forms.Button btn_hasta_ara;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txt_sikayet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_doktor;
        private System.Windows.Forms.ComboBox cmb_sehir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_klinik;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txt_randevu_TC;
        private System.Windows.Forms.Button btn_randevu_olustur;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.TextBox txt_soyisim;
        private System.Windows.Forms.DateTimePicker dt_randevu_tarihi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.DataGridView tbl_randevular;
        private System.Windows.Forms.TextBox txt_randevuID;
        private System.Windows.Forms.Label label11;
    }
}