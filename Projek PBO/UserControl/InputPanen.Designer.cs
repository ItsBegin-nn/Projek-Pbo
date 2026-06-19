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
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            button1 = new Button();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            panel1 = new Panel();
            panel5 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            panel6 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(259, 88);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(268, 21);
            textBox1.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(259, 221);
            textBox3.Margin = new Padding(4, 3, 4, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(268, 21);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(694, 88);
            textBox4.Margin = new Padding(4, 3, 4, 3);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(268, 21);
            textBox4.TabIndex = 3;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Location = new Point(694, 157);
            textBox5.Margin = new Padding(4, 3, 4, 3);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(268, 21);
            textBox5.TabIndex = 4;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox6
            // 
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Location = new Point(694, 221);
            textBox6.Margin = new Padding(4, 3, 4, 3);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(268, 21);
            textBox6.TabIndex = 5;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // textBox7
            // 
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Location = new Point(694, 291);
            textBox7.Margin = new Padding(4, 3, 4, 3);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(268, 21);
            textBox7.TabIndex = 6;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.YellowGreen;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(837, 343);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(164, 35);
            button1.TabIndex = 7;
            button1.Text = "Simpan";
            button1.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(445, 57);
            label4.Name = "label4";
            label4.Size = new Size(0, 19);
            label4.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(259, 150);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(268, 28);
            dateTimePicker1.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(259, 146);
            panel1.Name = "panel1";
            panel1.Size = new Size(275, 10);
            panel1.TabIndex = 13;
            panel1.Paint += panel1_Paint;
            // 
            // panel5
            // 
            panel5.Location = new Point(262, 7);
            panel5.Name = "panel5";
            panel5.Size = new Size(10, 22);
            panel5.TabIndex = 17;
            // 
            // panel3
            // 
            panel3.Location = new Point(265, 10);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 22);
            panel3.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.Location = new Point(259, 176);
            panel2.Name = "panel2";
            panel2.Size = new Size(275, 10);
            panel2.TabIndex = 14;
            // 
            // panel4
            // 
            panel4.Location = new Point(251, 157);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 22);
            panel4.TabIndex = 16;
            // 
            // panel6
            // 
            panel6.Location = new Point(524, 156);
            panel6.Name = "panel6";
            panel6.Size = new Size(10, 22);
            panel6.TabIndex = 17;
            // 
            // InputPanen
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(panel6);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 2, 4, 2);
            Name = "InputPanen";
            Size = new Size(982, 501);
            Load += InputPanen_Load_1;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Button button1;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel5;
        private Panel panel3;
        private Panel panel4;
        private Panel panel6;
    }
}