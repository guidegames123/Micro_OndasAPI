using AplicativoDesk.Model;
using AplicativoDesk.Persistencia;
using Micro_OndasAPI.Models.Usuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace AplicativoDesk.Telas
{
    public partial class frmCadastrar : Form
    {
        public frmCadastrar()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            HttpStatusCode http;
            RetornoPadraoModel retorno;
            string nome = txtNome.Text;
            string login = txtLogin.Text;
            string senha = txtSenha.Text;

            UsuarioModel usuario = new UsuarioModel() { 
                nome = nome,
                login = login,
                senha = senha,
            
            };

            CadastrarPersistencia cadastrar = new CadastrarPersistencia();

            retorno = cadastrar.Inserir(usuario, out http);

            if (retorno.Status == true)
            {
                MessageBox.Show("Inserido com Sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Close();
            }
            else {
                MessageBox.Show("OPS... Algo deu errado: "+retorno.Mensagem, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
