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
            Tbnama = new TextBox();
            Tbpass = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            Lbpass = new Label();
            Lbnama = new Label();
            Tbuser = new TextBox();
            LbUsername = new Label();
            comboBox1 = new ComboBox();
            LbRole = new Label();
            BtnSimpan = new Button();
            dataGridView1 = new DataGridView();
            BtnHapus = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Tbnama
            // 
            Tbnama.Location = new Point(112, 151);
            Tbnama.Name = "Tbnama";
            Tbnama.Size = new Size(173, 27);
            Tbnama.TabIndex = 0;
            // 
            // Tbpass
            // 
            Tbpass.Location = new Point(370, 151);
            Tbpass.Name = "Tbpass";
            Tbpass.Size = new Size(177, 27);
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
            // Lbpass
            // 
            Lbpass.AutoSize = true;
            Lbpass.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lbpass.ForeColor = Color.White;
            Lbpass.Location = new Point(370, 127);
            Lbpass.Name = "Lbpass";
            Lbpass.Size = new Size(79, 21);
            Lbpass.TabIndex = 3;
            Lbpass.Text = "Password";
            Lbpass.Click += Lbpass_Click;
            // 
            // Lbnama
            // 
            Lbnama.AutoSize = true;
            Lbnama.BackColor = Color.Transparent;
            Lbnama.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lbnama.ForeColor = Color.White;
            Lbnama.Location = new Point(112, 127);
            Lbnama.Name = "Lbnama";
            Lbnama.Size = new Size(52, 21);
            Lbnama.TabIndex = 3;
            Lbnama.Text = "Nama";
            Lbnama.Click += label2_Click;
            // 
            // Tbuser
            // 
            Tbuser.Location = new Point(112, 258);
            Tbuser.Name = "Tbuser";
            Tbuser.Size = new Size(173, 27);
            Tbuser.TabIndex = 4;
            // 
            // LbUsername
            // 
            LbUsername.AutoSize = true;
            LbUsername.BackColor = Color.Transparent;
            LbUsername.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbUsername.ForeColor = Color.White;
            LbUsername.Location = new Point(112, 234);
            LbUsername.Name = "LbUsername";
            LbUsername.Size = new Size(81, 21);
            LbUsername.TabIndex = 5;
            LbUsername.Text = "Username";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(370, 258);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(177, 28);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // LbRole
            // 
            LbRole.AutoSize = true;
            LbRole.BackColor = Color.Transparent;
            LbRole.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbRole.ForeColor = Color.White;
            LbRole.Location = new Point(370, 234);
            LbRole.Name = "LbRole";
            LbRole.Size = new Size(41, 21);
            LbRole.TabIndex = 7;
            LbRole.Text = "Role";
            LbRole.Click += LbRole_Click;
            // 
            // BtnSimpan
            // 
            BtnSimpan.BackColor = Color.Chartreuse;
            BtnSimpan.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSimpan.ForeColor = Color.Red;
            BtnSimpan.Location = new Point(453, 331);
            BtnSimpan.Name = "BtnSimpan";
            BtnSimpan.Size = new Size(94, 29);
            BtnSimpan.TabIndex = 8;
            BtnSimpan.Text = "Simpan";
            BtnSimpan.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
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
            BtnHapus.Location = new Point(324, 331);
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
            Controls.Add(BtnHapus);
            Controls.Add(dataGridView1);
            Controls.Add(BtnSimpan);
            Controls.Add(LbRole);
            Controls.Add(comboBox1);
            Controls.Add(LbUsername);
            Controls.Add(Tbuser);
            Controls.Add(Lbnama);
            Controls.Add(Lbpass);
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