namespace OtelRezervasyonSistemi
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pnlSol = new System.Windows.Forms.Panel();
            this.lblHosgeldiniz = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlSag = new System.Windows.Forms.Panel();
            this.pnlGiris = new System.Windows.Forms.Panel();
            this.lnkSifremiUnuttum = new System.Windows.Forms.LinkLabel();
            this.btnGiris = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblGirisBaslik = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.pnlSol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlSag.SuspendLayout();
            this.pnlGiris.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSol
            // 
            this.pnlSol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.pnlSol.Controls.Add(this.lblHosgeldiniz);
            this.pnlSol.Controls.Add(this.picLogo);
            this.pnlSol.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSol.Location = new System.Drawing.Point(0, 0);
            this.pnlSol.Name = "pnlSol";
            this.pnlSol.Size = new System.Drawing.Size(442, 660);
            this.pnlSol.TabIndex = 0;
            // 
            // lblHosgeldiniz
            // 
            this.lblHosgeldiniz.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHosgeldiniz.ForeColor = System.Drawing.Color.White;
            this.lblHosgeldiniz.Location = new System.Drawing.Point(45, 325);
            this.lblHosgeldiniz.Name = "lblHosgeldiniz";
            this.lblHosgeldiniz.Size = new System.Drawing.Size(343, 183);
            this.lblHosgeldiniz.TabIndex = 1;
            this.lblHosgeldiniz.Text = "      KUMANLI OTEL                                         HOŞGELDİNİZ";
            this.lblHosgeldiniz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(81, 38);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(285, 263);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // pnlSag
            // 
            this.pnlSag.BackColor = System.Drawing.Color.White;
            this.pnlSag.Controls.Add(this.pnlGiris);
            this.pnlSag.Controls.Add(this.btnCikis);
            this.pnlSag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSag.Location = new System.Drawing.Point(442, 0);
            this.pnlSag.Name = "pnlSag";
            this.pnlSag.Size = new System.Drawing.Size(618, 660);
            this.pnlSag.TabIndex = 1;
            this.pnlSag.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSag_Paint);
            // 
            // pnlGiris
            // 
            this.pnlGiris.Controls.Add(this.lnkSifremiUnuttum);
            this.pnlGiris.Controls.Add(this.btnGiris);
            this.pnlGiris.Controls.Add(this.txtSifre);
            this.pnlGiris.Controls.Add(this.lblSifre);
            this.pnlGiris.Controls.Add(this.txtKullaniciAdi);
            this.pnlGiris.Controls.Add(this.lblKullaniciAdi);
            this.pnlGiris.Controls.Add(this.lblGirisBaslik);
            this.pnlGiris.Location = new System.Drawing.Point(142, 68);
            this.pnlGiris.Name = "pnlGiris";
            this.pnlGiris.Size = new System.Drawing.Size(348, 440);
            this.pnlGiris.TabIndex = 1;
            // 
            // lnkSifremiUnuttum
            // 
            this.lnkSifremiUnuttum.AutoSize = true;
            this.lnkSifremiUnuttum.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lnkSifremiUnuttum.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.lnkSifremiUnuttum.Location = new System.Drawing.Point(129, 321);
            this.lnkSifremiUnuttum.Name = "lnkSifremiUnuttum";
            this.lnkSifremiUnuttum.Size = new System.Drawing.Size(101, 17);
            this.lnkSifremiUnuttum.TabIndex = 7;
            this.lnkSifremiUnuttum.TabStop = true;
            this.lnkSifremiUnuttum.Text = "Şifremi Unuttum";
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btnGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiris.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.ForeColor = System.Drawing.Color.White;
            this.btnGiris.Location = new System.Drawing.Point(48, 257);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(250, 40);
            this.btnGiris.TabIndex = 6;
            this.btnGiris.Text = "GİRİŞ YAP";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click_1);
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.White;
            this.txtSifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSifre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(48, 193);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(250, 29);
            this.txtSifre.TabIndex = 5;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.lblSifre.Location = new System.Drawing.Point(44, 160);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(49, 21);
            this.lblSifre.TabIndex = 4;
            this.lblSifre.Text = "Şifre :";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.BackColor = System.Drawing.Color.White;
            this.txtKullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdi.Location = new System.Drawing.Point(48, 104);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(250, 29);
            this.txtKullaniciAdi.TabIndex = 3;
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.lblKullaniciAdi.Location = new System.Drawing.Point(44, 80);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(102, 21);
            this.lblKullaniciAdi.TabIndex = 2;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı :";
            // 
            // lblGirisBaslik
            // 
            this.lblGirisBaslik.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGirisBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.lblGirisBaslik.Location = new System.Drawing.Point(20, 19);
            this.lblGirisBaslik.Name = "lblGirisBaslik";
            this.lblGirisBaslik.Size = new System.Drawing.Size(300, 50);
            this.lblGirisBaslik.TabIndex = 1;
            this.lblGirisBaslik.Text = "KULLANICI GİRİŞİ";
            this.lblGirisBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCikis
            // 
            this.btnCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btnCikis.Location = new System.Drawing.Point(578, 0);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(40, 40);
            this.btnCikis.TabIndex = 0;
            this.btnCikis.Text = "X";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click_1);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1060, 660);
            this.Controls.Add(this.pnlSag);
            this.Controls.Add(this.pnlSol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Otel Yönetim Sistemi";
            this.pnlSol.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlSag.ResumeLayout(false);
            this.pnlGiris.ResumeLayout(false);
            this.pnlGiris.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlSag;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Panel pnlGiris;
        private System.Windows.Forms.Panel pnlSol;
        private System.Windows.Forms.Label lblGirisBaslik;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.LinkLabel lnkSifremiUnuttum;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label lblHosgeldiniz;
        private System.Windows.Forms.PictureBox picLogo;
    }
}