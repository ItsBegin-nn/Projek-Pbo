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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            BTN = new Button();
            TBuser = new TextBox();
            TBpass = new TextBox();
            SuspendLayout();
            // 
            // BTN
            // 
            BTN.BackColor = Color.SeaShell;
            BTN.Location = new Point(499, 505);
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
            TBuser.Location = new Point(423, 339);
            TBuser.Name = "TBuser";
            TBuser.Size = new Size(288, 27);
            TBuser.TabIndex = 1;
            TBuser.TextChanged += TBuser_TextChanged;
            // 
            // TBpass
            // 
            TBpass.Location = new Point(423, 432);
            TBpass.Name = "TBpass";
            TBpass.Size = new Size(288, 27);
            TBpass.TabIndex = 3;
            TBpass.UseSystemPasswordChar = true;
            TBpass.TextChanged += TBpass_TextChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1103, 670);
            Controls.Add(TBpass);
            Controls.Add(BTN);
            Controls.Add(TBuser);
            Name = "Login";
            Text = "BuahKita";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BTN;
        private TextBox TBuser;
        private TextBox TBpass;
    }
}
