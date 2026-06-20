namespace Projek_PBO.Views
{
    partial class InputPanen  // ganti nama sesuai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputPanen));
            TbBerat = new TextBox();
            TbHarga = new TextBox();
            BtnSimpan = new Button();
            Tanggal = new DateTimePicker();
            Lblestimasi = new Label();
            CbBuah = new ComboBox();
            CbKebun = new ComboBox();
            SuspendLayout();
            // 
            // TbBerat
            // 
            TbBerat.BorderStyle = BorderStyle.None;
            TbBerat.Location = new Point(593, 255);
            TbBerat.Margin = new Padding(4, 3, 4, 3);
            TbBerat.Name = "TbBerat";
            TbBerat.Size = new Size(268, 21);
            TbBerat.TabIndex = 4;
            TbBerat.TextChanged += textBox5_TextChanged;
            // 
            // TbHarga
            // 
            TbHarga.BorderStyle = BorderStyle.None;
            TbHarga.Location = new Point(593, 327);
            TbHarga.Margin = new Padding(4, 3, 4, 3);
            TbHarga.Name = "TbHarga";
            TbHarga.Size = new Size(268, 21);
            TbHarga.TabIndex = 5;
            TbHarga.TextChanged += textBox6_TextChanged;
            // 
            // BtnSimpan
            // 
            BtnSimpan.BackColor = Color.YellowGreen;
            BtnSimpan.FlatAppearance.BorderSize = 0;
            BtnSimpan.FlatStyle = FlatStyle.Flat;
            BtnSimpan.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSimpan.Location = new Point(732, 460);
            BtnSimpan.Margin = new Padding(4, 3, 4, 3);
            BtnSimpan.Name = "BtnSimpan";
            BtnSimpan.Size = new Size(164, 35);
            BtnSimpan.TabIndex = 7;
            BtnSimpan.Text = "Simpan";
            BtnSimpan.UseVisualStyleBackColor = false;
            // 
            // Tanggal
            // 
            Tanggal.Location = new Point(224, 248);
            Tanggal.Name = "Tanggal";
            Tanggal.Size = new Size(268, 28);
            Tanggal.TabIndex = 12;
            // 
            // Lblestimasi
            // 
            Lblestimasi.BackColor = Color.Transparent;
            Lblestimasi.Location = new Point(224, 327);
            Lblestimasi.Name = "Lblestimasi";
            Lblestimasi.Size = new Size(268, 21);
            Lblestimasi.TabIndex = 13;
            Lblestimasi.Click += label1_Click;
            // 
            // CbBuah
            // 
            CbBuah.FormattingEnabled = true;
            CbBuah.Location = new Point(224, 181);
            CbBuah.Name = "CbBuah";
            CbBuah.Size = new Size(268, 27);
            CbBuah.TabIndex = 14;
            // 
            // CbKebun
            // 
            CbKebun.FormattingEnabled = true;
            CbKebun.Location = new Point(593, 181);
            CbKebun.Name = "CbKebun";
            CbKebun.Size = new Size(268, 27);
            CbKebun.TabIndex = 15;
            // 
            // InputPanen
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Transparent;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            Controls.Add(CbKebun);
            Controls.Add(CbBuah);
            Controls.Add(Lblestimasi);
            Controls.Add(Tanggal);
            Controls.Add(BtnSimpan);
            Controls.Add(TbHarga);
            Controls.Add(TbBerat);
            Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 2, 4, 2);
            Name = "InputPanen";
            Size = new Size(904, 516);
            Load += InputPanen_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }
        private TextBox TbBerat;
        private TextBox TbHarga;
        private TextBox textBox7;
        private Button BtnSimpan;
        private DateTimePicker Tanggal;
        private Panel panel1;
        private Panel panel2;
        private Panel panel5;
        private Panel panel3;
        private Panel panel4;
        private Panel panel6;
        private Label Lblestimasi;
        private ComboBox CbBuah;
        private ComboBox CbKebun;
    }
}