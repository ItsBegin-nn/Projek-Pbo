namespace Projek_PBO.Views
{
    public partial class UbahPanen : BaseUserControl
    {
        public UbahPanen(string namaPengguna) : base(namaPengguna)
        {
            InitializeComponent();
        }
        public override void MuatData() { }
        public override string GetJudulForm() => "Ubah Panen";
    }
}