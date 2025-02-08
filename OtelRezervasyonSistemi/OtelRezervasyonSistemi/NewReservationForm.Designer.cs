namespace OtelRezervasyonSistemi
{
    partial class NewReservationForm
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
            this.grpMusteriBilgileri = new System.Windows.Forms.GroupBox();
            this.txtMusteriTC = new System.Windows.Forms.TextBox();
            this.lblMusteriTC = new System.Windows.Forms.Label();
            this.lblMusteriSoyad = new System.Windows.Forms.Label();
            this.txtMusteriSoyad = new System.Windows.Forms.TextBox();
            this.txtMusteriTelefon = new System.Windows.Forms.TextBox();
            this.lblMusteriTelefon = new System.Windows.Forms.Label();
            this.lblMusteriAd = new System.Windows.Forms.Label();
            this.txtMusteriAd = new System.Windows.Forms.TextBox();
            this.cmbMusteriler = new System.Windows.Forms.ComboBox();
            this.btnYeniMusteri = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.grpRezervasyonBilgileri = new System.Windows.Forms.GroupBox();
            this.cmbOdalar = new System.Windows.Forms.ComboBox();
            this.dtpCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblTutarDeger = new System.Windows.Forms.Label();
            this.lblGunDeger = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.lblGunSayisi = new System.Windows.Forms.Label();
            this.lnlOdaSecim = new System.Windows.Forms.Label();
            this.lblCikisTarihi = new System.Windows.Forms.Label();
            this.lblGirisTarihi = new System.Windows.Forms.Label();
            this.pnlAyrac = new System.Windows.Forms.Panel();
            this.lblNot = new System.Windows.Forms.Label();
            this.txtNot = new System.Windows.Forms.TextBox();
            this.grpMusteriBilgileri.SuspendLayout();
            this.grpRezervasyonBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMusteriBilgileri
            // 
            this.grpMusteriBilgileri.Controls.Add(this.txtMusteriTC);
            this.grpMusteriBilgileri.Controls.Add(this.lblMusteriTC);
            this.grpMusteriBilgileri.Controls.Add(this.lblMusteriSoyad);
            this.grpMusteriBilgileri.Controls.Add(this.txtMusteriSoyad);
            this.grpMusteriBilgileri.Controls.Add(this.txtMusteriTelefon);
            this.grpMusteriBilgileri.Controls.Add(this.lblMusteriTelefon);
            this.grpMusteriBilgileri.Controls.Add(this.lblMusteriAd);
            this.grpMusteriBilgileri.Controls.Add(this.txtMusteriAd);
            this.grpMusteriBilgileri.Controls.Add(this.cmbMusteriler);
            this.grpMusteriBilgileri.Controls.Add(this.btnYeniMusteri);
            this.grpMusteriBilgileri.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpMusteriBilgileri.Location = new System.Drawing.Point(30, 30);
            this.grpMusteriBilgileri.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpMusteriBilgileri.Name = "grpMusteriBilgileri";
            this.grpMusteriBilgileri.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpMusteriBilgileri.Size = new System.Drawing.Size(480, 280);
            this.grpMusteriBilgileri.TabIndex = 0;
            this.grpMusteriBilgileri.TabStop = false;
            this.grpMusteriBilgileri.Text = "Müşteri Bilgileri";
            // 
            // txtMusteriTC
            // 
            this.txtMusteriTC.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMusteriTC.Location = new System.Drawing.Point(150, 210);
            this.txtMusteriTC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMusteriTC.Name = "txtMusteriTC";
            this.txtMusteriTC.ReadOnly = true;
            this.txtMusteriTC.Size = new System.Drawing.Size(300, 27);
            this.txtMusteriTC.TabIndex = 9;
            // 
            // lblMusteriTC
            // 
            this.lblMusteriTC.AutoSize = true;
            this.lblMusteriTC.ForeColor = System.Drawing.Color.Black;
            this.lblMusteriTC.Location = new System.Drawing.Point(30, 210);
            this.lblMusteriTC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMusteriTC.Name = "lblMusteriTC";
            this.lblMusteriTC.Size = new System.Drawing.Size(56, 20);
            this.lblMusteriTC.TabIndex = 8;
            this.lblMusteriTC.Text = "TC No :";
            // 
            // lblMusteriSoyad
            // 
            this.lblMusteriSoyad.AutoSize = true;
            this.lblMusteriSoyad.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteriSoyad.ForeColor = System.Drawing.Color.Black;
            this.lblMusteriSoyad.Location = new System.Drawing.Point(30, 130);
            this.lblMusteriSoyad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMusteriSoyad.Name = "lblMusteriSoyad";
            this.lblMusteriSoyad.Size = new System.Drawing.Size(57, 20);
            this.lblMusteriSoyad.TabIndex = 7;
            this.lblMusteriSoyad.Text = "Soyad :";
            // 
            // txtMusteriSoyad
            // 
            this.txtMusteriSoyad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMusteriSoyad.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriSoyad.Location = new System.Drawing.Point(150, 130);
            this.txtMusteriSoyad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMusteriSoyad.Name = "txtMusteriSoyad";
            this.txtMusteriSoyad.ReadOnly = true;
            this.txtMusteriSoyad.Size = new System.Drawing.Size(300, 27);
            this.txtMusteriSoyad.TabIndex = 6;
            // 
            // txtMusteriTelefon
            // 
            this.txtMusteriTelefon.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMusteriTelefon.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriTelefon.Location = new System.Drawing.Point(150, 170);
            this.txtMusteriTelefon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMusteriTelefon.Name = "txtMusteriTelefon";
            this.txtMusteriTelefon.ReadOnly = true;
            this.txtMusteriTelefon.Size = new System.Drawing.Size(300, 27);
            this.txtMusteriTelefon.TabIndex = 5;
            // 
            // lblMusteriTelefon
            // 
            this.lblMusteriTelefon.AutoSize = true;
            this.lblMusteriTelefon.ForeColor = System.Drawing.Color.Black;
            this.lblMusteriTelefon.Location = new System.Drawing.Point(30, 170);
            this.lblMusteriTelefon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMusteriTelefon.Name = "lblMusteriTelefon";
            this.lblMusteriTelefon.Size = new System.Drawing.Size(69, 20);
            this.lblMusteriTelefon.TabIndex = 4;
            this.lblMusteriTelefon.Text = "Telefon : ";
            // 
            // lblMusteriAd
            // 
            this.lblMusteriAd.AutoSize = true;
            this.lblMusteriAd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteriAd.ForeColor = System.Drawing.Color.Black;
            this.lblMusteriAd.Location = new System.Drawing.Point(30, 90);
            this.lblMusteriAd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMusteriAd.Name = "lblMusteriAd";
            this.lblMusteriAd.Size = new System.Drawing.Size(35, 20);
            this.lblMusteriAd.TabIndex = 3;
            this.lblMusteriAd.Text = "Ad :";
            // 
            // txtMusteriAd
            // 
            this.txtMusteriAd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMusteriAd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriAd.Location = new System.Drawing.Point(150, 90);
            this.txtMusteriAd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMusteriAd.Name = "txtMusteriAd";
            this.txtMusteriAd.ReadOnly = true;
            this.txtMusteriAd.Size = new System.Drawing.Size(300, 27);
            this.txtMusteriAd.TabIndex = 2;
            // 
            // cmbMusteriler
            // 
            this.cmbMusteriler.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbMusteriler.FormattingEnabled = true;
            this.cmbMusteriler.Location = new System.Drawing.Point(30, 40);
            this.cmbMusteriler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbMusteriler.Name = "cmbMusteriler";
            this.cmbMusteriler.Size = new System.Drawing.Size(300, 28);
            this.cmbMusteriler.TabIndex = 1;
            this.cmbMusteriler.Text = "Müşteri Seçin";
            // 
            // btnYeniMusteri
            // 
            this.btnYeniMusteri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btnYeniMusteri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeniMusteri.Location = new System.Drawing.Point(350, 40);
            this.btnYeniMusteri.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnYeniMusteri.Name = "btnYeniMusteri";
            this.btnYeniMusteri.Size = new System.Drawing.Size(100, 30);
            this.btnYeniMusteri.TabIndex = 0;
            this.btnYeniMusteri.Text = "Yeni Müşteri";
            this.btnYeniMusteri.UseVisualStyleBackColor = false;
            this.btnYeniMusteri.Click += new System.EventHandler(this.btnYeniMusteri_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.Gray;
            this.btnIptal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIptal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.Location = new System.Drawing.Point(670, 580);
            this.btnIptal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(180, 40);
            this.btnIptal.TabIndex = 1;
            this.btnIptal.Text = "İPTAL";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(850, 580);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(180, 40);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // grpRezervasyonBilgileri
            // 
            this.grpRezervasyonBilgileri.Controls.Add(this.cmbOdalar);
            this.grpRezervasyonBilgileri.Controls.Add(this.dtpCikisTarihi);
            this.grpRezervasyonBilgileri.Controls.Add(this.dtpGirisTarihi);
            this.grpRezervasyonBilgileri.Controls.Add(this.lblTutarDeger);
            this.grpRezervasyonBilgileri.Controls.Add(this.lblGunDeger);
            this.grpRezervasyonBilgileri.Controls.Add(this.lblToplamTutar);
            this.grpRezervasyonBilgileri.Controls.Add(this.lblGunSayisi);
            this.grpRezervasyonBilgileri.Controls.Add(this.lnlOdaSecim);
            this.grpRezervasyonBilgileri.Controls.Add(this.lblCikisTarihi);
            this.grpRezervasyonBilgileri.Controls.Add(this.lblGirisTarihi);
            this.grpRezervasyonBilgileri.Location = new System.Drawing.Point(550, 30);
            this.grpRezervasyonBilgileri.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpRezervasyonBilgileri.Name = "grpRezervasyonBilgileri";
            this.grpRezervasyonBilgileri.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpRezervasyonBilgileri.Size = new System.Drawing.Size(480, 280);
            this.grpRezervasyonBilgileri.TabIndex = 3;
            this.grpRezervasyonBilgileri.TabStop = false;
            this.grpRezervasyonBilgileri.Text = "Rezervasyon Bilgileri";
            // 
            // cmbOdalar
            // 
            this.cmbOdalar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOdalar.FormattingEnabled = true;
            this.cmbOdalar.Location = new System.Drawing.Point(150, 140);
            this.cmbOdalar.Name = "cmbOdalar";
            this.cmbOdalar.Size = new System.Drawing.Size(300, 28);
            this.cmbOdalar.TabIndex = 9;
            this.cmbOdalar.SelectedIndexChanged += new System.EventHandler(this.cmbOdalar_SelectedIndexChanged);
            // 
            // dtpCikisTarihi
            // 
            this.dtpCikisTarihi.CustomFormat = "dd.MM.yyyy";
            this.dtpCikisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCikisTarihi.Location = new System.Drawing.Point(150, 90);
            this.dtpCikisTarihi.Name = "dtpCikisTarihi";
            this.dtpCikisTarihi.Size = new System.Drawing.Size(300, 27);
            this.dtpCikisTarihi.TabIndex = 8;
            this.dtpCikisTarihi.ValueChanged += new System.EventHandler(this.dtpCikisTarihi_ValueChanged);
            // 
            // dtpGirisTarihi
            // 
            this.dtpGirisTarihi.CustomFormat = "dd.MM.yyyy";
            this.dtpGirisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpGirisTarihi.Location = new System.Drawing.Point(150, 40);
            this.dtpGirisTarihi.Name = "dtpGirisTarihi";
            this.dtpGirisTarihi.Size = new System.Drawing.Size(300, 27);
            this.dtpGirisTarihi.TabIndex = 7;
            this.dtpGirisTarihi.ValueChanged += new System.EventHandler(this.dtpGirisTarihi_ValueChanged);
            // 
            // lblTutarDeger
            // 
            this.lblTutarDeger.AutoSize = true;
            this.lblTutarDeger.BackColor = System.Drawing.SystemColors.Window;
            this.lblTutarDeger.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTutarDeger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.lblTutarDeger.Location = new System.Drawing.Point(159, 230);
            this.lblTutarDeger.Name = "lblTutarDeger";
            this.lblTutarDeger.Size = new System.Drawing.Size(57, 20);
            this.lblTutarDeger.TabIndex = 6;
            this.lblTutarDeger.Text = "0.00TL";
            // 
            // lblGunDeger
            // 
            this.lblGunDeger.AutoSize = true;
            this.lblGunDeger.BackColor = System.Drawing.SystemColors.Window;
            this.lblGunDeger.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGunDeger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.lblGunDeger.Location = new System.Drawing.Point(159, 190);
            this.lblGunDeger.Name = "lblGunDeger";
            this.lblGunDeger.Size = new System.Drawing.Size(51, 20);
            this.lblGunDeger.TabIndex = 5;
            this.lblGunDeger.Text = "0 Gün";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.ForeColor = System.Drawing.Color.Black;
            this.lblToplamTutar.Location = new System.Drawing.Point(30, 230);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(104, 20);
            this.lblToplamTutar.TabIndex = 4;
            this.lblToplamTutar.Text = "Toplam Tutar :";
            // 
            // lblGunSayisi
            // 
            this.lblGunSayisi.AutoSize = true;
            this.lblGunSayisi.ForeColor = System.Drawing.Color.Black;
            this.lblGunSayisi.Location = new System.Drawing.Point(30, 190);
            this.lblGunSayisi.Name = "lblGunSayisi";
            this.lblGunSayisi.Size = new System.Drawing.Size(133, 20);
            this.lblGunSayisi.TabIndex = 3;
            this.lblGunSayisi.Text = "Konaklama Süresi :";
            // 
            // lnlOdaSecim
            // 
            this.lnlOdaSecim.AutoSize = true;
            this.lnlOdaSecim.ForeColor = System.Drawing.Color.Black;
            this.lnlOdaSecim.Location = new System.Drawing.Point(30, 140);
            this.lnlOdaSecim.Name = "lnlOdaSecim";
            this.lnlOdaSecim.Size = new System.Drawing.Size(48, 20);
            this.lnlOdaSecim.TabIndex = 2;
            this.lnlOdaSecim.Text = "Oda : ";
            // 
            // lblCikisTarihi
            // 
            this.lblCikisTarihi.AutoSize = true;
            this.lblCikisTarihi.ForeColor = System.Drawing.Color.Black;
            this.lblCikisTarihi.Location = new System.Drawing.Point(30, 90);
            this.lblCikisTarihi.Name = "lblCikisTarihi";
            this.lblCikisTarihi.Size = new System.Drawing.Size(85, 20);
            this.lblCikisTarihi.TabIndex = 1;
            this.lblCikisTarihi.Text = "Çıkış Tarihi :";
            // 
            // lblGirisTarihi
            // 
            this.lblGirisTarihi.AutoSize = true;
            this.lblGirisTarihi.ForeColor = System.Drawing.Color.Black;
            this.lblGirisTarihi.Location = new System.Drawing.Point(30, 40);
            this.lblGirisTarihi.Name = "lblGirisTarihi";
            this.lblGirisTarihi.Size = new System.Drawing.Size(80, 20);
            this.lblGirisTarihi.TabIndex = 0;
            this.lblGirisTarihi.Text = "Giriş Tarihi:";
            // 
            // pnlAyrac
            // 
            this.pnlAyrac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.pnlAyrac.ForeColor = System.Drawing.SystemColors.Window;
            this.pnlAyrac.Location = new System.Drawing.Point(30, 560);
            this.pnlAyrac.Name = "pnlAyrac";
            this.pnlAyrac.Size = new System.Drawing.Size(1000, 2);
            this.pnlAyrac.TabIndex = 4;
            // 
            // lblNot
            // 
            this.lblNot.AutoSize = true;
            this.lblNot.ForeColor = System.Drawing.Color.Black;
            this.lblNot.Location = new System.Drawing.Point(30, 330);
            this.lblNot.Name = "lblNot";
            this.lblNot.Size = new System.Drawing.Size(131, 20);
            this.lblNot.TabIndex = 5;
            this.lblNot.Text = "Rezervasyon Notu:";
            // 
            // txtNot
            // 
            this.txtNot.Location = new System.Drawing.Point(30, 360);
            this.txtNot.Multiline = true;
            this.txtNot.Name = "txtNot";
            this.txtNot.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNot.Size = new System.Drawing.Size(1000, 180);
            this.txtNot.TabIndex = 6;
            // 
            // NewReservationForm
            // 
            this.AcceptButton = this.btnKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.btnIptal;
            this.ClientSize = new System.Drawing.Size(1060, 660);
            this.Controls.Add(this.txtNot);
            this.Controls.Add(this.lblNot);
            this.Controls.Add(this.pnlAyrac);
            this.Controls.Add(this.grpRezervasyonBilgileri);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.grpMusteriBilgileri);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewReservationForm";
            this.Padding = new System.Windows.Forms.Padding(13, 15, 13, 15);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni  Rezervasyon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.grpMusteriBilgileri.ResumeLayout(false);
            this.grpMusteriBilgileri.PerformLayout();
            this.grpRezervasyonBilgileri.ResumeLayout(false);
            this.grpRezervasyonBilgileri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMusteriBilgileri;
        private System.Windows.Forms.ComboBox cmbMusteriler;
        private System.Windows.Forms.Button btnYeniMusteri;
        private System.Windows.Forms.Label lblMusteriAd;
        private System.Windows.Forms.TextBox txtMusteriAd;
        private System.Windows.Forms.Label lblMusteriSoyad;
        private System.Windows.Forms.TextBox txtMusteriSoyad;
        private System.Windows.Forms.TextBox txtMusteriTelefon;
        private System.Windows.Forms.Label lblMusteriTelefon;
        private System.Windows.Forms.TextBox txtMusteriTC;
        private System.Windows.Forms.Label lblMusteriTC;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.GroupBox grpRezervasyonBilgileri;
        private System.Windows.Forms.Label lblGunSayisi;
        private System.Windows.Forms.Label lnlOdaSecim;
        private System.Windows.Forms.Label lblCikisTarihi;
        private System.Windows.Forms.Label lblGirisTarihi;
        private System.Windows.Forms.Label lblTutarDeger;
        private System.Windows.Forms.Label lblGunDeger;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.DateTimePicker dtpGirisTarihi;
        private System.Windows.Forms.ComboBox cmbOdalar;
        private System.Windows.Forms.DateTimePicker dtpCikisTarihi;
        private System.Windows.Forms.Panel pnlAyrac;
        private System.Windows.Forms.Label lblNot;
        private System.Windows.Forms.TextBox txtNot;
    }
}