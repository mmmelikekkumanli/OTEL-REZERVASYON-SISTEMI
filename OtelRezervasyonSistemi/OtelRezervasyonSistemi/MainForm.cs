using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelRezervasyonSistemi
{
    public partial class MainForm : Form
    {
        // Form nesneleri
        private ReservationsForm frmRezervasyon;
        private RoomsForm frmOdalar;
        private CustomersForm frmMusteriler;
        private InvoicesForm frmFaturalar;
        private ReportsForm frmRaporlar;

        // Aktif form takibi
        private Form aktifForm = null;

        public MainForm()
        {
            InitializeComponent();
           
        }

        // Form yükleme metodu
        private void FormGoster(Form form)
        {
            try
            {
                if (aktifForm != null)
                {
                    aktifForm.Close();
                    aktifForm.Dispose(); // Form nesnesini temizle
                }

                pnlIcerik.Controls.Clear(); // Panel içeriğini temizle

                aktifForm = form;
                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                pnlIcerik.Controls.Add(form);
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Form gösterilirken hata oluştu: " + ex.Message);
            }
        }

        // Menü butonlarına tıklandığında
        private void btnRezervasyonlar_Click_1(object sender, EventArgs e)
        {
            try
            {
                frmRezervasyon = new ReservationsForm();
                FormGoster(frmRezervasyon);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rezervasyon formu açılırken hata oluştu: " + ex.Message);
            }
        }

        private void btnOdalar_Click(object sender, EventArgs e)
        {
            try
            {
                frmOdalar = new RoomsForm();
                FormGoster(frmOdalar);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Odalar formu açılırken hata oluştu: " + ex.Message);
            }
        }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    frmMusteriler = new CustomersForm();
                    FormGoster(frmMusteriler);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Müşteriler formu açılırken hata oluştu: " + ex.Message);
                }
            }
        }

        private void btnFaturalar_Click(object sender, EventArgs e)
        {
            try
            {
                frmFaturalar = new InvoicesForm();
                FormGoster(frmFaturalar);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Faturalar formu açılırken hata oluştu: " + ex.Message);
            }
        }

        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    frmRaporlar = new ReportsForm();
                    FormGoster(frmRaporlar);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Raporlar formu açılırken hata oluştu: " + ex.Message);
                }
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            {
                if (MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz?", "Çıkış",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            {
                if (MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz?", "Çıkış",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

        
    }
}