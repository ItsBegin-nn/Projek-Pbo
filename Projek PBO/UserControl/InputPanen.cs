namespace Projek_PBO.Views
{
    public partial class InputPanen : BaseUserControl
    {
        public InputPanen(string namaPengguna) : base(namaPengguna)
        {
            InitializeComponent();
        }
        public override void MuatData() { }
        public override string GetJudulForm() => "Input Panen";
    }
}