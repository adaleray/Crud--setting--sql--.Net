using System;
using System.Linq;
using System.Windows.Forms;
using ErayApp.Models;  

namespace FinalOdevApp
{
    public partial class SinifForm : Form
    {
        private int selectedSinifId = -1;  

        public SinifForm()
        {
            InitializeComponent();
            LoadSiniflar();
        }
        private void LoadSiniflar()
        {
            using (var context = new StudentDbContex())
            {
               
                var siniflar = context.Siniflar
                                    .Select(s => new
                                    {
                                        s.Id,
                                        s.Ad,
                                        s.Kontenjan
                                    })
                                    .ToList();

          
                dataGridView1.DataSource = siniflar;
            }
            dataGridView1.AutoSizeColumnsMode= DataGridViewAutoSizeColumnsMode.Fill;
        }


       
        private void btnekle_Click(object sender, EventArgs e)
        {
            string ad = siniftextbox.Text;
            int kontenjan;

            if (!int.TryParse(kontejyantextbox.Text, out kontenjan))
            {
                MessageBox.Show("Lütfen geçerli bir kontenjan girin.");
                return;
            }

            if (string.IsNullOrEmpty(ad) || kontenjan <= 0)
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            var yeniSinif = new Sinif
            {
                Ad = ad,
                Kontenjan = kontenjan
            };

            using (var context = new StudentDbContex())
            {
                context.Siniflar.Add(yeniSinif);
                context.SaveChanges();
            }

            LoadSiniflar();
            MessageBox.Show("Sınıf başarıyla eklendi.");
        }

        
        private void btnsil_Click(object sender, EventArgs e)
        {
            if (selectedSinifId == -1)
            {
                MessageBox.Show("Lütfen silmek istediğiniz sınıfı seçin.");
                return;
            }

            using (var context = new StudentDbContex())
            {
                var sinif = context.Siniflar.FirstOrDefault(s => s.Id == selectedSinifId);
                if (sinif != null)
                {
                    // ogr kontrol
                    var ogrenciler = context.Ogrenciler.Where(o => o.SinifId == sinif.Id).ToList();
                    if (ogrenciler.Any())
                    {
                        MessageBox.Show("Bu sınıfta öğrenciler mevcut, sınıfı silemezsiniz.");
                        return;
                    }

                   
                    context.Siniflar.Remove(sinif);
                    context.SaveChanges();
                    MessageBox.Show("Sınıf başarıyla silindi.");
                    LoadSiniflar();
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Sınıf bulunamadı.");
                }
            }
        }

   
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedSinifId == -1)
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz sınıfı seçin.");
                return;
            }

            string ad = siniftextbox.Text;
            int kontenjan;

            if (!int.TryParse(kontejyantextbox.Text, out kontenjan))
            {
                MessageBox.Show("Lütfen geçerli bir kontenjan girin.");
                return;
            }

            if (string.IsNullOrEmpty(ad) || kontenjan <= 0)
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            using (var context = new StudentDbContex())
            {
                var sinif = context.Siniflar.FirstOrDefault(s => s.Id == selectedSinifId);
                if (sinif != null)
                {
                    sinif.Ad = ad;
                    sinif.Kontenjan = kontenjan;
                    context.SaveChanges();
                    MessageBox.Show("Sınıf başarıyla güncellendi.");
                    LoadSiniflar();
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Sınıf bulunamadı.");
                }
            }
        }

  

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
          
            if (dataGridView1.SelectedRows.Count > 0)
            {
              
                var row = dataGridView1.SelectedRows[0];

              
                siniftextbox.Text = row.Cells["Ad"].Value?.ToString();  
                kontejyantextbox.Text = row.Cells["Kontenjan"].Value?.ToString();  

                
                selectedSinifId = Convert.ToInt32(row.Cells["Id"].Value);
            }
            else
            {
               
                Temizle();
            }
        }


        private void Temizle()
        {
           
            siniftextbox.Text = string.Empty;
            kontejyantextbox.Text = string.Empty;
            selectedSinifId = -1;
        }

        private void SinifForm_Load(object sender, EventArgs e)
        {

        }

        private void ogrgetirbuton_Click(object sender, EventArgs e)
        {
           
            if (selectedSinifId == -1)
            {
                MessageBox.Show("Lütfen bir sınıf seçin.");
                return;
            }

            using (var context = new StudentDbContex())
            {
                var ogrenciler = context.Ogrenciler
                                        .Where(o => o.SinifId == selectedSinifId)
                                        .ToList();

             // ogr uyarı
                if (ogrenciler.Count == 0)
                {
                    MessageBox.Show("Bu sınıfta öğrenci bulunmamaktadır.");
                    return;
                }

                
                string ogrenciBilgileri = "";
                foreach (var ogrenci in ogrenciler)
                {
                    ogrenciBilgileri += $"Ad: {ogrenci.Ad}, Soyad: {ogrenci.Soyad}, Numara: {ogrenci.Numara}\n";
                }

            
                MessageBox.Show(ogrenciBilgileri, "Seçili Sınıfın Öğrencileri");
            }
        }

    }
}
