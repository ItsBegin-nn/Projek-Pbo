namespace Projek_PBO.Views
{
    public partial class DasborPetani : BaseUserControl
    {
        public DasborPetani(string namaPengguna) : base(namaPengguna)
        {
            InitializeComponent();
        }

        public override void MuatData() { }
        public override string GetJudulForm() => "Dasbor Petani";
    }
}