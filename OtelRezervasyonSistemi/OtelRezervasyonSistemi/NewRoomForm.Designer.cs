namespace OtelRezervasyonSistemi
{
    partial class NewRoomForm
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
            this.grpOdaBilgileri = new System.Windows.Forms.GroupBox();
            this.cmbOdaTipi = new System.Windows.Forms.ComboBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.lblOdaTipi = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.lblOdaNo = new System.Windows.Forms.Label();
            this.txtOdaNo = new System.Windows.Forms.TextBox();
            this.pnlAyrac = new System.Windows.Forms.Panel();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.grpOdaBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOdaBilgileri
            // 
            this.grpOdaBilgileri.Controls.Add(this.cmbOdaTipi);
            this.grpOdaBilgileri.Controls.Add(this.txtFiyat);
            this.grpOdaBilgileri.Controls.Add(this.lblOdaTipi);
            this.grpOdaBilgileri.Controls.Add(this.lblFiyat);
            this.grpOdaBilgileri.Controls.Add(this.lblOdaNo);
            this.grpOdaBilgileri.Controls.Add(this.txtOdaNo);
            this.grpOdaBilgileri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpOdaBilgileri.Location = new System.Drawing.Point(30, 30);
            this.grpOdaBilgileri.Name = "grpOdaBilgileri";
            this.grpOdaBilgileri.Size = new System.Drawing.Size(1000, 480);
            this.grpOdaBilgileri.TabIndex = 0;
            this.grpOdaBilgileri.TabStop = false;
            this.grpOdaBilgileri.Text = "Oda Bilgileri";
            // 
            // cmbOdaTipi
            // 
            this.cmbOdaTipi.FormattingEnabled = true;
            this.cmbOdaTipi.Items.AddRange(new object[] {
            "Tek Kişilik",
            "Çift Kişilik",
            "Suit"});
            this.cmbOdaTipi.Location = new System.Drawing.Point(150, 100);
            this.cmbOdaTipi.Name = "cmbOdaTipi";
            this.cmbOdaTipi.Size = new System.Drawing.Size(300, 29);
            this.cmbOdaTipi.TabIndex = 6;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFiyat.Location = new System.Drawing.Point(150, 150);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(300, 27);
            this.txtFiyat.TabIndex = 5;
            // 
            // lblOdaTipi
            // 
            this.lblOdaTipi.AutoSize = true;
            this.lblOdaTipi.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdaTipi.Location = new System.Drawing.Point(30, 100);
            this.lblOdaTipi.Name = "lblOdaTipi";
            this.lblOdaTipi.Size = new System.Drawing.Size(73, 20);
            this.lblOdaTipi.TabIndex = 3;
            this.lblOdaTipi.Text = "Oda Tipi :";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFiyat.Location = new System.Drawing.Point(30, 150);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(47, 20);
            this.lblFiyat.TabIndex = 2;
            this.lblFiyat.Text = "Fiyat :";
            // 
            // lblOdaNo
            // 
            this.lblOdaNo.AutoSize = true;
            this.lblOdaNo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdaNo.Location = new System.Drawing.Point(30, 50);
            this.lblOdaNo.Name = "lblOdaNo";
            this.lblOdaNo.Size = new System.Drawing.Size(111, 20);
            this.lblOdaNo.TabIndex = 1;
            this.lblOdaNo.Text = "Oda Numarası :";
            // 
            // txtOdaNo
            // 
            this.txtOdaNo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOdaNo.Location = new System.Drawing.Point(150, 50);
            this.txtOdaNo.Name = "txtOdaNo";
            this.txtOdaNo.Size = new System.Drawing.Size(300, 27);
            this.txtOdaNo.TabIndex = 0;
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
            // NewRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1060, 660);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.pnlAyrac);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.grpOdaBilgileri);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NewRoomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewRoomForm";
            this.grpOdaBilgileri.ResumeLayout(false);
            this.grpOdaBilgileri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOdaBilgileri;
        private System.Windows.Forms.Label lblOdaNo;
        private System.Windows.Forms.TextBox txtOdaNo;
        private System.Windows.Forms.ComboBox cmbOdaTipi;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label lblOdaTipi;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Panel pnlAyrac;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnKaydet;
    }
}