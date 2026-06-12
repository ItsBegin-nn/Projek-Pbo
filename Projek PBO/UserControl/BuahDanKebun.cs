namespace Projek_PBO.Views
{
    public partial class BuahDanKebun : BaseUserControl
    {
        public BuahDanKebun(string namaPengguna) : base(namaPengguna)
        {
            InitializeComponent();
        }
        public override void MuatData() { }
        public override string GetJudulForm() => "Buah Dan Kebun";
    }
}