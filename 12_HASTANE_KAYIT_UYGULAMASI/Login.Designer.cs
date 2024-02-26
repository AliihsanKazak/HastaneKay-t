
namespace _12_HASTANE_KAYIT_UYGULAMASI
{
    partial class Login
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
            this.btn_kayitol = new System.Windows.Forms.Button();
            this.btn_gir = new System.Windows.Forms.Button();
            this.txt_sfr = new System.Windows.Forms.TextBox();
            this.txt_ka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_kayitol
            // 
            this.btn_kayitol.Location = new System.Drawing.Point(387, 157);
            this.btn_kayitol.Name = "btn_kayitol";
            this.btn_kayitol.Size = new System.Drawing.Size(100, 23);
            this.btn_kayitol.TabIndex = 11;
            this.btn_kayitol.Text = "Kayıt Ol";
            this.btn_kayitol.UseVisualStyleBackColor = true;
            this.btn_kayitol.Click += new System.EventHandler(this.btn_kayitol_Click);
            // 
            // btn_gir
            // 
            this.btn_gir.Location = new System.Drawing.Point(281, 157);
            this.btn_gir.Name = "btn_gir";
            this.btn_gir.Size = new System.Drawing.Size(100, 23);
            this.btn_gir.TabIndex = 10;
            this.btn_gir.Text = "Giriş";
            this.btn_gir.UseVisualStyleBackColor = true;
            this.btn_gir.Click += new System.EventHandler(this.btn_gir_Click);
            // 
            // txt_sfr
            // 
            this.txt_sfr.Location = new System.Drawing.Point(318, 113);
            this.txt_sfr.Name = "txt_sfr";
            this.txt_sfr.Size = new System.Drawing.Size(100, 20);
            this.txt_sfr.TabIndex = 9;
            // 
            // txt_ka
            // 
            this.txt_ka.Location = new System.Drawing.Point(318, 82);
            this.txt_ka.Name = "txt_ka";
            this.txt_ka.Size = new System.Drawing.Size(100, 20);
            this.txt_ka.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_kayitol);
            this.Controls.Add(this.btn_gir);
            this.Controls.Add(this.txt_sfr);
            this.Controls.Add(this.txt_ka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_kayitol;
        private System.Windows.Forms.Button btn_gir;
        private System.Windows.Forms.TextBox txt_sfr;
        private System.Windows.Forms.TextBox txt_ka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}