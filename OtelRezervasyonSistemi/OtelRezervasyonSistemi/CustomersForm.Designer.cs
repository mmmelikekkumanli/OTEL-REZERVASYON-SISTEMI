namespace OtelRezervasyonSistemi
{
    partial class CustomersForm
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
            this.pnlUst = new System.Windows.Forms.Panel();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.btnYeniMusteri = new System.Windows.Forms.Button();
            this.dgvMusteriler = new System.Windows.Forms.DataGridView();
            this.contextMenuMusteri = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.duzenletoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siltoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTCKN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIslemler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMusteriID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriler)).BeginInit();
            this.contextMenuMusteri.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUst
            // 
            this.pnlUst.Controls.Add(this.txtArama);
            this.pnlUst.Controls.Add(this.btnYeniMusteri);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(1060, 100);
            this.pnlUst.TabIndex = 0;
            // 
            // txtArama
            // 
            this.txtArama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArama.ForeColor = System.Drawing.Color.Gray;
            this.txtArama.Location = new System.Drawing.Point(250, 32);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(300, 27);
            this.txtArama.TabIndex = 1;
            this.txtArama.Text = "Müşteri Adı, TC No veya Telefon Ara...";
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // btnYeniMusteri
            // 
            this.btnYeniMusteri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btnYeniMusteri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYeniMusteri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeniMusteri.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniMusteri.ForeColor = System.Drawing.Color.White;
            this.btnYeniMusteri.Location = new System.Drawing.Point(20, 30);
            this.btnYeniMusteri.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnYeniMusteri.Name = "btnYeniMusteri";
            this.btnYeniMusteri.Size = new System.Drawing.Size(200, 40);
            this.btnYeniMusteri.TabIndex = 0;
            this.btnYeniMusteri.Text = "YENİ MÜŞTERİ";
            this.btnYeniMusteri.UseVisualStyleBackColor = false;
            this.btnYeniMusteri.Click += new System.EventHandler(this.btnYeniMusteri_Click);
            // 
            // dgvMusteriler
            // 
            this.dgvMusteriler.AllowUserToAddRows = false;
            this.dgvMusteriler.BackgroundColor = System.Drawing.Color.White;
            this.dgvMusteriler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusteriler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAd,
            this.colTelefon,
            this.colSoyad,
            this.colTCKN,
            this.colEmail,
            this.colIslemler,
            this.colMusteriID});
            this.dgvMusteriler.ContextMenuStrip = this.contextMenuMusteri;
            this.dgvMusteriler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMusteriler.Location = new System.Drawing.Point(0, 100);
            this.dgvMusteriler.Margin = new System.Windows.Forms.Padding(20);
            this.dgvMusteriler.Name = "dgvMusteriler";
            this.dgvMusteriler.ReadOnly = true;
            this.dgvMusteriler.RowHeadersVisible = false;
            this.dgvMusteriler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMusteriler.Size = new System.Drawing.Size(1060, 560);
            this.dgvMusteriler.TabIndex = 1;
            // 
            // contextMenuMusteri
            // 
            this.contextMenuMusteri.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.duzenletoolStripMenuItem,
            this.siltoolStripMenuItem});
            this.contextMenuMusteri.Name = "contextMenuMusteri";
            this.contextMenuMusteri.Size = new System.Drawing.Size(120, 48);
            // 
            // duzenletoolStripMenuItem
            // 
            this.duzenletoolStripMenuItem.Name = "duzenletoolStripMenuItem";
            this.duzenletoolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.duzenletoolStripMenuItem.Text = "Düzenle ";
            this.duzenletoolStripMenuItem.Click += new System.EventHandler(this.duzenletoolStripMenuItem_Click);
            // 
            // siltoolStripMenuItem
            // 
            this.siltoolStripMenuItem.Name = "siltoolStripMenuItem";
            this.siltoolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.siltoolStripMenuItem.Text = "Sil";
            this.siltoolStripMenuItem.Click += new System.EventHandler(this.siltoolStripMenuItem_Click);
            // 
            // colAd
            // 
            this.colAd.HeaderText = "Ad";
            this.colAd.Name = "colAd";
            this.colAd.ReadOnly = true;
            this.colAd.Width = 130;
            // 
            // colTelefon
            // 
            this.colTelefon.HeaderText = "Telefon";
            this.colTelefon.Name = "colTelefon";
            this.colTelefon.ReadOnly = true;
            this.colTelefon.Width = 132;
            // 
            // colSoyad
            // 
            this.colSoyad.HeaderText = "Soyad";
            this.colSoyad.Name = "colSoyad";
            this.colSoyad.ReadOnly = true;
            this.colSoyad.Width = 130;
            // 
            // colTCKN
            // 
            this.colTCKN.HeaderText = "TC Kimlik No";
            this.colTCKN.Name = "colTCKN";
            this.colTCKN.ReadOnly = true;
            this.colTCKN.Width = 130;
            // 
            // colEmail
            // 
            this.colEmail.HeaderText = "E-posta";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            this.colEmail.Width = 130;
            // 
            // colIslemler
            // 
            this.colIslemler.HeaderText = "İşlemler";
            this.colIslemler.Name = "colIslemler";
            this.colIslemler.ReadOnly = true;
            this.colIslemler.Width = 130;
            // 
            // colMusteriID
            // 
            this.colMusteriID.HeaderText = "Müşteri ID";
            this.colMusteriID.Name = "colMusteriID";
            this.colMusteriID.ReadOnly = true;
            this.colMusteriID.Visible = false;
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1060, 660);
            this.Controls.Add(this.dgvMusteriler);
            this.Controls.Add(this.pnlUst);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CustomersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomersForm";
            this.Load += new System.EventHandler(this.CustomersForm_Load);
            this.pnlUst.ResumeLayout(false);
            this.pnlUst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriler)).EndInit();
            this.contextMenuMusteri.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.Button btnYeniMusteri;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.DataGridView dgvMusteriler;
        private System.Windows.Forms.ContextMenuStrip contextMenuMusteri;
        private System.Windows.Forms.ToolStripMenuItem duzenletoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siltoolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTCKN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIslemler;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMusteriID;
    }
}