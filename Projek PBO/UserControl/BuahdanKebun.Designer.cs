namespace Projek_PBO.Views
{
    partial class BuahDanKebun  // ganti nama sesuai
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
            dvgKebun = new DataGridView();
            dvgBuah = new DataGridView();
            gbKebun = new GroupBox();
            gbBuah = new GroupBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dvgKebun).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvgBuah).BeginInit();
            gbKebun.SuspendLayout();
            gbBuah.SuspendLayout();
            SuspendLayout();
            
            // dvgKebun

            dvgKebun.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgKebun.Location = new Point(-8, 30);
            dvgKebun.Name = "dvgKebun";
            dvgKebun.RowHeadersWidth = 62;
            dvgKebun.Size = new Size(803, 237);
            dvgKebun.TabIndex = 0;
            dvgKebun.CellContentClick += dvgKebun_CellContentClick;
            
            // dvgBuah
            
            dvgBuah.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgBuah.Location = new Point(0, 25);
            dvgBuah.Name = "dvgBuah";
            dvgBuah.RowHeadersWidth = 62;
            dvgBuah.Size = new Size(803, 237);
            dvgBuah.TabIndex = 1;
            dvgBuah.CellContentClick += dvgBuah_CellContentClick;
            
            // gbKebun
             
            gbKebun.Controls.Add(dvgKebun);
            gbKebun.Location = new Point(135, 16);
            gbKebun.Name = "gbKebun";
            gbKebun.Size = new Size(795, 268);
            gbKebun.TabIndex = 2;
            gbKebun.TabStop = false;
            gbKebun.Text = "Daftar Kebun & Komoditas";
            gbKebun.Enter += gbKebun_Enter;
            
            // gbBuah
            
            gbBuah.Controls.Add(dvgBuah);
            gbBuah.Location = new Point(135, 308);
            gbBuah.Name = "gbBuah";
            gbBuah.Size = new Size(795, 268);
            gbBuah.TabIndex = 3;
            gbBuah.TabStop = false;
            gbBuah.Text = " Data Buah Terdaftar";
            
            // button1
            
            button1.BackColor = Color.Red;
            button1.ForeColor = Color.Lime;
            button1.Location = new Point(741, 601);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;

            // BuahDanKebun

            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(gbBuah);
            Controls.Add(gbKebun);
            Name = "BuahDanKebun";
            ((System.ComponentModel.ISupportInitialize)dvgKebun).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvgBuah).EndInit();
            gbKebun.ResumeLayout(false);
            gbBuah.ResumeLayout(false);
            ResumeLayout(false);
        }

        private DataGridView dvgKebun;
        private DataGridView dvgBuah;
        private GroupBox gbKebun;
        private GroupBox gbBuah;
        private Button button1;
    }
}