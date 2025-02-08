namespace OtelRezervasyonSistemi
{
    partial class InvoicesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoicesForm));
            this.pnlUst = new System.Windows.Forms.Panel();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.btnYeniFatura = new System.Windows.Forms.Button();
            this.dgvFaturalar = new System.Windows.Forms.DataGridView();
            this.colFaturaNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMusteriAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRezervasyonNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFaturaTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOdemeDurumu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIslemler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaturalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUst
            // 
            this.pnlUst.Controls.Add(this.txtArama);
            this.pnlUst.Controls.Add(this.btnYeniFatura);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(1060, 100);
            this.pnlUst.TabIndex = 0;
            // 
            // txtArama
            // 
            this.txtArama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArama.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtArama.ForeColor = System.Drawing.Color.Gray;
            this.txtArama.Location = new System.Drawing.Point(250, 32);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(300, 29);
            this.txtArama.TabIndex = 1;
            this.txtArama.Text = "Fatura No veya Müşteri Ara...";
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // btnYeniFatura
            // 
            this.btnYeniFatura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btnYeniFatura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYeniFatura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeniFatura.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniFatura.ForeColor = System.Drawing.Color.White;
            this.btnYeniFatura.Location = new System.Drawing.Point(20, 30);
            this.btnYeniFatura.Name = "btnYeniFatura";
            this.btnYeniFatura.Size = new System.Drawing.Size(200, 40);
            this.btnYeniFatura.TabIndex = 0;
            this.btnYeniFatura.Text = "YENİ FATURA OLUŞTUR ";
            this.btnYeniFatura.UseVisualStyleBackColor = false;
            this.btnYeniFatura.Click += new System.EventHandler(this.btnYeniFatura_Click);
            // 
            // dgvFaturalar
            // 
            this.dgvFaturalar.AllowUserToAddRows = false;
            this.dgvFaturalar.BackgroundColor = System.Drawing.Color.White;
            this.dgvFaturalar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFaturalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFaturalar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFaturaNo,
            this.colMusteriAdi,
            this.colRezervasyonNo,
            this.colFaturaTarihi,
            this.colTutar,
            this.colOdemeDurumu,
            this.colIslemler});
            this.dgvFaturalar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFaturalar.Location = new System.Drawing.Point(0, 100);
            this.dgvFaturalar.Margin = new System.Windows.Forms.Padding(20);
            this.dgvFaturalar.Name = "dgvFaturalar";
            this.dgvFaturalar.ReadOnly = true;
            this.dgvFaturalar.RowHeadersVisible = false;
            this.dgvFaturalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFaturalar.Size = new System.Drawing.Size(1060, 560);
            this.dgvFaturalar.TabIndex = 1;
            // 
            // colFaturaNo
            // 
            this.colFaturaNo.HeaderText = "Fatura No";
            this.colFaturaNo.Name = "colFaturaNo";
            this.colFaturaNo.ReadOnly = true;
            this.colFaturaNo.Width = 130;
            // 
            // colMusteriAdi
            // 
            this.colMusteriAdi.HeaderText = "Müşteri Adı";
            this.colMusteriAdi.Name = "colMusteriAdi";
            this.colMusteriAdi.ReadOnly = true;
            this.colMusteriAdi.Width = 130;
            // 
            // colRezervasyonNo
            // 
            this.colRezervasyonNo.HeaderText = "Rezervasyon No";
            this.colRezervasyonNo.Name = "colRezervasyonNo";
            this.colRezervasyonNo.ReadOnly = true;
            this.colRezervasyonNo.Width = 130;
            // 
            // colFaturaTarihi
            // 
            this.colFaturaTarihi.HeaderText = "Fatura Tarihi";
            this.colFaturaTarihi.Name = "colFaturaTarihi";
            this.colFaturaTarihi.ReadOnly = true;
            this.colFaturaTarihi.Width = 130;
            // 
            // colTutar
            // 
            this.colTutar.HeaderText = "Tutar";
            this.colTutar.Name = "colTutar";
            this.colTutar.ReadOnly = true;
            this.colTutar.Width = 130;
            // 
            // colOdemeDurumu
            // 
            this.colOdemeDurumu.HeaderText = "Ödeme Durumu";
            this.colOdemeDurumu.Name = "colOdemeDurumu";
            this.colOdemeDurumu.ReadOnly = true;
            this.colOdemeDurumu.Width = 130;
            // 
            // colIslemler
            // 
            this.colIslemler.HeaderText = "İşlemler";
            this.colIslemler.Name = "colIslemler";
            this.colIslemler.ReadOnly = true;
            this.colIslemler.Width = 130;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(442, 398);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // InvoicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1060, 660);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvFaturalar);
            this.Controls.Add(this.pnlUst);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "InvoicesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InvoicesForm";
            this.Load += new System.EventHandler(this.InvoicesForm_Load);
            this.pnlUst.ResumeLayout(false);
            this.pnlUst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaturalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.Button btnYeniFatura;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.DataGridView dgvFaturalar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFaturaNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMusteriAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRezervasyonNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFaturaTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOdemeDurumu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIslemler;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}