namespace Projek_PBO.Views
{
    partial class KelolaBuah
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
            lblNamaBuah = new Label();
            lblHarga = new Label();
            lblSatuan = new Label();
            txtSatuan = new TextBox();
            txtNamaBuah = new TextBox();
            txtHarga = new TextBox();
            btnTambah = new Button();
            dgvBuah = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colNama = new DataGridViewTextBoxColumn();
            ColSatuan = new DataGridViewTextBoxColumn();
            ColHarga = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvBuah).BeginInit();
            SuspendLayout();
            // 
            // lblNamaBuah
            // 
            lblNamaBuah.AutoSize = true;
            lblNamaBuah.Location = new Point(130, 108);
            lblNamaBuah.Margin = new Padding(2, 0, 2, 0);
            lblNamaBuah.Name = "lblNamaBuah";
            lblNamaBuah.Size = new Size(86, 20);
            lblNamaBuah.TabIndex = 0;
            lblNamaBuah.Text = "Nama Buah";
            lblNamaBuah.Click += lblNamaBuah_Click;
            // 
            // lblHarga
            // 
            lblHarga.AutoSize = true;
            lblHarga.Location = new Point(130, 184);
            lblHarga.Margin = new Padding(2, 0, 2, 0);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(92, 20);
            lblHarga.TabIndex = 1;
            lblHarga.Text = "Harga Dasar";
            // 
            // lblSatuan
            // 
            lblSatuan.AutoSize = true;
            lblSatuan.Location = new Point(417, 108);
            lblSatuan.Margin = new Padding(2, 0, 2, 0);
            lblSatuan.Name = "lblSatuan";
            lblSatuan.Size = new Size(54, 20);
            lblSatuan.TabIndex = 2;
            lblSatuan.Text = "Satuan";
            // 
            // txtSatuan
            // 
            txtSatuan.Location = new Point(417, 142);
            txtSatuan.Margin = new Padding(2, 2, 2, 2);
            txtSatuan.Name = "txtSatuan";
            txtSatuan.Size = new Size(198, 27);
            txtSatuan.TabIndex = 4;
            // 
            // txtNamaBuah
            // 
            txtNamaBuah.Location = new Point(130, 142);
            txtNamaBuah.Margin = new Padding(2, 2, 2, 2);
            txtNamaBuah.Name = "txtNamaBuah";
            txtNamaBuah.Size = new Size(198, 27);
            txtNamaBuah.TabIndex = 5;
            // 
            // txtHarga
            // 
            txtHarga.Location = new Point(130, 222);
            txtHarga.Margin = new Padding(2, 2, 2, 2);
            txtHarga.Name = "txtHarga";
            txtHarga.Size = new Size(198, 27);
            txtHarga.TabIndex = 6;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.Lime;
            btnTambah.ForeColor = Color.Red;
            btnTambah.Location = new Point(644, 222);
            btnTambah.Margin = new Padding(2, 2, 2, 2);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(90, 27);
            btnTambah.TabIndex = 7;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = false;
            // 
            // dgvBuah
            // 
            dgvBuah.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBuah.Columns.AddRange(new DataGridViewColumn[] { colId, colNama, ColSatuan, ColHarga });
            dgvBuah.Location = new Point(116, 286);
            dgvBuah.Margin = new Padding(2, 2, 2, 2);
            dgvBuah.Name = "dgvBuah";
            dgvBuah.RowHeadersWidth = 62;
            dgvBuah.Size = new Size(652, 180);
            dgvBuah.TabIndex = 8;
            // 
            // colId
            // 
            colId.HeaderText = "ID";
            colId.MinimumWidth = 8;
            colId.Name = "colId";
            colId.Width = 150;
            // 
            // colNama
            // 
            colNama.HeaderText = "Nama Buah";
            colNama.MinimumWidth = 8;
            colNama.Name = "colNama";
            colNama.Width = 150;
            // 
            // ColSatuan
            // 
            ColSatuan.HeaderText = "Satuan";
            ColSatuan.MinimumWidth = 8;
            ColSatuan.Name = "ColSatuan";
            ColSatuan.Width = 150;
            // 
            // ColHarga
            // 
            ColHarga.HeaderText = "Harga";
            ColHarga.MinimumWidth = 8;
            ColHarga.Name = "ColHarga";
            ColHarga.Width = 150;
            // 
            // KelolaBuah
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvBuah);
            Controls.Add(btnTambah);
            Controls.Add(txtHarga);
            Controls.Add(txtNamaBuah);
            Controls.Add(txtSatuan);
            Controls.Add(lblSatuan);
            Controls.Add(lblHarga);
            Controls.Add(lblNamaBuah);
            Margin = new Padding(2, 2, 2, 2);
            Name = "KelolaBuah";
            ((System.ComponentModel.ISupportInitialize)dgvBuah).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblNamaBuah;
        private Label lblHarga;
        private Label lblSatuan;
        private TextBox txtSatuan;
        private TextBox txtNamaBuah;
        private TextBox txtHarga;
        private Button btnTambah;
        private DataGridView dgvBuah;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colNama;
        private DataGridViewTextBoxColumn ColSatuan;
        private DataGridViewTextBoxColumn ColHarga;
    }
}