using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projek_PBO.Views
{
    public partial class dashboard_petani : Form
    {
        public dashboard_petani()
        {
            InitializeComponent();


        }

        private System.Drawing.Drawing2D.GraphicsPath GetRoundedRect(Rectangle rect, int radius)
        {
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void dashboard_admin_Load(object sender, EventArgs e)
        {
            BtnDasbor.Region = new Region(GetRoundedRect(BtnDasbor.ClientRectangle, 20));
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {

        }
    }
}
//BtnDasbor = new Button();
//SuspendLayout();
//// 
//// BtnDasbor
//// 
//BtnDasbor.BackColor = Color.Silver;
//BtnDasbor.FlatAppearance.BorderSize = 0;
//BtnDasbor.FlatStyle = FlatStyle.Flat;
//BtnDasbor.ForeColor = Color.Firebrick;
//BtnDasbor.Location = new Point(12, 147);
//BtnDasbor.Margin = new Padding(3, 4, 3, 4);
//BtnDasbor.Name = "BtnDasbor";
//BtnDasbor.Padding = new Padding(10, 0, 0, 0);
//BtnDasbor.Size = new Size(145, 44);
//BtnDasbor.TabIndex = 0;
//BtnDasbor.Text = "Dasbor";
//BtnDasbor.TextAlign = ContentAlignment.MiddleLeft;
//BtnDasbor.UseVisualStyleBackColor = false;
//BtnDasbor.Click += button1_Click;
//// 