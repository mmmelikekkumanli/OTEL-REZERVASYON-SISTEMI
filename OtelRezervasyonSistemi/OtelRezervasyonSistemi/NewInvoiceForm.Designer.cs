namespace OtelRezervasyonSistemi
{
    partial class NewInvoiceForm
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
            this.grpFaturaBilgileri = new System.Windows.Forms.GroupBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            this.txtKDV = new System.Windows.Forms.TextBox();
            this.txtMusteriAdi = new System.Windows.Forms.TextBox();
            this.cmbRezervasyonlar = new System.Windows.Forms.ComboBox();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.lblKDV = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.lblMusteriAdi = new System.Windows.Forms.Label();
            this.lblRezervasyon = new System.Windows.Forms.Label();
            this.pnlAyrac = new System.Windows.Forms.Panel();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.grpFaturaBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFaturaBilgileri
            // 
            this.grpFaturaBilgileri.Controls.Add(this.txtTutar);
            this.grpFaturaBilgileri.Controls.Add(this.txtToplamTutar);
            this.grpFaturaBilgileri.Controls.Add(this.txtKDV);
            this.grpFaturaBilgileri.Controls.Add(this.txtMusteriAdi);
            this.grpFaturaBilgileri.Controls.Add(this.cmbRezervasyonlar);
            this.grpFaturaBilgileri.Controls.Add(this.lblToplamTutar);
            this.grpFaturaBilgileri.Controls.Add(this.lblKDV);
            this.grpFaturaBilgileri.Controls.Add(this.lblTutar);
            this.grpFaturaBilgileri.Controls.Add(this.lblMusteriAdi);
            this.grpFaturaBilgileri.Controls.Add(this.lblRezervasyon);
            this.grpFaturaBilgileri.Location = new System.Drawing.Point(30, 30);
            this.grpFaturaBilgileri.Name = "grpFaturaBilgileri";
            this.grpFaturaBilgileri.Size = new System.Drawing.Size(1000, 480);
            this.grpFaturaBilgileri.TabIndex = 0;
            this.grpFaturaBilgileri.TabStop = false;
            this.grpFaturaBilgileri.Text = "Fatura Bilgileri :";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(150, 130);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.ReadOnly = true;
            this.txtTutar.Size = new System.Drawing.Size(300, 27);
            this.txtTutar.TabIndex = 9;
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtToplamTutar.Location = new System.Drawing.Point(150, 210);
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.ReadOnly = true;
            this.txtToplamTutar.Size = new System.Drawing.Size(300, 29);
            this.txtToplamTutar.TabIndex = 8;
            // 
            // txtKDV
            // 
            this.txtKDV.Location = new System.Drawing.Point(150, 170);
            this.txtKDV.Name = "txtKDV";
            this.txtKDV.ReadOnly = true;
            this.txtKDV.Size = new System.Drawing.Size(300, 27);
            this.txtKDV.TabIndex = 7;
            // 
            // txtMusteriAdi
            // 
            this.txtMusteriAdi.Location = new System.Drawing.Point(150, 90);
            this.txtMusteriAdi.Name = "txtMusteriAdi";
            this.txtMusteriAdi.ReadOnly = true;
            this.txtMusteriAdi.Size = new System.Drawing.Size(300, 27);
            this.txtMusteriAdi.TabIndex = 6;
            // 
            // cmbRezervasyonlar
            // 
            this.cmbRezervasyonlar.FormattingEnabled = true;
            this.cmbRezervasyonlar.Location = new System.Drawing.Point(150, 50);
            this.cmbRezervasyonlar.Name = "cmbRezervasyonlar";
            this.cmbRezervasyonlar.Size = new System.Drawing.Size(300, 28);
            this.cmbRezervasyonlar.TabIndex = 5;
            this.cmbRezervasyonlar.TextChanged += new System.EventHandler(this.cmbRezervasyonlar_TextChanged);
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamTutar.Location = new System.Drawing.Point(30, 210);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(118, 21);
            this.lblToplamTutar.TabIndex = 4;
            this.lblToplamTutar.Text = "Toplam Tutar :";
            // 
            // lblKDV
            // 
            this.lblKDV.AutoSize = true;
            this.lblKDV.Location = new System.Drawing.Point(30, 170);
            this.lblKDV.Name = "lblKDV";
            this.lblKDV.Size = new System.Drawing.Size(83, 20);
            this.lblKDV.TabIndex = 3;
            this.lblKDV.Text = "KDV (%18):";
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(30, 130);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(50, 20);
            this.lblTutar.TabIndex = 2;
            this.lblTutar.Text = "Tutar :";
            // 
            // lblMusteriAdi
            // 
            this.lblMusteriAdi.AutoSize = true;
            this.lblMusteriAdi.Location = new System.Drawing.Point(30, 90);
            this.lblMusteriAdi.Name = "lblMusteriAdi";
            this.lblMusteriAdi.Size = new System.Drawing.Size(65, 20);
            this.lblMusteriAdi.TabIndex = 1;
            this.lblMusteriAdi.Text = "Müşteri :";
            // 
            // lblRezervasyon
            // 
            this.lblRezervasyon.AutoSize = true;
            this.lblRezervasyon.Location = new System.Drawing.Point(30, 50);
            this.lblRezervasyon.Name = "lblRezervasyon";
            this.lblRezervasyon.Size = new System.Drawing.Size(102, 20);
            this.lblRezervasyon.TabIndex = 0;
            this.lblRezervasyon.Text = "Rezervasyon : ";
            // 
            // pnlAyrac
            // 
            this.pnlAyrac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.pnlAyrac.Location = new System.Drawing.Point(30, 530);
            this.pnlAyrac.Name = "pnlAyrac";
            this.pnlAyrac.Size = new System.Drawing.Size(1000, 2);
            this.pnlAyrac.TabIndex = 1;
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.Gray;
            this.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIptal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.ForeColor = System.Drawing.Color.White;
            this.btnIptal.Location = new System.Drawing.Point(670, 550);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(180, 40);
            this.btnIptal.TabIndex = 2;
            this.btnIptal.Text = "IPTAL";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnOlustur
            // 
            this.btnOlustur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btnOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOlustur.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOlustur.ForeColor = System.Drawing.Color.White;
            this.btnOlustur.Location = new System.Drawing.Point(850, 550);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(180, 40);
            this.btnOlustur.TabIndex = 3;
            this.btnOlustur.Text = "FATURA OLUŞTUR";
            this.btnOlustur.UseVisualStyleBackColor = false;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // NewInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1060, 660);
            this.Controls.Add(this.btnOlustur);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.pnlAyrac);
            this.Controls.Add(this.grpFaturaBilgileri);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NewInvoiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewInvoiceForm";
            this.grpFaturaBilgileri.ResumeLayout(false);
            this.grpFaturaBilgileri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFaturaBilgileri;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Label lblKDV;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Label lblMusteriAdi;
        private System.Windows.Forms.Label lblRezervasyon;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.TextBox txtToplamTutar;
        private System.Windows.Forms.TextBox txtKDV;
        private System.Windows.Forms.TextBox txtMusteriAdi;
        private System.Windows.Forms.ComboBox cmbRezervasyonlar;
        private System.Windows.Forms.Panel pnlAyrac;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnOlustur;
    }
}