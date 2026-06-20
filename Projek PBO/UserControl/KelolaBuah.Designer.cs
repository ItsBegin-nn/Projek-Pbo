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
            lblNamaBuah.Location = new Point(164, 87);
            lblNamaBuah.Name = "lblNamaBuah";
            lblNamaBuah.Size = new Size(103, 25);
            lblNamaBuah.TabIndex = 0;
            lblNamaBuah.Text = "Nama Buah";
            lblNamaBuah.Click += lblNamaBuah_Click;
            // 
            // lblHarga
            // 
            lblHarga.AutoSize = true;
            lblHarga.Location = new Point(164, 182);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(110, 25);
            lblHarga.TabIndex = 1;
            lblHarga.Text = "Harga Dasar";
            // 
            // lblSatuan
            // 
            lblSatuan.AutoSize = true;
            lblSatuan.Location = new Point(523, 87);
            lblSatuan.Name = "lblSatuan";
            lblSatuan.Size = new Size(66, 25);
            lblSatuan.TabIndex = 2;
            lblSatuan.Text = "Satuan";
            // 
            // txtSatuan
            // 
            txtSatuan.Location = new Point(523, 130);
            txtSatuan.Name = "txtSatuan";
            txtSatuan.Size = new Size(247, 31);
            txtSatuan.TabIndex = 4;
            // 
            // txtNamaBuah
            // 
            txtNamaBuah.Location = new Point(164, 130);
            txtNamaBuah.Name = "txtNamaBuah";
            txtNamaBuah.Size = new Size(247, 31);
            txtNamaBuah.TabIndex = 5;
            // 
            // txtHarga
            // 
            txtHarga.Location = new Point(164, 230);
            txtHarga.Name = "txtHarga";
            txtHarga.Size = new Size(247, 31);
            txtHarga.TabIndex = 6;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.Lime;
            btnTambah.ForeColor = Color.Red;
            btnTambah.Location = new Point(806, 230);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(112, 34);
            btnTambah.TabIndex = 7;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = false;
            // 
            // dgvBuah
            // 
            dgvBuah.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBuah.Columns.AddRange(new DataGridViewColumn[] { colId, colNama, ColSatuan, ColHarga });
            dgvBuah.Location = new Point(146, 310);
            dgvBuah.Name = "dgvBuah";
            dgvBuah.RowHeadersWidth = 62;
            dgvBuah.Size = new Size(815, 225);
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
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvBuah);
            Controls.Add(btnTambah);
            Controls.Add(txtHarga);
            Controls.Add(txtNamaBuah);
            Controls.Add(txtSatuan);
            Controls.Add(lblSatuan);
            Controls.Add(lblHarga);
            Controls.Add(lblNamaBuah);
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