namespace FinalOdevApp
{
    partial class SinifForm
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
            btnekle = new Button();
            siniftextbox = new TextBox();
            kontejyantextbox = new TextBox();
            btnUpdate = new Button();
            dataGridView1 = new DataGridView();
            Sınıf = new Label();
            label2 = new Label();
            btnsil = new Button();
            ogrgetirbuton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnekle
            // 
            btnekle.BackColor = Color.FromArgb(128, 255, 128);
            btnekle.Location = new Point(288, 65);
            btnekle.Name = "btnekle";
            btnekle.Size = new Size(94, 29);
            btnekle.TabIndex = 0;
            btnekle.Text = "Ekle";
            btnekle.UseVisualStyleBackColor = false;
            btnekle.Click += btnekle_Click;
            // 
            // siniftextbox
            // 
            siniftextbox.Location = new Point(105, 37);
            siniftextbox.Name = "siniftextbox";
            siniftextbox.Size = new Size(125, 27);
            siniftextbox.TabIndex = 1;
            // 
            // kontejyantextbox
            // 
            kontejyantextbox.Location = new Point(105, 92);
            kontejyantextbox.Name = "kontejyantextbox";
            kontejyantextbox.Size = new Size(125, 27);
            kontejyantextbox.TabIndex = 2;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Yellow;
            btnUpdate.Location = new Point(499, 65);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 175);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(581, 153);
            dataGridView1.TabIndex = 4;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // Sınıf
            // 
            Sınıf.AutoSize = true;
            Sınıf.Location = new Point(15, 37);
            Sınıf.Name = "Sınıf";
            Sınıf.Size = new Size(64, 20);
            Sınıf.TabIndex = 5;
            Sınıf.Text = "Sınıf Ad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 99);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 6;
            label2.Text = "Kontejyan";
            // 
            // btnsil
            // 
            btnsil.BackColor = Color.Red;
            btnsil.Location = new Point(397, 65);
            btnsil.Name = "btnsil";
            btnsil.Size = new Size(94, 29);
            btnsil.TabIndex = 7;
            btnsil.Text = "Sil";
            btnsil.UseVisualStyleBackColor = false;
            btnsil.Click += btnsil_Click;
            // 
            // ogrgetirbuton
            // 
            ogrgetirbuton.Location = new Point(380, 115);
            ogrgetirbuton.Name = "ogrgetirbuton";
            ogrgetirbuton.Size = new Size(138, 29);
            ogrgetirbuton.TabIndex = 8;
            ogrgetirbuton.Text = "Öğrenci Getir";
            ogrgetirbuton.UseVisualStyleBackColor = true;
            ogrgetirbuton.Click += ogrgetirbuton_Click;
            // 
            // SinifForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(605, 336);
            Controls.Add(ogrgetirbuton);
            Controls.Add(btnsil);
            Controls.Add(label2);
            Controls.Add(Sınıf);
            Controls.Add(dataGridView1);
            Controls.Add(btnUpdate);
            Controls.Add(kontejyantextbox);
            Controls.Add(siniftextbox);
            Controls.Add(btnekle);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "SinifForm";
            Text = "SinifForm";
            Load += SinifForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnekle;
        private TextBox siniftextbox;
        private TextBox kontejyantextbox;
        private Button btnUpdate;
        private DataGridView dataGridView1;
        private Label Sınıf;
        private Label label2;
        private Button btnsil;
        private Button ogrgetirbuton;
    }
}