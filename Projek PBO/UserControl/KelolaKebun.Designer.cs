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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KelolaKebun));
            TbNama = new TextBox();
            TbLokasi = new TextBox();
            TbLuas = new TextBox();
            BtnSimpan = new Button();
            BtnHapus = new Button();
            dataGridView1 = new DataGridView();
            colorDialog1 = new ColorDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // TbNama
            // 
            TbNama.Location = new Point(82, 167);
            TbNama.Multiline = true;
            TbNama.Name = "TbNama";
            TbNama.Size = new Size(150, 26);
            TbNama.TabIndex = 1;
            TbNama.TextChanged += TbNama_TextChanged;
            // 
            // TbLokasi
            // 
            TbLokasi.Location = new Point(282, 166);
            TbLokasi.Multiline = true;
            TbLokasi.Name = "TbLokasi";
            TbLokasi.Size = new Size(155, 27);
            TbLokasi.TabIndex = 2;
            TbLokasi.TextChanged += textBox2_TextChanged;
            // 
            // TbLuas
            // 
            TbLuas.Location = new Point(481, 166);
            TbLuas.Multiline = true;
            TbLuas.Name = "TbLuas";
            TbLuas.Size = new Size(156, 27);
            TbLuas.TabIndex = 3;
            // 
            // BtnSimpan
            // 
            BtnSimpan.BackColor = Color.Chartreuse;
            BtnSimpan.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSimpan.ForeColor = Color.Red;
            BtnSimpan.Location = new Point(626, 243);
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
            BtnHapus.Location = new Point(520, 243);
            BtnHapus.Name = "BtnHapus";
            BtnHapus.Size = new Size(94, 29);
            BtnHapus.TabIndex = 7;
            BtnHapus.Text = "Hapus";
            BtnHapus.UseVisualStyleBackColor = false;
            BtnHapus.Click += BtnHapus_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
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
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            Controls.Add(dataGridView1);
            Controls.Add(BtnHapus);
            Controls.Add(BtnSimpan);
            Controls.Add(TbLuas);
            Controls.Add(TbLokasi);
            Controls.Add(TbNama);
            Name = "KelolaKebun";
            Size = new Size(866, 681);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private TextBox TbNama;
        private TextBox TbLokasi;
        private TextBox TbLuas;
        private Button BtnSimpan;
        private Button BtnHapus;
        private DataGridView dataGridView1;
        private ColorDialog colorDialog1;
    }
}