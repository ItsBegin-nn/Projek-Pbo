namespace Projek_PBO.Views
{
    partial class UbahPanen  // ganti nama sesuai
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
            dgvEditData = new DataGridView();
            cbBuah = new ComboBox();
            cbKebun = new ComboBox();
            dtpTanggalPanen = new DateTimePicker();
            txtHarga = new TextBox();
            txtBerat = new TextBox();
            lbl1 = new Label();
            lbl2 = new Label();
            lbl3 = new Label();
            lbl4 = new Label();
            lbl5 = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvEditData).BeginInit();
            SuspendLayout();
            // 
            // dgvEditData
            // 
            dgvEditData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEditData.Location = new Point(173, 305);
            dgvEditData.Name = "dgvEditData";
            dgvEditData.RowHeadersWidth = 62;
            dgvEditData.Size = new Size(743, 275);
            dgvEditData.TabIndex = 1;
            // 
            // cbBuah
            // 
            cbBuah.FormattingEnabled = true;
            cbBuah.Location = new Point(226, 357);
            cbBuah.Name = "cbBuah";
            cbBuah.Size = new Size(252, 33);
            cbBuah.TabIndex = 2;
            // 
            // cbKebun
            // 
            cbKebun.FormattingEnabled = true;
            cbKebun.Location = new Point(590, 357);
            cbKebun.Name = "cbKebun";
            cbKebun.Size = new Size(252, 33);
            cbKebun.TabIndex = 3;
            // 
            // dtpTanggalPanen
            // 
            dtpTanggalPanen.Location = new Point(226, 428);
            dtpTanggalPanen.Name = "dtpTanggalPanen";
            dtpTanggalPanen.Size = new Size(300, 31);
            dtpTanggalPanen.TabIndex = 4;
            // 
            // txtHarga
            // 
            txtHarga.Location = new Point(226, 492);
            txtHarga.Name = "txtHarga";
            txtHarga.Size = new Size(252, 31);
            txtHarga.TabIndex = 5;
            // 
            // txtBerat
            // 
            txtBerat.Location = new Point(590, 428);
            txtBerat.Name = "txtBerat";
            txtBerat.Size = new Size(252, 31);
            txtBerat.TabIndex = 6;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.BackColor = SystemColors.ControlDark;
            lbl1.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1.ForeColor = Color.Black;
            lbl1.Location = new Point(226, 330);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(65, 24);
            lbl1.TabIndex = 7;
            lbl1.Text = "BUAH";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.BackColor = SystemColors.ControlDark;
            lbl2.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2.ForeColor = Color.Black;
            lbl2.Location = new Point(226, 401);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(175, 24);
            lbl2.TabIndex = 8;
            lbl2.Text = "TANGGAL PANEN";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.BackColor = SystemColors.ControlDark;
            lbl3.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl3.ForeColor = Color.Black;
            lbl3.Location = new Point(226, 465);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(119, 24);
            lbl3.TabIndex = 9;
            lbl3.Text = "HARGA (kg)";
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.BackColor = SystemColors.ControlDark;
            lbl4.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl4.ForeColor = Color.Black;
            lbl4.Location = new Point(590, 330);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(76, 24);
            lbl4.TabIndex = 10;
            lbl4.Text = "KEBUN";
            // 
            // lbl5
            // 
            lbl5.AutoSize = true;
            lbl5.BackColor = SystemColors.ControlDark;
            lbl5.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl5.ForeColor = Color.Black;
            lbl5.Location = new Point(590, 401);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(109, 24);
            lbl5.TabIndex = 11;
            lbl5.Text = "BERAT (kg)";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.ForeColor = Color.Lime;
            btnCancel.Location = new Point(621, 508);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Lime;
            btnSave.ForeColor = Color.Red;
            btnSave.Location = new Point(750, 508);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 15;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(173, 55);
            label1.Name = "label1";
            label1.Size = new Size(411, 32);
            label1.TabIndex = 16;
            label1.Text = "Pilih Data Panen Yang Ingin Diubah";
            label1.Click += label1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(173, 90);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(731, 33);
            comboBox1.TabIndex = 17;
            // 
            // UbahPanen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(lbl5);
            Controls.Add(lbl4);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(txtBerat);
            Controls.Add(txtHarga);
            Controls.Add(dtpTanggalPanen);
            Controls.Add(cbKebun);
            Controls.Add(cbBuah);
            Controls.Add(dgvEditData);
            Name = "UbahPanen";
            ((System.ComponentModel.ISupportInitialize)dgvEditData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridView dgvDataPanen;
        private DataGridView dgvEditData;
        private ComboBox cbBuah;
        private ComboBox cbKebun;
        private DateTimePicker dtpTanggalPanen;
        private TextBox txtHarga;
        private TextBox txtBerat;
        private Label lbl1;
        private Label lbl2;
        private Label lbl3;
        private Label lbl4;
        private Label lbl5;
        private Button btnCancel;
        private Button btnSave;
        private Label label1;
        private ComboBox comboBox1;
    }
}