namespace Projek_PBO.Views
{
    public partial class KelolaBuah : BaseUserControl
    {
        public KelolaBuah(string namaPengguna) : base(namaPengguna)
        {
            InitializeComponent();
        }

        public override void MuatData() { }
        public override string GetJudulForm() => "Kelola Buah";
    }
}