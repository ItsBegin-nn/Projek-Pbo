namespace Projek_PBO.Views
{
    public partial class RiwayatPenjualan : BaseUserControl
    {
        public RiwayatPenjualan(string namaPengguna) : base(namaPengguna)
        {
            InitializeComponent();
        }
        public override void MuatData() { }
        public override string GetJudulForm() => "Riwayat Penjualan";
    }
}