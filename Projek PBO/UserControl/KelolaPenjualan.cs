namespace Projek_PBO.Views
{
    public partial class KelolaPenjualan : BaseUserControl
    {
        public KelolaPenjualan(string namaPengguna) : base(namaPengguna)
        {
            InitializeComponent();
        }

        public override void MuatData() { }
        public override string GetJudulForm() => "Kelola Penjualan";
    }
}