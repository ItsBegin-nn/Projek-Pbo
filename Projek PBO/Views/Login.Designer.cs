namespace Projek_PBO
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TBpass = new TextBox();
            BTN = new Button();
            TBuser = new TextBox();
            SuspendLayout();
            // 
            // TBpass
            // 
            TBpass.Location = new Point(240, 460);
            TBpass.Multiline = true;
            TBpass.Name = "TBpass";
            TBpass.Size = new Size(288, 34);
            TBpass.TabIndex = 0;
            // 
            // BTN
            // 
            BTN.BackColor = Color.OliveDrab;
            BTN.Location = new Point(334, 550);
            BTN.Name = "BTN";
            BTN.Size = new Size(113, 44);
            BTN.TabIndex = 2;
            BTN.Text = "LOGIN";
            BTN.UseVisualStyleBackColor = false;
            BTN.Click += button1_Click;
            // 
            // TBuser
            // 
            TBuser.Anchor = AnchorStyles.None;
            TBuser.Location = new Point(240, 363);
            TBuser.Multiline = true;
            TBuser.Name = "TBuser";
            TBuser.Size = new Size(288, 34);
            TBuser.TabIndex = 1;
            TBuser.TextChanged += TBuser_TextChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1103, 670);
            Controls.Add(BTN);
            Controls.Add(TBuser);
            Controls.Add(TBpass);
            Name = "Login";
            Text = "BuahKita";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TBpass;
        private Button BTN;
        private TextBox TBuser;
    }
}
