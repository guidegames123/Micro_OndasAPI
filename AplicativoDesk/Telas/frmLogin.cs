using AplicativoDesk.Telas;

namespace AplicativoDesk
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastrar frm = new frmCadastrar();
            frm.ShowDialog();
        }
    }
}
