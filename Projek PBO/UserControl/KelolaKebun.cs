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
    }
}