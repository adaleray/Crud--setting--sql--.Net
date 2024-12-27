namespace FinalOdevApp
{
    partial class OgrDersEkle
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblAdLabel = new Label();
            lblSoyadLabel = new Label();
            lblNumaraLabel = new Label();
            lblAd = new Label();
            lblSoyad = new Label();
            lblNumara = new Label();
            listBoxDersler = new ListBox();
            btnEkle = new Button();
            btnCancel = new Button();
            lblAlinanDersler = new Label();
            dgvAlinanDersler = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvAlinanDersler).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(64, 0, 0);
            lblTitle.Location = new Point(14, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(251, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Öğrenci Ders Ekleme";
            // 
            // lblAdLabel
            // 
            lblAdLabel.AutoSize = true;
            lblAdLabel.Location = new Point(14, 67);
            lblAdLabel.Name = "lblAdLabel";
            lblAdLabel.Size = new Size(31, 20);
            lblAdLabel.TabIndex = 1;
            lblAdLabel.Text = "Ad:";
            // 
            // lblSoyadLabel
            // 
            lblSoyadLabel.AutoSize = true;
            lblSoyadLabel.Location = new Point(14, 100);
            lblSoyadLabel.Name = "lblSoyadLabel";
            lblSoyadLabel.Size = new Size(53, 20);
            lblSoyadLabel.TabIndex = 2;
            lblSoyadLabel.Text = "Soyad:";
            // 
            // lblNumaraLabel
            // 
            lblNumaraLabel.AutoSize = true;
            lblNumaraLabel.Location = new Point(14, 133);
            lblNumaraLabel.Name = "lblNumaraLabel";
            lblNumaraLabel.Size = new Size(65, 20);
            lblNumaraLabel.TabIndex = 3;
            lblNumaraLabel.Text = "Numara:";
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(86, 67);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(15, 20);
            lblAd.TabIndex = 4;
            lblAd.Text = "-";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(86, 100);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(15, 20);
            lblSoyad.TabIndex = 5;
            lblSoyad.Text = "-";
            // 
            // lblNumara
            // 
            lblNumara.AutoSize = true;
            lblNumara.Location = new Point(86, 133);
            lblNumara.Name = "lblNumara";
            lblNumara.Size = new Size(15, 20);
            lblNumara.TabIndex = 6;
            lblNumara.Text = "-";
            // 
            // listBoxDersler
            // 
            listBoxDersler.FormattingEnabled = true;
            listBoxDersler.Location = new Point(17, 173);
            listBoxDersler.Margin = new Padding(3, 4, 3, 4);
            listBoxDersler.Name = "listBoxDersler";
            listBoxDersler.SelectionMode = SelectionMode.MultiExtended;
            listBoxDersler.Size = new Size(228, 124);
            listBoxDersler.TabIndex = 7;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.Lime;
            btnEkle.Location = new Point(17, 320);
            btnEkle.Margin = new Padding(3, 4, 3, 4);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(86, 31);
            btnEkle.TabIndex = 8;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.Location = new Point(160, 320);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(86, 31);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "İptal";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblAlinanDersler
            // 
            lblAlinanDersler.AutoSize = true;
            lblAlinanDersler.Location = new Point(260, 67);
            lblAlinanDersler.Name = "lblAlinanDersler";
            lblAlinanDersler.Size = new Size(105, 20);
            lblAlinanDersler.TabIndex = 10;
            lblAlinanDersler.Text = "Alınan Dersler:";
            lblAlinanDersler.TextAlign = ContentAlignment.TopRight;
            // 
            // dgvAlinanDersler
            // 
            dgvAlinanDersler.BackgroundColor = Color.White;
            dgvAlinanDersler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlinanDersler.Location = new Point(260, 100);
            dgvAlinanDersler.Name = "dgvAlinanDersler";
            dgvAlinanDersler.RowHeadersWidth = 51;
            dgvAlinanDersler.Size = new Size(215, 251);
            dgvAlinanDersler.TabIndex = 11;
            dgvAlinanDersler.CellContentClick += dgvAlinanDersler_CellContentClick;
            // 
            // OgrDersEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(503, 379);
            Controls.Add(btnCancel);
            Controls.Add(btnEkle);
            Controls.Add(listBoxDersler);
            Controls.Add(lblNumara);
            Controls.Add(lblSoyad);
            Controls.Add(lblAd);
            Controls.Add(lblNumaraLabel);
            Controls.Add(lblSoyadLabel);
            Controls.Add(lblAdLabel);
            Controls.Add(lblTitle);
            Controls.Add(lblAlinanDersler);
            Controls.Add(dgvAlinanDersler);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "OgrDersEkle";
            Text = "Öğrenci Ders Ekle";
            Load += OgrDersEkle_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAlinanDersler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion
        private System.Windows.Forms.ListBox listBoxAlinanDersler;
        private System.Windows.Forms.Label lblAlinanDersler;
        private System.Windows.Forms.DataGridView dgvAlinanDersler;


        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAdLabel;
        private System.Windows.Forms.Label lblSoyadLabel;
        private System.Windows.Forms.Label lblNumaraLabel;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblNumara;
        private System.Windows.Forms.ListBox listBoxDersler;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnCancel;
    }
}
