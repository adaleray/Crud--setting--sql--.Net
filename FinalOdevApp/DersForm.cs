using System;
using System.Linq;
using System.Windows.Forms;
using ErayApp.Models; 

namespace FinalOdevApp
{
    public class DersForm : Form
    {
        private int selectedDersId = -1; 

        public DersForm()
        {
            InitializeComponent();
            LoadDersler();
        }

        
        private void LoadDersler()
        {
            using (var context = new StudentDbContex())
            {
                var dersler = context.Dersler.ToList(); 
                dataGridView1.DataSource = dersler; 
            }
        }

    
        private void btnekle_Click(object sender, EventArgs e)
        {
            string ad = derstextbox.Text;

            if (string.IsNullOrEmpty(ad))
            {
                MessageBox.Show("Lütfen ders adı girin.");
                return;
            }

            var yeniDers = new Ders
            {
                Ad = ad
            };

            using (var context = new StudentDbContex())
            {
                context.Dersler.Add(yeniDers);
                context.SaveChanges();
            }

            LoadDersler();
            MessageBox.Show("Ders başarıyla eklendi.");
        }

        
        private void btnsil_Click(object sender, EventArgs e)
        {
            if (selectedDersId == -1)
            {
                MessageBox.Show("Lütfen silmek istediğiniz dersi seçin.");
                return;
            }

            using (var context = new StudentDbContex())
            {
                var ders = context.Dersler.FirstOrDefault(d => d.Id == selectedDersId);
                if (ders != null)
                {
                    context.Dersler.Remove(ders);
                    context.SaveChanges();
                    MessageBox.Show("Ders başarıyla silindi.");
                    LoadDersler();
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Ders bulunamadı.");
                }
            }
        }

     
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedDersId == -1)
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz dersi seçin.");
                return;
            }

            string ad = derstextbox.Text;

            if (string.IsNullOrEmpty(ad))
            {
                MessageBox.Show("Lütfen ders adı girin.");
                return;
            }

            using (var context = new StudentDbContex())
            {
                var ders = context.Dersler.FirstOrDefault(d => d.Id == selectedDersId);
                if (ders != null)
                {
                    ders.Ad = ad;
                    context.SaveChanges();
                    MessageBox.Show("Ders başarıyla güncellendi.");
                    LoadDersler();
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Ders bulunamadı.");
                }
            }
        }

      //satır
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];

               
                derstextbox.Text = row.Cells["Ad"].Value?.ToString(); 

               
                selectedDersId = Convert.ToInt32(row.Cells["Id"].Value);
            }
            else
            {
               
                Temizle();
            }
        }

      
        private void Temizle()
        {
          
            derstextbox.Text = string.Empty;

           
            selectedDersId = -1;
        }

        private void DersForm_Load(object sender, EventArgs e)
        {

        }
    }
}
