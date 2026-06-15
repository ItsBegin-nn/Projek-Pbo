namespace Projek_PBO.Views
{
    public partial class KelolaKebun : BaseUserControl
    {
        public KelolaKebun(string namaPengguna) : base(namaPengguna)
        {
            InitializeComponent();
        }

        public override void MuatData() { }
        public override string GetJudulForm() => "Kelola Kebun";

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Petani_Click(object sender, EventArgs e)
        {

        }
    }
}