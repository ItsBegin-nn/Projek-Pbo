namespace Projek_PBO.Views
{
    partial class DasborAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DasborAdmin));
            dataGridView1 = new DataGridView();
            LblPengguna = new Label();
            Lblkebun = new Label();
            LblBuah = new Label();
            LblPenjualan = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(81, 373);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(622, 84);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // LblPengguna
            // 
            LblPengguna.AutoSize = true;
            LblPengguna.BackColor = Color.Transparent;
            LblPengguna.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblPengguna.Location = new Point(81, 239);
            LblPengguna.Name = "LblPengguna";
            LblPengguna.Size = new Size(35, 41);
            LblPengguna.TabIndex = 1;
            LblPengguna.Text = "5";
            // 
            // Lblkebun
            // 
            Lblkebun.AutoSize = true;
            Lblkebun.BackColor = Color.Transparent;
            Lblkebun.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lblkebun.Location = new Point(274, 239);
            Lblkebun.Name = "Lblkebun";
            Lblkebun.Size = new Size(35, 41);
            Lblkebun.TabIndex = 2;
            Lblkebun.Text = "5";
            // 
            // LblBuah
            // 
            LblBuah.AutoSize = true;
            LblBuah.BackColor = Color.Transparent;
            LblBuah.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblBuah.Location = new Point(469, 239);
            LblBuah.Name = "LblBuah";
            LblBuah.Size = new Size(35, 41);
            LblBuah.TabIndex = 3;
            LblBuah.Text = "3";
            // 
            // LblPenjualan
            // 
            LblPenjualan.AutoSize = true;
            LblPenjualan.BackColor = Color.Transparent;
            LblPenjualan.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblPenjualan.Location = new Point(634, 239);
            LblPenjualan.Name = "LblPenjualan";
            LblPenjualan.Size = new Size(69, 41);
            LblPenjualan.TabIndex = 4;
            LblPenjualan.Text = "100";
            LblPenjualan.Click += LblPenjualan_Click;
            // 
            // DasborAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            Controls.Add(LblPenjualan);
            Controls.Add(LblBuah);
            Controls.Add(Lblkebun);
            Controls.Add(LblPengguna);
            Controls.Add(dataGridView1);
            Name = "DasborAdmin";
            Size = new Size(800, 560);
            Load += DasborAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridView dataGridView1;
        private Label LblPengguna;
        private Label Lblkebun;
        private Label LblBuah;
        private Label LblPenjualan;
    }
}