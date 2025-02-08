namespace OtelRezervasyonSistemi
{
    partial class ReportsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportsForm));
            this.pnlSol = new System.Windows.Forms.Panel();
            this.btnMusteriRaporu = new System.Windows.Forms.Button();
            this.btnGelirRaporu = new System.Windows.Forms.Button();
            this.btnDolulukRaporu = new System.Windows.Forms.Button();
            this.lblRaporBaslik = new System.Windows.Forms.Label();
            this.pnlIcerik = new System.Windows.Forms.Panel();
            this.ipbRapor = new FontAwesome.Sharp.IconPictureBox();
            this.dgvRapor = new System.Windows.Forms.DataGridView();
            this.colTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMusteriAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKonaklamaSayisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colToplamOda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colToplamHarcama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrtalamaKonaklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDoluOda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBosOda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDolulukOrani = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTarih = new System.Windows.Forms.Panel();
            this.btnRaporGoster = new System.Windows.Forms.Button();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.lblBaslangicTarihi = new System.Windows.Forms.Label();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.lblBitisTarihi = new System.Windows.Forms.Label();
            this.pnlSol.SuspendLayout();
            this.pnlIcerik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbRapor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapor)).BeginInit();
            this.pnlTarih.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSol
            // 
            this.pnlSol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.pnlSol.Controls.Add(this.btnMusteriRaporu);
            this.pnlSol.Controls.Add(this.btnGelirRaporu);
            this.pnlSol.Controls.Add(this.btnDolulukRaporu);
            this.pnlSol.Controls.Add(this.lblRaporBaslik);
            this.pnlSol.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSol.Location = new System.Drawing.Point(0, 0);
            this.pnlSol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlSol.Name = "pnlSol";
            this.pnlSol.Size = new System.Drawing.Size(250, 660);
            this.pnlSol.TabIndex = 0;
            // 
            // btnMusteriRaporu
            // 
            this.btnMusteriRaporu.BackColor = System.Drawing.Color.Transparent;
            this.btnMusteriRaporu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMusteriRaporu.FlatAppearance.BorderSize = 0;
            this.btnMusteriRaporu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusteriRaporu.ForeColor = System.Drawing.Color.White;
            this.btnMusteriRaporu.Location = new System.Drawing.Point(0, 160);
            this.btnMusteriRaporu.Name = "btnMusteriRaporu";
            this.btnMusteriRaporu.Size = new System.Drawing.Size(250, 50);
            this.btnMusteriRaporu.TabIndex = 3;
            this.btnMusteriRaporu.Text = " MÜŞTERİ RAPORU";
            this.btnMusteriRaporu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusteriRaporu.UseVisualStyleBackColor = false;
            this.btnMusteriRaporu.Click += new System.EventHandler(this.btnMusteriRaporu_Click_1);
            // 
            // btnGelirRaporu
            // 
            this.btnGelirRaporu.BackColor = System.Drawing.Color.Transparent;
            this.btnGelirRaporu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGelirRaporu.FlatAppearance.BorderSize = 0;
            this.btnGelirRaporu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGelirRaporu.ForeColor = System.Drawing.Color.White;
            this.btnGelirRaporu.Location = new System.Drawing.Point(0, 110);
            this.btnGelirRaporu.Name = "btnGelirRaporu";
            this.btnGelirRaporu.Size = new System.Drawing.Size(250, 50);
            this.btnGelirRaporu.TabIndex = 2;
            this.btnGelirRaporu.Text = " GELİR RAPORU";
            this.btnGelirRaporu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGelirRaporu.UseVisualStyleBackColor = false;
            this.btnGelirRaporu.Click += new System.EventHandler(this.btnGelirRaporu_Click_1);
            // 
            // btnDolulukRaporu
            // 
            this.btnDolulukRaporu.BackColor = System.Drawing.Color.Transparent;
            this.btnDolulukRaporu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDolulukRaporu.FlatAppearance.BorderSize = 0;
            this.btnDolulukRaporu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDolulukRaporu.ForeColor = System.Drawing.Color.White;
            this.btnDolulukRaporu.Location = new System.Drawing.Point(0, 60);
            this.btnDolulukRaporu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDolulukRaporu.Name = "btnDolulukRaporu";
            this.btnDolulukRaporu.Size = new System.Drawing.Size(250, 50);
            this.btnDolulukRaporu.TabIndex = 1;
            this.btnDolulukRaporu.Text = " DOLULUK ORANI";
            this.btnDolulukRaporu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDolulukRaporu.UseVisualStyleBackColor = false;
            this.btnDolulukRaporu.Click += new System.EventHandler(this.btnDolulukRaporu_Click_1);
            // 
            // lblRaporBaslik
            // 
            this.lblRaporBaslik.AutoSize = true;
            this.lblRaporBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRaporBaslik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRaporBaslik.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRaporBaslik.ForeColor = System.Drawing.Color.White;
            this.lblRaporBaslik.Location = new System.Drawing.Point(0, 0);
            this.lblRaporBaslik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRaporBaslik.Name = "lblRaporBaslik";
            this.lblRaporBaslik.Size = new System.Drawing.Size(110, 25);
            this.lblRaporBaslik.TabIndex = 0;
            this.lblRaporBaslik.Text = "RAPORLAR";
            this.lblRaporBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlIcerik
            // 
            this.pnlIcerik.BackColor = System.Drawing.Color.White;
            this.pnlIcerik.Controls.Add(this.ipbRapor);
            this.pnlIcerik.Controls.Add(this.dgvRapor);
            this.pnlIcerik.Controls.Add(this.pnlTarih);
            this.pnlIcerik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlIcerik.Location = new System.Drawing.Point(250, 0);
            this.pnlIcerik.Name = "pnlIcerik";
            this.pnlIcerik.Padding = new System.Windows.Forms.Padding(20);
            this.pnlIcerik.Size = new System.Drawing.Size(810, 660);
            this.pnlIcerik.TabIndex = 1;
            // 
            // ipbRapor
            // 
            this.ipbRapor.BackColor = System.Drawing.Color.White;
            this.ipbRapor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ipbRapor.BackgroundImage")));
            this.ipbRapor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ipbRapor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ipbRapor.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ipbRapor.IconColor = System.Drawing.SystemColors.ControlText;
            this.ipbRapor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbRapor.IconSize = 130;
            this.ipbRapor.Location = new System.Drawing.Point(340, 295);
            this.ipbRapor.Name = "ipbRapor";
            this.ipbRapor.Size = new System.Drawing.Size(130, 135);
            this.ipbRapor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ipbRapor.TabIndex = 2;
            this.ipbRapor.TabStop = false;
            // 
            // dgvRapor
            // 
            this.dgvRapor.AllowUserToAddRows = false;
            this.dgvRapor.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvRapor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRapor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTarih,
            this.colMusteriAdi,
            this.colKonaklamaSayisi,
            this.colToplamOda,
            this.colToplamHarcama,
            this.colOrtalamaKonaklama,
            this.colDoluOda,
            this.colBosOda,
            this.colDolulukOrani});
            this.dgvRapor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRapor.Location = new System.Drawing.Point(20, 80);
            this.dgvRapor.Margin = new System.Windows.Forms.Padding(20);
            this.dgvRapor.Name = "dgvRapor";
            this.dgvRapor.ReadOnly = true;
            this.dgvRapor.RowHeadersVisible = false;
            this.dgvRapor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRapor.Size = new System.Drawing.Size(770, 560);
            this.dgvRapor.TabIndex = 1;
            // 
            // colTarih
            // 
            this.colTarih.HeaderText = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.ReadOnly = true;
            this.colTarih.Width = 130;
            // 
            // colMusteriAdi
            // 
            this.colMusteriAdi.HeaderText = "Müşteri Adı";
            this.colMusteriAdi.Name = "colMusteriAdi";
            this.colMusteriAdi.ReadOnly = true;
            this.colMusteriAdi.Width = 130;
            // 
            // colKonaklamaSayisi
            // 
            this.colKonaklamaSayisi.HeaderText = "Konaklama Sayısı";
            this.colKonaklamaSayisi.Name = "colKonaklamaSayisi";
            this.colKonaklamaSayisi.ReadOnly = true;
            this.colKonaklamaSayisi.Width = 130;
            // 
            // colToplamOda
            // 
            this.colToplamOda.HeaderText = "Toplam Oda";
            this.colToplamOda.Name = "colToplamOda";
            this.colToplamOda.ReadOnly = true;
            this.colToplamOda.Width = 130;
            // 
            // colToplamHarcama
            // 
            this.colToplamHarcama.HeaderText = "Toplam Harcama";
            this.colToplamHarcama.Name = "colToplamHarcama";
            this.colToplamHarcama.ReadOnly = true;
            this.colToplamHarcama.Width = 130;
            // 
            // colOrtalamaKonaklama
            // 
            this.colOrtalamaKonaklama.HeaderText = "Ortalama Konaklama";
            this.colOrtalamaKonaklama.Name = "colOrtalamaKonaklama";
            this.colOrtalamaKonaklama.ReadOnly = true;
            this.colOrtalamaKonaklama.Width = 130;
            // 
            // colDoluOda
            // 
            this.colDoluOda.HeaderText = "Dolu Oda";
            this.colDoluOda.Name = "colDoluOda";
            this.colDoluOda.ReadOnly = true;
            this.colDoluOda.Width = 130;
            // 
            // colBosOda
            // 
            this.colBosOda.HeaderText = "Boş Oda";
            this.colBosOda.Name = "colBosOda";
            this.colBosOda.ReadOnly = true;
            this.colBosOda.Width = 130;
            // 
            // colDolulukOrani
            // 
            this.colDolulukOrani.HeaderText = "Doluluk Oranı (%)";
            this.colDolulukOrani.Name = "colDolulukOrani";
            this.colDolulukOrani.ReadOnly = true;
            this.colDolulukOrani.Width = 130;
            // 
            // pnlTarih
            // 
            this.pnlTarih.Controls.Add(this.btnRaporGoster);
            this.pnlTarih.Controls.Add(this.dtpBaslangic);
            this.pnlTarih.Controls.Add(this.lblBaslangicTarihi);
            this.pnlTarih.Controls.Add(this.dtpBitis);
            this.pnlTarih.Controls.Add(this.lblBitisTarihi);
            this.pnlTarih.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTarih.Location = new System.Drawing.Point(20, 20);
            this.pnlTarih.Name = "pnlTarih";
            this.pnlTarih.Size = new System.Drawing.Size(770, 60);
            this.pnlTarih.TabIndex = 0;
            // 
            // btnRaporGoster
            // 
            this.btnRaporGoster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btnRaporGoster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRaporGoster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaporGoster.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRaporGoster.ForeColor = System.Drawing.Color.White;
            this.btnRaporGoster.Location = new System.Drawing.Point(480, 17);
            this.btnRaporGoster.Name = "btnRaporGoster";
            this.btnRaporGoster.Size = new System.Drawing.Size(150, 33);
            this.btnRaporGoster.TabIndex = 3;
            this.btnRaporGoster.Text = "RAPORU GÖSTER";
            this.btnRaporGoster.UseVisualStyleBackColor = false;
            this.btnRaporGoster.Click += new System.EventHandler(this.btnRaporGoster_Click_1);
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBaslangic.Location = new System.Drawing.Point(20, 25);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(200, 27);
            this.dtpBaslangic.TabIndex = 0;
            // 
            // lblBaslangicTarihi
            // 
            this.lblBaslangicTarihi.AutoSize = true;
            this.lblBaslangicTarihi.Location = new System.Drawing.Point(20, 5);
            this.lblBaslangicTarihi.Name = "lblBaslangicTarihi";
            this.lblBaslangicTarihi.Size = new System.Drawing.Size(122, 20);
            this.lblBaslangicTarihi.TabIndex = 2;
            this.lblBaslangicTarihi.Text = "Başlangıç Tarihi : ";
            // 
            // dtpBitis
            // 
            this.dtpBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBitis.Location = new System.Drawing.Point(250, 25);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(200, 27);
            this.dtpBitis.TabIndex = 1;
            // 
            // lblBitisTarihi
            // 
            this.lblBitisTarihi.AutoSize = true;
            this.lblBitisTarihi.Location = new System.Drawing.Point(250, 5);
            this.lblBitisTarihi.Name = "lblBitisTarihi";
            this.lblBitisTarihi.Size = new System.Drawing.Size(83, 20);
            this.lblBitisTarihi.TabIndex = 0;
            this.lblBitisTarihi.Text = "Bitiş Tarihi :";
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1060, 660);
            this.Controls.Add(this.pnlIcerik);
            this.Controls.Add(this.pnlSol);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportsForm";
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            this.pnlSol.ResumeLayout(false);
            this.pnlSol.PerformLayout();
            this.pnlIcerik.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ipbRapor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapor)).EndInit();
            this.pnlTarih.ResumeLayout(false);
            this.pnlTarih.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSol;
        private System.Windows.Forms.Button btnMusteriRaporu;
        private System.Windows.Forms.Button btnGelirRaporu;
        private System.Windows.Forms.Button btnDolulukRaporu;
        private System.Windows.Forms.Label lblRaporBaslik;
        private System.Windows.Forms.Panel pnlIcerik;
        private System.Windows.Forms.Panel pnlTarih;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.Label lblBitisTarihi;
        private System.Windows.Forms.DataGridView dgvRapor;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.Label lblBaslangicTarihi;
        private System.Windows.Forms.Button btnRaporGoster;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMusteriAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKonaklamaSayisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colToplamOda;
        private System.Windows.Forms.DataGridViewTextBoxColumn colToplamHarcama;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrtalamaKonaklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDoluOda;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBosOda;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDolulukOrani;
        private FontAwesome.Sharp.IconPictureBox ipbRapor;
    }
}