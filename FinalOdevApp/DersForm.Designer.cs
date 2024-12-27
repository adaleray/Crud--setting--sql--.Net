namespace FinalOdevApp
{
    partial class DersForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnekle;
        private TextBox derstextbox;
        private Button btnUpdate;
        private DataGridView dataGridView1;
        private Label labelDers;
        private Button btnsil;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnekle = new Button();
            derstextbox = new TextBox();
            btnUpdate = new Button();
            dataGridView1 = new DataGridView();
            labelDers = new Label();
            btnsil = new Button();
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
            // derstextbox
            // 
            derstextbox.Location = new Point(101, 67);
            derstextbox.Name = "derstextbox";
            derstextbox.Size = new Size(125, 27);
            derstextbox.TabIndex = 1;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Yellow;
            btnUpdate.Location = new Point(499, 65);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 2;
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
            dataGridView1.TabIndex = 3;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // labelDers
            // 
            labelDers.AutoSize = true;
            labelDers.Location = new Point(12, 69);
            labelDers.Name = "labelDers";
            labelDers.Size = new Size(65, 20);
            labelDers.TabIndex = 4;
            labelDers.Text = "Ders Ad:";
            // 
            // btnsil
            // 
            btnsil.BackColor = Color.Red;
            btnsil.Location = new Point(397, 65);
            btnsil.Name = "btnsil";
            btnsil.Size = new Size(94, 29);
            btnsil.TabIndex = 5;
            btnsil.Text = "Sil";
            btnsil.UseVisualStyleBackColor = false;
            btnsil.Click += btnsil_Click;
            // 
            // DersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(605, 336);
            Controls.Add(btnsil);
            Controls.Add(labelDers);
            Controls.Add(dataGridView1);
            Controls.Add(btnUpdate);
            Controls.Add(derstextbox);
            Controls.Add(btnekle);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "DersForm";
            Text = "DersForm";
            Load += DersForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
