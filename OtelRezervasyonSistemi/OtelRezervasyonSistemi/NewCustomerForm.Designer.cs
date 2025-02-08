namespace OtelRezervasyonSistemi
{
    partial class NewCustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewCustomerForm));
            this.grpMusteriBilgileri = new System.Windows.Forms.GroupBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTCKN = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblTCKN = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.pnlAyrac = new System.Windows.Forms.Panel();
            this.btnIptal = new System.Windows.Forms.Button();
            this.ıconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.grpMusteriBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMusteriBilgileri
            // 
            this.grpMusteriBilgileri.Controls.Add(this.ıconPictureBox1);
            this.grpMusteriBilgileri.Controls.Add(this.txtTelefon);
            this.grpMusteriBilgileri.Controls.Add(this.txtEmail);
            this.grpMusteriBilgileri.Controls.Add(this.txtTCKN);
            this.grpMusteriBilgileri.Controls.Add(this.txtSoyad);
            this.grpMusteriBilgileri.Controls.Add(this.txtAd);
            this.grpMusteriBilgileri.Controls.Add(this.lblEmail);
            this.grpMusteriBilgileri.Controls.Add(this.lblTelefon);
            this.grpMusteriBilgileri.Controls.Add(this.lblTCKN);
            this.grpMusteriBilgileri.Controls.Add(this.lblSoyad);
            this.grpMusteriBilgileri.Controls.Add(this.lblAd);
            this.grpMusteriBilgileri.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpMusteriBilgileri.Location = new System.Drawing.Point(30, 32);
            this.grpMusteriBilgileri.Name = "grpMusteriBilgileri";
            this.grpMusteriBilgileri.Size = new System.Drawing.Size(1000, 480);
            this.grpMusteriBilgileri.TabIndex = 0;
            this.grpMusteriBilgileri.TabStop = false;
            this.grpMusteriBilgileri.Text = "Müşteri Bilgileri";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(150, 170);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(300, 27);
            this.txtTelefon.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(150, 210);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(300, 27);
            this.txtEmail.TabIndex = 8;
            // 
            // txtTCKN
            // 
            this.txtTCKN.Location = new System.Drawing.Point(150, 130);
            this.txtTCKN.Name = "txtTCKN";
            this.txtTCKN.Size = new System.Drawing.Size(300, 27);
            this.txtTCKN.TabIndex = 7;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(150, 90);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(300, 27);
            this.txtSoyad.TabIndex = 6;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(150, 50);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(300, 27);
            this.txtAd.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(30, 210);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(67, 20);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "E-posta :";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(30, 170);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(69, 20);
            this.lblTelefon.TabIndex = 3;
            this.lblTelefon.Text = "Telefon : ";
            // 
            // lblTCKN
            // 
            this.lblTCKN.AutoSize = true;
            this.lblTCKN.Location = new System.Drawing.Point(30, 130);
            this.lblTCKN.Name = "lblTCKN";
            this.lblTCKN.Size = new System.Drawing.Size(101, 20);
            this.lblTCKN.TabIndex = 2;
            this.lblTCKN.Text = "TC Kimlik No :";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(30, 90);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(57, 20);
            this.lblSoyad.TabIndex = 1;
            this.lblSoyad.Text = "Soyad :";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(30, 50);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(35, 20);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Ad :";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(850, 550);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(180, 40);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click_1);
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
            this.btnIptal.Text = "İPTAL";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click_1);
            // 
            // ıconPictureBox1
            // 
            this.ıconPictureBox1.BackColor = System.Drawing.Color.White;
            this.ıconPictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ıconPictureBox1.BackgroundImage")));
            this.ıconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ıconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconPictureBox1.IconSize = 124;
            this.ıconPictureBox1.Location = new System.Drawing.Point(692, 90);
            this.ıconPictureBox1.Name = "ıconPictureBox1";
            this.ıconPictureBox1.Size = new System.Drawing.Size(128, 124);
            this.ıconPictureBox1.TabIndex = 10;
            this.ıconPictureBox1.TabStop = false;
            // 
            // NewCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1060, 660);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.pnlAyrac);
            this.Controls.Add(this.grpMusteriBilgileri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewCustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewCustomerForm";
            this.grpMusteriBilgileri.ResumeLayout(false);
            this.grpMusteriBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMusteriBilgileri;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblTCKN;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTCKN;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Panel pnlAyrac;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnKaydet;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox1;
    }
}