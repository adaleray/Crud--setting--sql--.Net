using System;
using System.Linq;
using System.Windows.Forms;
using ErayApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalOdevApp
{
    public partial class OgrKayýt : Form
    {
        private int selectedOgrenciId = -1;

        public OgrKayýt()
        {
            InitializeComponent();
            LoadStudents();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            LoadSiniflar();
        }

        private void LoadSiniflar()
        {
            using (var context = new StudentDbContex())
            {
                
                var siniflar = context.Siniflar.ToList();
                cmbSinif.DataSource = siniflar;
                cmbSinif.DisplayMember = "Ad"; 
                cmbSinif.ValueMember = "Id";  
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            int numara;

            if (!int.TryParse(txtNumara.Text, out numara))
            {
                MessageBox.Show("Lütfen geçerli bir numara girin.");
                return;
            }

            int sinifId = (int)cmbSinif.SelectedValue;  // Seçilen sýnýfýn Id'si

            if (string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(soyad) || cmbSinif.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen tüm alanlarý doldurun.");
                return;
            }

            var yeniOgrenci = new Ogrenci
            {
                Ad = ad,
                Soyad = soyad,
                Numara = numara,
                SinifId = sinifId  
            };

            using (var context = new StudentDbContex())
            {
                context.Ogrenciler.Add(yeniOgrenci);
                context.SaveChanges();
            }

            LoadStudents();
            MessageBox.Show("Öðrenci baþarýyla eklendi!");
            Temizle();
        }

        private void Temizle()
        {
            txtAd.Text = string.Empty;
            txtSoyad.Text = string.Empty;
            txtNumara.Text = string.Empty;
            cmbSinif.SelectedIndex = -1;
        }

        private void LoadStudents()
        {
            using (var ctx = new StudentDbContex())
            {
                var ogrenciler = ctx.Ogrenciler
                    .Include(o => o.Sinif) // sýnýf dahil et
                    .Select(o => new
                    {
                        o.Id,
                        o.Ad,
                        o.Soyad,
                        o.Numara,
                        SinifAdi = o.Sinif.Ad // id yerine ad koydm
                    })
                    .ToList();

                datagrid.DataSource = ogrenciler;
            }
            datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

         
            datagrid.Columns["Id"].Visible = false; 
            datagrid.Columns["Ad"].HeaderText = "Ad";
            datagrid.Columns["Soyad"].HeaderText = "Soyad";
            datagrid.Columns["Numara"].HeaderText = "Numara";
            datagrid.Columns["SinifAdi"].HeaderText = "Sýnýf Adý";
        }

        private void datagrid_SelectionChanged(object sender, EventArgs e)
        {
            if (datagrid.SelectedRows.Count > 0)
            {
                var row = datagrid.SelectedRows[0];

                txtAd.Text = row.Cells["Ad"].Value?.ToString();
                txtSoyad.Text = row.Cells["Soyad"].Value?.ToString();
                txtNumara.Text = row.Cells["Numara"].Value?.ToString();

             
                string sinifAdi = row.Cells["SinifAdi"].Value?.ToString();
                cmbSinif.SelectedIndex = cmbSinif.FindStringExact(sinifAdi);

                selectedOgrenciId = Convert.ToInt32(row.Cells["Id"].Value);
            }
            else
            {
                Temizle();
            }
        }

        private void btndzn_Click(object sender, EventArgs e)
        {
            if (selectedOgrenciId == -1)
            {
                MessageBox.Show("Lütfen bir öðrenci seçin.");
                return;
            }

            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            int numara;

            if (!int.TryParse(txtNumara.Text, out numara))
            {
                MessageBox.Show("Lütfen geçerli bir numara girin.");
                return;
            }

            int sinifId = (int)cmbSinif.SelectedValue; 

            if (string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(soyad) || cmbSinif.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen tüm alanlarý doldurun.");
                return;
            }

            using (var context = new StudentDbContex())
            {
                var ogrenci = context.Ogrenciler.FirstOrDefault(o => o.Id == selectedOgrenciId);

                if (ogrenci != null)
                {
                    ogrenci.Ad = ad;
                    ogrenci.Soyad = soyad;
                    ogrenci.Numara = numara;
                    ogrenci.SinifId = sinifId;

                    context.SaveChanges();
                    MessageBox.Show("Öðrenci baþarýyla güncellendi");

                    LoadStudents();
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Seçilen öðrenci bulunamadý");
                }
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (selectedOgrenciId == -1)
            {
                MessageBox.Show("Lütfen bir öðrenci seçin");
                return;
            }

            var result = MessageBox.Show("Seçilen öðrenciyi silmek istiyormusun", "Silinsin mi ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                using (var context = new StudentDbContex())
                {
                    var ogrenci = context.Ogrenciler.FirstOrDefault(o => o.Id == selectedOgrenciId);

                    if (ogrenci != null)
                    {
                        context.Ogrenciler.Remove(ogrenci);
                        context.SaveChanges();
                        MessageBox.Show("Öðrenci baþarýyla silindi");

                        LoadStudents();
                        Temizle();
                    }
                    else
                    {
                        MessageBox.Show("Seçilen öðrenci bulunamadý");
                    }
                }
            }
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            Temizle();
            selectedOgrenciId = -1;
        }

        private void Getir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(idgirbox.Text))
            {
                MessageBox.Show("Lütfen bir Öðrenci Numarasý girin.");
                return;
            }

            int id;
            if (!int.TryParse(idgirbox.Text, out id))
            {
                MessageBox.Show("Lütfen geçerli bir  Öðrenci Numarasý girin.");
                return;
            }

            using (var context = new StudentDbContex())
            {
                var ogrenci = context.Ogrenciler.FirstOrDefault(o => o.Numara == id);

                if (ogrenci != null)
                {
                    txtAd.Text = ogrenci.Ad;
                    txtSoyad.Text = ogrenci.Soyad;
                    txtNumara.Text = ogrenci.Numara.ToString();

                    cmbSinif.SelectedValue = ogrenci.SinifId;
                    selectedOgrenciId = ogrenci.Id;
                }
                else
                {
                    MessageBox.Show("Girilen ID'ye ait öðrenci bulunamadý.");
                    idgirbox.Text = string.Empty;
                    Temizle();
                }
            }
        }

        private void ogrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgrKayýt ogrk = new OgrKayýt();
            ogrk.Show();

        }

        private void sýnýflarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SinifForm sinif = new SinifForm();
            sinif.Show();

        }

        private void derslerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DersForm ders = new DersForm();
            ders.Show();
        }

    
        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedOgrenciId == -1)
            {
                MessageBox.Show("Lütfen bir öðrenci seçin.");
                return;
            }

            var ogrDersEkleForm = new OgrDersEkle(selectedOgrenciId);
            ogrDersEkleForm.ShowDialog();
        }
    
    }
}
