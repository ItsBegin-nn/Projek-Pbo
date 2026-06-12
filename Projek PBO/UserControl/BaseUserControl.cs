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

        // virtual — bisa di-override tiap child (polymorphism tetap ada)
        public virtual void MuatData() { }
        public virtual string GetJudulForm() => "Base";
    }
}