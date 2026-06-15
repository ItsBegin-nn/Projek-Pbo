namespace Projek_PBO.Views
{
    partial class KelolaKebun
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            LbNama = new Label();
            TbNama = new TextBox();
            TbLokasi = new TextBox();
            TbLuas = new TextBox();
            LbLokasi = new Label();
            LbLuas = new Label();
            BtnSimpan = new Button();
            BtnHapus = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // LbNama
            // 
            LbNama.AutoSize = true;
            LbNama.BackColor = Color.Transparent;
            LbNama.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbNama.ForeColor = Color.Transparent;
            LbNama.Location = new Point(94, 120);
            LbNama.Name = "LbNama";
            LbNama.Size = new Size(52, 21);
            LbNama.TabIndex = 0;
            LbNama.Text = "Nama";
            LbNama.Click += label1_Click;
            // 
            // TbNama
            // 
            TbNama.Location = new Point(94, 143);
            TbNama.Name = "TbNama";
            TbNama.Size = new Size(176, 27);
            TbNama.TabIndex = 1;
            // 
            // TbLokasi
            // 
            TbLokasi.Location = new Point(328, 143);
            TbLokasi.Name = "TbLokasi";
            TbLokasi.Size = new Size(173, 27);
            TbLokasi.TabIndex = 2;
            TbLokasi.TextChanged += textBox2_TextChanged;
            // 
            // TbLuas
            // 
            TbLuas.Location = new Point(558, 143);
            TbLuas.Name = "TbLuas";
            TbLuas.Size = new Size(173, 27);
            TbLuas.TabIndex = 3;
            // 
            // LbLokasi
            // 
            LbLokasi.AutoSize = true;
            LbLokasi.BackColor = Color.Transparent;
            LbLokasi.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbLokasi.ForeColor = Color.White;
            LbLokasi.Location = new Point(328, 120);
            LbLokasi.Name = "LbLokasi";
            LbLokasi.Size = new Size(56, 21);
            LbLokasi.TabIndex = 4;
            LbLokasi.Text = "Lokasi";
            // 
            // LbLuas
            // 
            LbLuas.AutoSize = true;
            LbLuas.BackColor = Color.Transparent;
            LbLuas.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbLuas.ForeColor = Color.White;
            LbLuas.Location = new Point(558, 120);
            LbLuas.Name = "LbLuas";
            LbLuas.Size = new Size(96, 21);
            LbLuas.TabIndex = 5;
            LbLuas.Text = "Luas Kebun";
            LbLuas.Click += Petani_Click;
            // 
            // BtnSimpan
            // 
            BtnSimpan.BackColor = Color.Chartreuse;
            BtnSimpan.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSimpan.ForeColor = Color.Red;
            BtnSimpan.Location = new Point(637, 268);
            BtnSimpan.Name = "BtnSimpan";
            BtnSimpan.Size = new Size(94, 29);
            BtnSimpan.TabIndex = 6;
            BtnSimpan.Text = "Simpan";
            BtnSimpan.UseVisualStyleBackColor = false;
            // 
            // BtnHapus
            // 
            BtnHapus.BackColor = Color.Red;
            BtnHapus.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnHapus.ForeColor = Color.Chartreuse;
            BtnHapus.Location = new Point(518, 268);
            BtnHapus.Name = "BtnHapus";
            BtnHapus.Size = new Size(94, 29);
            BtnHapus.TabIndex = 7;
            BtnHapus.Text = "Hapus";
            BtnHapus.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(16, 315);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(829, 351);
            dataGridView1.TabIndex = 8;
            // 
            // KelolaKebun
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(BtnHapus);
            Controls.Add(BtnSimpan);
            Controls.Add(LbLuas);
            Controls.Add(LbLokasi);
            Controls.Add(TbLuas);
            Controls.Add(TbLokasi);
            Controls.Add(TbNama);
            Controls.Add(LbNama);
            Name = "KelolaKebun";
            Size = new Size(866, 681);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label LbNama;
        private TextBox TbNama;
        private TextBox TbLokasi;
        private TextBox TbLuas;
        private Label LbLokasi;
        private Label LbLuas;
        private Button BtnSimpan;
        private Button BtnHapus;
        private DataGridView dataGridView1;
    }
}