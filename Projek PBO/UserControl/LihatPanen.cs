namespace Projek_PBO.Views
{
    public partial class LihatPanen : BaseUserControl
    {
        public LihatPanen(string namaPengguna) : base(namaPengguna)
        {
            InitializeComponent();
        }

        public override void MuatData() { }
        public override string GetJudulForm() => "Lihat Panen";
    }
}