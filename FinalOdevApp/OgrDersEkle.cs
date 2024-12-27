using ErayApp.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace FinalOdevApp
{
    public partial class OgrDersEkle : Form
    {
        private int ogrenciId;

        public OgrDersEkle(int ogrenciId)
        {
            InitializeComponent();
            this.ogrenciId = ogrenciId;
            LoadOgrenciBilgileri();
            LoadOgrenciDersleri();
            LoadUygunDersler();
        }

        private void LoadOgrenciBilgileri()
        {
            using (var context = new StudentDbContex())
            {
                var ogrenci = context.Ogrenciler.FirstOrDefault(o => o.Id == ogrenciId);

                if (ogrenci != null)
                {
                    lblAd.Text = ogrenci.Ad;
                    lblSoyad.Text = ogrenci.Soyad;
                    lblNumara.Text = ogrenci.Numara.ToString();
                }
                else
                {
                    MessageBox.Show("Öğrenci bulunamadı.");
                    this.Close();
                }
            }
        }

       
        private void LoadOgrenciDersleri()
        {
            using (var context = new StudentDbContex())
            {
                var alinanDersler = context.OgrenciDersler
                    .Where(od => od.OgrenciId == ogrenciId)
                    .Select(od => new
                    {
                        DersAdi = od.Ders.Ad,
                        DersId = od.Ders.Id
                    })
                    .ToList();

                dgvAlinanDersler.DataSource = alinanDersler; 

            }
            dgvAlinanDersler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvAlinanDersler.Columns["DersId"].Visible = false;
        }


        private void LoadUygunDersler()
        {
            using (var context = new StudentDbContex())
            {
                var alinanDersIds = context.OgrenciDersler
                    .Where(od => od.OgrenciId == ogrenciId)
                    .Select(od => od.DersId)
                    .ToList();

                var uygunDersler = context.Dersler
                    .Where(d => !alinanDersIds.Contains(d.Id))
                    .ToList();

                listBoxDersler.DataSource = uygunDersler;
                listBoxDersler.DisplayMember = "Ad";
                listBoxDersler.ValueMember = "Id";
            }
        }

        
        private void btnEkle_Click(object sender, EventArgs e)
        {
            var selectedDersler = listBoxDersler.SelectedItems.Cast<Ders>().ToList();

            if (selectedDersler.Count == 0)
            {
                MessageBox.Show("Lütfen en az bir ders seçin.");
                return;
            }

            using (var context = new StudentDbContex())
            {
                foreach (var ders in selectedDersler)
                {
                   
                    bool alreadyExists = context.OgrenciDersler
                        .Any(od => od.OgrenciId == ogrenciId && od.DersId == ders.Id);

                    if (alreadyExists)
                    {
                        MessageBox.Show($"'{ders.Ad}' dersini zaten alıyorsunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        continue;
                    }

                    var ogrenciDers = new OgrenciDers
                    {
                        OgrenciId = ogrenciId,
                        DersId = ders.Id
                    };

                    context.OgrenciDersler.Add(ogrenciDers);
                }

                context.SaveChanges();
            }

            MessageBox.Show("Dersler başarıyla eklendi.");
            LoadOgrenciDersleri(); 
            LoadUygunDersler();   
        }

       
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvAlinanDersler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OgrDersEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
