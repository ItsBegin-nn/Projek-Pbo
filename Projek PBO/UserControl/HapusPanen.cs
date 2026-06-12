namespace Projek_PBO.Views
{
    public partial class HapusPanen : BaseUserControl
    {
        public HapusPanen(string namaPengguna) : base(namaPengguna)
        {
            InitializeComponent();
        }
        public override void MuatData() { }
        public override string GetJudulForm() => "Hapus Panen";
    }
}