namespace Projek_PBO.Views
{
    partial class HapusPanen  // ganti nama sesuai
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
            LblPanen = new Label();
            LblPengingat = new Label();
            BtnHapus = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // LblPanen
            // 
            LblPanen.AutoSize = true;
            LblPanen.BackColor = Color.Transparent;
            LblPanen.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblPanen.ForeColor = Color.White;
            LblPanen.Location = new Point(64, 196);
            LblPanen.Name = "LblPanen";
            LblPanen.Size = new Size(233, 21);
            LblPanen.TabIndex = 0;
            LblPanen.Text = "Pilih Panen Yang Mau Dihapus";
            // 
            // LblPengingat
            // 
            LblPengingat.AutoSize = true;
            LblPengingat.BackColor = Color.Transparent;
            LblPengingat.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblPengingat.ForeColor = Color.White;
            LblPengingat.Location = new Point(64, 106);
            LblPengingat.Name = "LblPengingat";
            LblPengingat.Size = new Size(652, 21);
            LblPengingat.TabIndex = 1;
            LblPengingat.Text = "Pilih data panen, lalu klik Hapus. Konfirmasi diperlukan sebelum data dihapus permanen.";
            // 
            // BtnHapus
            // 
            BtnHapus.BackColor = Color.Red;
            BtnHapus.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnHapus.ForeColor = Color.Chartreuse;
            BtnHapus.Location = new Point(622, 196);
            BtnHapus.Name = "BtnHapus";
            BtnHapus.Size = new Size(94, 29);
            BtnHapus.TabIndex = 2;
            BtnHapus.Text = "Hapus";
            BtnHapus.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 231);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(815, 419);
            dataGridView1.TabIndex = 3;
            // 
            // HapusPanen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(BtnHapus);
            Controls.Add(LblPengingat);
            Controls.Add(LblPanen);
            Name = "HapusPanen";
            Size = new Size(858, 669);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label LblPanen;
        private Label LblPengingat;
        private Button BtnHapus;
        private DataGridView dataGridView1;
    }
}