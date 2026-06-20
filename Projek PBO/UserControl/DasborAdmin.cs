namespace Projek_PBO.Views
{
    public partial class DasborAdmin : BaseUserControl
    {
        public DasborAdmin(string namaPengguna) : base(namaPengguna)
        {
            InitializeComponent();
        }

        public override void MuatData() { }
        public override string GetJudulForm() => "Dasbor";

        private void DasborAdmin_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}