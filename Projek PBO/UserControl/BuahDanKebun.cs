using System;
using System.Windows.Forms;
using Projek_PBO.Controllers;

namespace Projek_PBO.Views
{
    public partial class BuahDanKebun : BaseUserControl
    {
        private readonly KebunController _kebunController;
        private readonly KelolaBuahController _buahController;

        public BuahDanKebun(string namaPengguna) : base(namaPengguna)
        {
            InitializeComponent();
            _kebunController = new KebunController();
            _buahController = new KelolaBuahController();

            dvgKebun.ReadOnly = true;
            dvgBuah.ReadOnly = true;

            button1.Click += Button1_Click;

            this.Load += (s, e) => MuatData();
        }

        public override void MuatData()
        {
            dvgKebun.DataSource = _kebunController.GetAll();
            dvgBuah.DataSource = _buahController.GetAll();

           
            if (dvgBuah.Columns["Panens"] != null)
                dvgBuah.Columns["Panens"].Visible = false;

            if (dvgKebun.Columns["Panens"] != null)
                dvgKebun.Columns["Panens"].Visible = false;
        }

        public override string GetJudulForm() => "Buah Dan Kebun";

        private void Button1_Click(object sender, EventArgs e)
        {
            MuatData();
        }

        private void dvgKebun_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void dvgBuah_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void gbKebun_Enter(object sender, EventArgs e) { }

        private void BuahDanKebun_Load(object sender, EventArgs e)
        {

        }
    }
}