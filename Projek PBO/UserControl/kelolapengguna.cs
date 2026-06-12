namespace Projek_PBO.Views
{
    public partial class KelolaPengguna : BaseUserControl
    {
        public KelolaPengguna(string namaPengguna) : base(namaPengguna)
        {
            InitializeComponent();
        }

        public override void MuatData() { }
        public override string GetJudulForm() => "Kelola Pengguna";
    }
}