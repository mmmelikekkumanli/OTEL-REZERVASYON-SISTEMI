namespace OtelRezervasyonSistemi
{
    partial class RoomsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomsForm));
            this.pnlUst = new System.Windows.Forms.Panel();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.btnYeniOda = new System.Windows.Forms.Button();
            this.dgvOdalar = new System.Windows.Forms.DataGridView();
            this.colOdaNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOdaTipi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDurum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIslemler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuOda = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ıconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.pnlUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdalar)).BeginInit();
            this.contextMenuOda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUst
            // 
            this.pnlUst.Controls.Add(this.txtArama);
            this.pnlUst.Controls.Add(this.btnYeniOda);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Margin = new System.Windows.Forms.Padding(5);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(1370, 162);
            this.pnlUst.TabIndex = 0;
            // 
            // txtArama
            // 
            this.txtArama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArama.ForeColor = System.Drawing.Color.Gray;
            this.txtArama.Location = new System.Drawing.Point(250, 32);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(300, 29);
            this.txtArama.TabIndex = 1;
            this.txtArama.Text = "Oda Numarası veya Tipi Ara...";
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // btnYeniOda
            // 
            this.btnYeniOda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btnYeniOda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYeniOda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeniOda.ForeColor = System.Drawing.Color.White;
            this.btnYeniOda.Location = new System.Drawing.Point(20, 30);
            this.btnYeniOda.Margin = new System.Windows.Forms.Padding(5);
            this.btnYeniOda.Name = "btnYeniOda";
            this.btnYeniOda.Size = new System.Drawing.Size(200, 40);
            this.btnYeniOda.TabIndex = 0;
            this.btnYeniOda.Text = "YENİ ODA EKLE";
            this.btnYeniOda.UseVisualStyleBackColor = false;
            this.btnYeniOda.Click += new System.EventHandler(this.btnYeniOda_Click);
            // 
            // dgvOdalar
            // 
            this.dgvOdalar.AllowUserToAddRows = false;
            this.dgvOdalar.BackgroundColor = System.Drawing.Color.White;
            this.dgvOdalar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOdalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdalar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOdaNo,
            this.colOdaTipi,
            this.colFiyat,
            this.colDurum,
            this.colIslemler});
            this.dgvOdalar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOdalar.EnableHeadersVisualStyles = false;
            this.dgvOdalar.Location = new System.Drawing.Point(0, 162);
            this.dgvOdalar.Margin = new System.Windows.Forms.Padding(20);
            this.dgvOdalar.Name = "dgvOdalar";
            this.dgvOdalar.ReadOnly = true;
            this.dgvOdalar.RowHeadersVisible = false;
            this.dgvOdalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOdalar.Size = new System.Drawing.Size(1370, 587);
            this.dgvOdalar.TabIndex = 1;
            // 
            // colOdaNo
            // 
            this.colOdaNo.HeaderText = "Oda No";
            this.colOdaNo.Name = "colOdaNo";
            this.colOdaNo.ReadOnly = true;
            this.colOdaNo.Width = 130;
            // 
            // colOdaTipi
            // 
            this.colOdaTipi.HeaderText = "Oda Tipi";
            this.colOdaTipi.Name = "colOdaTipi";
            this.colOdaTipi.ReadOnly = true;
            this.colOdaTipi.Width = 130;
            // 
            // colFiyat
            // 
            this.colFiyat.HeaderText = "Fiyat";
            this.colFiyat.Name = "colFiyat";
            this.colFiyat.ReadOnly = true;
            this.colFiyat.Width = 130;
            // 
            // colDurum
            // 
            this.colDurum.HeaderText = "Durum";
            this.colDurum.Name = "colDurum";
            this.colDurum.ReadOnly = true;
            this.colDurum.Width = 130;
            // 
            // colIslemler
            // 
            this.colIslemler.HeaderText = "İşlemler";
            this.colIslemler.Name = "colIslemler";
            this.colIslemler.ReadOnly = true;
            this.colIslemler.Width = 130;
            // 
            // contextMenuOda
            // 
            this.contextMenuOda.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.düzenleToolStripMenuItem,
            this.silToolStripMenuItem});
            this.contextMenuOda.Name = "contextMenuOda";
            this.contextMenuOda.Size = new System.Drawing.Size(117, 48);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // ıconPictureBox1
            // 
            this.ıconPictureBox1.BackColor = System.Drawing.Color.White;
            this.ıconPictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ıconPictureBox1.BackgroundImage")));
            this.ıconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ıconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconPictureBox1.IconSize = 130;
            this.ıconPictureBox1.Location = new System.Drawing.Point(797, 259);
            this.ıconPictureBox1.Name = "ıconPictureBox1";
            this.ıconPictureBox1.Size = new System.Drawing.Size(130, 135);
            this.ıconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ıconPictureBox1.TabIndex = 2;
            this.ıconPictureBox1.TabStop = false;
            // 
            // RoomsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.ıconPictureBox1);
            this.Controls.Add(this.dgvOdalar);
            this.Controls.Add(this.pnlUst);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "RoomsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoomsForm";
            this.Load += new System.EventHandler(this.RoomsForm_Load);
            this.pnlUst.ResumeLayout(false);
            this.pnlUst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdalar)).EndInit();
            this.contextMenuOda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Button btnYeniOda;
        private System.Windows.Forms.DataGridView dgvOdalar;
        private System.Windows.Forms.ContextMenuStrip contextMenuOda;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOdaNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOdaTipi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDurum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIslemler;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox1;
    }
}