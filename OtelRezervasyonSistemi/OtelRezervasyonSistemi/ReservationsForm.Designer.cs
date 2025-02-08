namespace OtelRezervasyonSistemi
{
    partial class ReservationsForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationsForm));
            this.pnlUst = new System.Windows.Forms.Panel();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.btnYeniRezervasyon = new System.Windows.Forms.Button();
            this.dgvRezervasyonlar = new System.Windows.Forms.DataGridView();
            this.colIslemler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRezervasyonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRezervasyonNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDurum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colToplamTutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCikisTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGirisTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMusteriAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOdaNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuRezervasyon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.duzenletoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iptalEttoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervasyonlar)).BeginInit();
            this.contextMenuRezervasyon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUst
            // 
            this.pnlUst.BackColor = System.Drawing.Color.White;
            this.pnlUst.Controls.Add(this.txtArama);
            this.pnlUst.Controls.Add(this.btnYeniRezervasyon);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(1060, 100);
            this.pnlUst.TabIndex = 0;
            // 
            // txtArama
            // 
            this.txtArama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArama.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtArama.Location = new System.Drawing.Point(250, 32);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(300, 29);
            this.txtArama.TabIndex = 1;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // btnYeniRezervasyon
            // 
            this.btnYeniRezervasyon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btnYeniRezervasyon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYeniRezervasyon.FlatAppearance.BorderSize = 0;
            this.btnYeniRezervasyon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeniRezervasyon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniRezervasyon.ForeColor = System.Drawing.Color.White;
            this.btnYeniRezervasyon.Location = new System.Drawing.Point(20, 30);
            this.btnYeniRezervasyon.Name = "btnYeniRezervasyon";
            this.btnYeniRezervasyon.Size = new System.Drawing.Size(200, 40);
            this.btnYeniRezervasyon.TabIndex = 0;
            this.btnYeniRezervasyon.Text = "YENİ REZERVASYON";
            this.btnYeniRezervasyon.UseVisualStyleBackColor = false;
            this.btnYeniRezervasyon.Click += new System.EventHandler(this.btnYeniRezervasyon_Click);
            // 
            // dgvRezervasyonlar
            // 
            this.dgvRezervasyonlar.AllowUserToAddRows = false;
            this.dgvRezervasyonlar.AllowUserToDeleteRows = false;
            this.dgvRezervasyonlar.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvRezervasyonlar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRezervasyonlar.BackgroundColor = System.Drawing.Color.White;
            this.dgvRezervasyonlar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRezervasyonlar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRezervasyonlar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRezervasyonlar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRezervasyonlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezervasyonlar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIslemler,
            this.colRezervasyonID,
            this.colRezervasyonNo,
            this.colDurum,
            this.colToplamTutar,
            this.colCikisTarihi,
            this.colGirisTarihi,
            this.colMusteriAdi,
            this.colOdaNo});
            this.dgvRezervasyonlar.ContextMenuStrip = this.contextMenuRezervasyon;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRezervasyonlar.DefaultCellStyle = dataGridViewCellStyle21;
            this.dgvRezervasyonlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRezervasyonlar.Location = new System.Drawing.Point(0, 100);
            this.dgvRezervasyonlar.Margin = new System.Windows.Forms.Padding(20);
            this.dgvRezervasyonlar.MultiSelect = false;
            this.dgvRezervasyonlar.Name = "dgvRezervasyonlar";
            this.dgvRezervasyonlar.ReadOnly = true;
            this.dgvRezervasyonlar.RowHeadersVisible = false;
            this.dgvRezervasyonlar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvRezervasyonlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRezervasyonlar.Size = new System.Drawing.Size(1060, 560);
            this.dgvRezervasyonlar.TabIndex = 1;
            this.dgvRezervasyonlar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRezervasyonlar_CellContentClick);
            // 
            // colIslemler
            // 
            this.colIslemler.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colIslemler.FillWeight = 3.698216F;
            this.colIslemler.HeaderText = "İşlemler";
            this.colIslemler.Name = "colIslemler";
            this.colIslemler.ReadOnly = true;
            this.colIslemler.Width = 132;
            // 
            // colRezervasyonID
            // 
            this.colRezervasyonID.HeaderText = "RezervasyonID";
            this.colRezervasyonID.Name = "colRezervasyonID";
            this.colRezervasyonID.ReadOnly = true;
            this.colRezervasyonID.Visible = false;
            this.colRezervasyonID.Width = 120;
            // 
            // colRezervasyonNo
            // 
            this.colRezervasyonNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colRezervasyonNo.FillWeight = 0.7797954F;
            this.colRezervasyonNo.HeaderText = "Rezervasyon No";
            this.colRezervasyonNo.Name = "colRezervasyonNo";
            this.colRezervasyonNo.ReadOnly = true;
            this.colRezervasyonNo.Width = 133;
            // 
            // colDurum
            // 
            this.colDurum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colDurum.FillWeight = 20.77056F;
            this.colDurum.HeaderText = "Durum";
            this.colDurum.Name = "colDurum";
            this.colDurum.ReadOnly = true;
            this.colDurum.Width = 132;
            // 
            // colToplamTutar
            // 
            this.colToplamTutar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle15.Format = "C2";
            dataGridViewCellStyle15.NullValue = null;
            this.colToplamTutar.DefaultCellStyle = dataGridViewCellStyle15;
            this.colToplamTutar.FillWeight = 116.882F;
            this.colToplamTutar.HeaderText = "Toplam Tutar";
            this.colToplamTutar.Name = "colToplamTutar";
            this.colToplamTutar.ReadOnly = true;
            this.colToplamTutar.Width = 132;
            // 
            // colCikisTarihi
            // 
            this.colCikisTarihi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle19.Format = "dd.MM.yyyy";
            dataGridViewCellStyle19.NullValue = null;
            this.colCikisTarihi.DefaultCellStyle = dataGridViewCellStyle19;
            this.colCikisTarihi.FillWeight = 657.8682F;
            this.colCikisTarihi.HeaderText = "Çıkış Tarihi";
            this.colCikisTarihi.Name = "colCikisTarihi";
            this.colCikisTarihi.ReadOnly = true;
            this.colCikisTarihi.Width = 132;
            // 
            // colGirisTarihi
            // 
            this.colGirisTarihi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle20.Format = "dd.MM.yyyy";
            dataGridViewCellStyle20.NullValue = null;
            this.colGirisTarihi.DefaultCellStyle = dataGridViewCellStyle20;
            this.colGirisTarihi.FillWeight = 0.0008802045F;
            this.colGirisTarihi.HeaderText = "Giriş Tarihi";
            this.colGirisTarihi.Name = "colGirisTarihi";
            this.colGirisTarihi.ReadOnly = true;
            this.colGirisTarihi.Width = 132;
            // 
            // colMusteriAdi
            // 
            this.colMusteriAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colMusteriAdi.FillWeight = 0.0002710401F;
            this.colMusteriAdi.HeaderText = "Müşteri Adı";
            this.colMusteriAdi.Name = "colMusteriAdi";
            this.colMusteriAdi.ReadOnly = true;
            this.colMusteriAdi.Width = 134;
            // 
            // colOdaNo
            // 
            this.colOdaNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colOdaNo.FillWeight = 0.0002866995F;
            this.colOdaNo.HeaderText = "Oda No";
            this.colOdaNo.Name = "colOdaNo";
            this.colOdaNo.ReadOnly = true;
            this.colOdaNo.Width = 132;
            // 
            // contextMenuRezervasyon
            // 
            this.contextMenuRezervasyon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.duzenletoolStripMenuItem,
            this.iptalEttoolStripMenuItem});
            this.contextMenuRezervasyon.Name = "contextMenuRezervasyon";
            this.contextMenuRezervasyon.Size = new System.Drawing.Size(250, 48);
            // 
            // duzenletoolStripMenuItem
            // 
            this.duzenletoolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.duzenletoolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.duzenletoolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("duzenletoolStripMenuItem.Image")));
            this.duzenletoolStripMenuItem.Name = "duzenletoolStripMenuItem";
            this.duzenletoolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.duzenletoolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.duzenletoolStripMenuItem.Text = "Rezervasyonu Düzenle";
            this.duzenletoolStripMenuItem.Click += new System.EventHandler(this.duzenletoolStripMenuItem_Click_1);
            // 
            // iptalEttoolStripMenuItem
            // 
            this.iptalEttoolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.iptalEttoolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("iptalEttoolStripMenuItem.Image")));
            this.iptalEttoolStripMenuItem.Name = "iptalEttoolStripMenuItem";
            this.iptalEttoolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.iptalEttoolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.iptalEttoolStripMenuItem.Text = "Rezervasyonu İptal Et";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(361, 262);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // ReservationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1060, 660);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvRezervasyonlar);
            this.Controls.Add(this.pnlUst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReservationsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "RezervasyonForm";
            this.Load += new System.EventHandler(this.ReservationsForm_Load);
            this.pnlUst.ResumeLayout(false);
            this.pnlUst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervasyonlar)).EndInit();
            this.contextMenuRezervasyon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.Button btnYeniRezervasyon;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.DataGridView dgvRezervasyonlar;
        private System.Windows.Forms.ContextMenuStrip contextMenuRezervasyon;
        private System.Windows.Forms.ToolStripMenuItem duzenletoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iptalEttoolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIslemler;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRezervasyonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRezervasyonNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDurum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colToplamTutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCikisTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGirisTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMusteriAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOdaNo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}