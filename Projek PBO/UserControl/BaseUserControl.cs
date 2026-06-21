using System.Windows.Forms;

namespace Projek_PBO.Views
{
    public partial class BaseUserControl : UserControl
    {
        protected string NamaPengguna { get; set; }

        public BaseUserControl()
        {
            InitializeComponent();
        }

        public BaseUserControl(string namaPengguna) : this()
        {
            NamaPengguna = namaPengguna;
        }

        // POLYMORPHISM
        public virtual void MuatData() { }
        public virtual string GetJudulForm() => "Base";
    }
}