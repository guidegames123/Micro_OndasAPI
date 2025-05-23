using AplicativoDesk.Model;
using AplicativoDesk.Persistencia;
using AplicativoDesk.Telas;
using Micro_OndasAPI.Models.Usuario;
using System.Net;

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

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            HttpStatusCode http;
            RetornoPadraoModel retorno;
            string login = txtLogin.Text;
            string senha = txtSenha.Text;

            UsuarioModel usuario = new UsuarioModel()
            {
                login = login,
                senha = senha,

            };

            CadastrarPersistencia cadastrar = new CadastrarPersistencia();

            retorno = cadastrar.ValidarLogin(usuario, out http);

            if (retorno.Status == true)
            {
                frmMicroOndas micro = new frmMicroOndas(int.Parse(retorno.Data.ToString()));
                micro.ShowDialog();
            }
            else
            {
                MessageBox.Show("OPS... Algo deu errado: " + retorno.Mensagem, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
