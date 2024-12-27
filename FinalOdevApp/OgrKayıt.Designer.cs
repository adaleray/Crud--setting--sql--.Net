namespace FinalOdevApp
{
    partial class OgrKayıt
    {
        /// <summary>
        /// Gerekli tasarım değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Kullanılan kaynakları temizle.
        /// </summary>
        /// <param name="disposing">Yönetilen kaynakları serbest bırakmak için true; aksi halde false.</param>
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
        /// Tasarımcı desteği için gereken metot.
        /// Bu yöntemin içeriğini kod düzenleyicisiyle değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            lblAd = new Label();
            lblSoyad = new Label();
            lblNumara = new Label();
            lblSinif = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtNumara = new TextBox();
            cmbSinif = new ComboBox();
            datagrid = new DataGridView();
            btnEkle = new Button();
            btnsil = new Button();
            btndzn = new Button();
            btntemizle = new Button();
            Getir = new Button();
            idgirbox = new TextBox();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            sınıflarToolStripMenuItem = new ToolStripMenuItem();
            derslerToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)datagrid).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(34, 40);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(31, 20);
            lblAd.TabIndex = 0;
            lblAd.Text = "Ad:";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(341, 39);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(53, 20);
            lblSoyad.TabIndex = 1;
            lblSoyad.Text = "Soyad:";
            // 
            // lblNumara
            // 
            lblNumara.AutoSize = true;
            lblNumara.Location = new Point(34, 111);
            lblNumara.Name = "lblNumara";
            lblNumara.Size = new Size(65, 20);
            lblNumara.TabIndex = 2;
            lblNumara.Text = "Numara:";
            // 
            // lblSinif
            // 
            lblSinif.AutoSize = true;
            lblSinif.Location = new Point(341, 118);
            lblSinif.Name = "lblSinif";
            lblSinif.Size = new Size(41, 20);
            lblSinif.TabIndex = 3;
            lblSinif.Text = "Sınıf:";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(114, 36);
            txtAd.Margin = new Padding(3, 4, 3, 4);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(171, 27);
            txtAd.TabIndex = 4;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(424, 33);
            txtSoyad.Margin = new Padding(3, 4, 3, 4);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(171, 27);
            txtSoyad.TabIndex = 5;
            // 
            // txtNumara
            // 
            txtNumara.Location = new Point(114, 111);
            txtNumara.Margin = new Padding(3, 4, 3, 4);
            txtNumara.Name = "txtNumara";
            txtNumara.Size = new Size(171, 27);
            txtNumara.TabIndex = 6;
            // 
            // cmbSinif
            // 
            cmbSinif.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSinif.FormattingEnabled = true;
            cmbSinif.Location = new Point(424, 111);
            cmbSinif.Margin = new Padding(3, 4, 3, 4);
            cmbSinif.Name = "cmbSinif";
            cmbSinif.Size = new Size(171, 28);
            cmbSinif.TabIndex = 7;
            // 
            // datagrid
            // 
            datagrid.BackgroundColor = SystemColors.ButtonFace;
            datagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagrid.Location = new Point(12, 322);
            datagrid.Name = "datagrid";
            datagrid.RowHeadersWidth = 51;
            datagrid.Size = new Size(741, 188);
            datagrid.TabIndex = 9;
            datagrid.SelectionChanged += datagrid_SelectionChanged;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.Lime;
            btnEkle.Location = new Point(254, 188);
            btnEkle.Margin = new Padding(3, 4, 3, 4);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(171, 40);
            btnEkle.TabIndex = 8;
            btnEkle.Text = "Öğrenci Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnsil
            // 
            btnsil.BackColor = Color.Red;
            btnsil.Location = new Point(114, 188);
            btnsil.Name = "btnsil";
            btnsil.Size = new Size(118, 40);
            btnsil.TabIndex = 10;
            btnsil.Text = "Sil";
            btnsil.UseVisualStyleBackColor = false;
            btnsil.Click += btnsil_Click;
            // 
            // btndzn
            // 
            btndzn.BackColor = Color.FromArgb(128, 255, 255);
            btndzn.Location = new Point(472, 188);
            btndzn.Name = "btndzn";
            btndzn.Size = new Size(123, 35);
            btndzn.TabIndex = 11;
            btndzn.Text = "Güncelle";
            btndzn.UseVisualStyleBackColor = false;
            btndzn.Click += btndzn_Click;
            // 
            // btntemizle
            // 
            btntemizle.BackColor = Color.Chartreuse;
            btntemizle.Location = new Point(636, 75);
            btntemizle.Name = "btntemizle";
            btntemizle.Size = new Size(75, 29);
            btntemizle.TabIndex = 12;
            btntemizle.Text = "Temizle";
            btntemizle.UseVisualStyleBackColor = false;
            btntemizle.Click += btntemizle_Click;
            // 
            // Getir
            // 
            Getir.BackColor = Color.FromArgb(255, 128, 255);
            Getir.Location = new Point(314, 265);
            Getir.Name = "Getir";
            Getir.Size = new Size(94, 29);
            Getir.TabIndex = 13;
            Getir.Text = "Bul";
            Getir.UseVisualStyleBackColor = false;
            Getir.Click += Getir_Click;
            // 
            // idgirbox
            // 
            idgirbox.Location = new Point(146, 262);
            idgirbox.Name = "idgirbox";
            idgirbox.Size = new Size(125, 27);
            idgirbox.TabIndex = 14;
    
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 265);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 15;
            label1.Text = "Numara Gir :";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { sınıflarToolStripMenuItem, derslerToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(765, 28);
            menuStrip1.TabIndex = 16;
            menuStrip1.Text = "menuStrip1";
            // 
            // sınıflarToolStripMenuItem
            // 
            sınıflarToolStripMenuItem.Name = "sınıflarToolStripMenuItem";
            sınıflarToolStripMenuItem.Size = new Size(69, 24);
            sınıflarToolStripMenuItem.Text = "Sınıflar";
            sınıflarToolStripMenuItem.Click += sınıflarToolStripMenuItem_Click;
            // 
            // derslerToolStripMenuItem
            // 
            derslerToolStripMenuItem.Name = "derslerToolStripMenuItem";
            derslerToolStripMenuItem.Size = new Size(70, 24);
            derslerToolStripMenuItem.Text = "Dersler";
            derslerToolStripMenuItem.Click += derslerToolStripMenuItem_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(485, 265);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 17;
            button1.Text = "Ders Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // OgrKayıt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 0);
            ClientSize = new Size(765, 522);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(idgirbox);
            Controls.Add(Getir);
            Controls.Add(btntemizle);
            Controls.Add(btndzn);
            Controls.Add(btnsil);
            Controls.Add(datagrid);
            Controls.Add(btnEkle);
            Controls.Add(cmbSinif);
            Controls.Add(txtNumara);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(lblSinif);
            Controls.Add(lblNumara);
            Controls.Add(lblSoyad);
            Controls.Add(lblAd);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "OgrKayıt";
            Text = "Öğrenci Ekle";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)datagrid).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblNumara;
        private System.Windows.Forms.Label lblSinif;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtNumara;
        private System.Windows.Forms.ComboBox cmbSinif;
        private DataGridView datagrid;
        private Button btnEkle;
        private Button btnsil;
        private Button btndzn;
        private Button btntemizle;
        private Button Getir;
        private TextBox idgirbox;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem sınıflarToolStripMenuItem;
        private ToolStripMenuItem derslerToolStripMenuItem;
        private Button button1;
    }
}
