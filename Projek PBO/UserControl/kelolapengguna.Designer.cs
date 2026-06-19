namespace Projek_PBO.Views
{
    partial class KelolaPengguna
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KelolaPengguna));
            Tbnama = new TextBox();
            Tbpass = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            Tbuser = new TextBox();
            comboBox1 = new ComboBox();
            BtnSimpan = new Button();
            dataGridView1 = new DataGridView();
            BtnHapus = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Tbnama
            // 
            Tbnama.Location = new Point(105, 168);
            Tbnama.Name = "Tbnama";
            Tbnama.Size = new Size(160, 27);
            Tbnama.TabIndex = 0;
            // 
            // Tbpass
            // 
            Tbpass.Location = new Point(370, 168);
            Tbpass.Name = "Tbpass";
            Tbpass.Size = new Size(159, 27);
            Tbpass.TabIndex = 1;
            Tbpass.TextChanged += textBox2_TextChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // Tbuser
            // 
            Tbuser.Location = new Point(105, 245);
            Tbuser.Name = "Tbuser";
            Tbuser.Size = new Size(160, 27);
            Tbuser.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(370, 244);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(159, 28);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // BtnSimpan
            // 
            BtnSimpan.BackColor = Color.Chartreuse;
            BtnSimpan.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSimpan.ForeColor = Color.Red;
            BtnSimpan.Location = new Point(587, 299);
            BtnSimpan.Name = "BtnSimpan";
            BtnSimpan.Size = new Size(94, 29);
            BtnSimpan.TabIndex = 8;
            BtnSimpan.Text = "Simpan";
            BtnSimpan.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(16, 377);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(848, 292);
            dataGridView1.TabIndex = 9;
            // 
            // BtnHapus
            // 
            BtnHapus.BackColor = Color.Red;
            BtnHapus.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnHapus.ForeColor = Color.Chartreuse;
            BtnHapus.Location = new Point(487, 299);
            BtnHapus.Name = "BtnHapus";
            BtnHapus.Size = new Size(94, 29);
            BtnHapus.TabIndex = 10;
            BtnHapus.Text = "Hapus";
            BtnHapus.UseVisualStyleBackColor = false;
            BtnHapus.Click += BtnHapus_Click;
            // 
            // KelolaPengguna
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            Controls.Add(BtnHapus);
            Controls.Add(dataGridView1);
            Controls.Add(BtnSimpan);
            Controls.Add(comboBox1);
            Controls.Add(Tbuser);
            Controls.Add(Tbpass);
            Controls.Add(Tbnama);
            Name = "KelolaPengguna";
            Size = new Size(880, 686);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        private TextBox Tbnama;
        private TextBox Tbpass;
        private ContextMenuStrip contextMenuStrip1;
        private Label Lbpass;
        private Label Lbnama;
        private TextBox textBox3;
        private Label LbUsername;
        private TextBox Tbuser;
        private ComboBox comboBox1;
        private Label LbRole;
        private Button BtnSimpan;
        private DataGridView dataGridView1;
        private Button BtnHapus;
    }
}