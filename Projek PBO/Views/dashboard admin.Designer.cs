namespace Projek_PBO.Views
{
    partial class dashboard_admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard_admin));
            BtnDasbor = new Button();
            SuspendLayout();
            // 
            // BtnDasbor
            // 
            BtnDasbor.BackColor = Color.Transparent;
            BtnDasbor.BackgroundImage = Properties.Resources.Dasbor;
            BtnDasbor.BackgroundImageLayout = ImageLayout.None;
            BtnDasbor.ForeColor = Color.Red;
            BtnDasbor.Location = new Point(12, 107);
            BtnDasbor.Name = "BtnDasbor";
            BtnDasbor.Size = new Size(94, 34);
            BtnDasbor.TabIndex = 0;
            BtnDasbor.Text = "Dasbor";
            BtnDasbor.TextAlign = ContentAlignment.MiddleLeft;
            BtnDasbor.UseVisualStyleBackColor = false;
            BtnDasbor.Click += button1_Click;
            // 
            // dashboard_admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(941, 527);
            Controls.Add(BtnDasbor);
            Name = "dashboard_admin";
            Text = "dashboard_admin";
            Load += dashboard_admin_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button BtnDasbor;
    }
}