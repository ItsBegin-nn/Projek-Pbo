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
            button1 = new Button();
            dvgKebun = new DataGridView();
            dvgBuah = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dvgKebun).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvgBuah).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.ForeColor = Color.Lime;
            button1.Location = new Point(602, 594);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(90, 27);
            button1.TabIndex = 2;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Button1_Click;
            // 
            // dvgKebun
            // 
            dvgKebun.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgKebun.Location = new Point(84, 139);
            dvgKebun.Margin = new Padding(2);
            dvgKebun.Name = "dvgKebun";
            dvgKebun.RowHeadersWidth = 62;
            dvgKebun.Size = new Size(642, 190);
            dvgKebun.TabIndex = 0;
            dvgKebun.CellContentClick += dvgKebun_CellContentClick;
            // 
            // dvgBuah
            // 
            dvgBuah.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgBuah.Location = new Point(84, 373);
            dvgBuah.Margin = new Padding(2);
            dvgBuah.Name = "dvgBuah";
            dvgBuah.RowHeadersWidth = 62;
            dvgBuah.Size = new Size(642, 190);
            dvgBuah.TabIndex = 1;
            dvgBuah.CellContentClick += dvgBuah_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(103, 342);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 3;
            label1.Text = "Data Buah";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(103, 107);
            label2.Name = "label2";
            label2.Size = new Size(192, 20);
            label2.TabIndex = 4;
            label2.Text = "Data Kebun dan Komoditas";
            // 
            // BuahDanKebun
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dvgBuah);
            Controls.Add(dvgKebun);
            Controls.Add(button1);
            Margin = new Padding(2);
            Name = "BuahDanKebun";
            Size = new Size(786, 631);
            Load += BuahDanKebun_Load;
            ((System.ComponentModel.ISupportInitialize)dvgKebun).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvgBuah).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Button button1;
        private DataGridView dvgKebun;
        private DataGridView dvgBuah;
        private Label label1;
        private Label label2;
    }
}