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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}