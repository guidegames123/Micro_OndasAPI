using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace AplicativoDesk.Telas
{
    public partial class frmMicroOndas : Form
    {
        System.Windows.Forms.Timer timer;

        int usuario_id;
        int minutos = 0;
        int segundos = 0;
        string tempo_digitado = "";
        bool pausa = false;

        public frmMicroOndas(int usuario_id)
        {
            this.usuario_id = usuario_id;
            InitializeComponent();

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1 segundo
            timer.Tick += Tick;

        }

        private void frmMicroOndas_Load(object sender, EventArgs e)
        {

        }

        private void adicionaNumero(int botao_numero)
        {
            if (tempo_digitado.Length < 4)
            {
                tempo_digitado += botao_numero;
                AtualizaVisor();
            }
            else
            {
                MessageBox.Show("Existe mais de quatro numeros digitados...", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Tick(object sender, EventArgs e)
        {
            if (minutos == 0 && segundos == 0)
            {
                timer.Stop();
                MessageBox.Show("Comida Pronta", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (segundos == 0)
            {
                if (minutos > 0)
                {
                    minutos--;
                    segundos = 59;
                }
            }
            else
            {
                segundos--;
            }

            lbVisor.Text = $"{minutos:00}:{segundos:00}";
        }

        private void AtualizaVisor()
        {


            string texto = tempo_digitado.PadLeft(4, '0');

            minutos = int.Parse(texto.Substring(0, 2));
            segundos = int.Parse(texto.Substring(2, 2));

            minutos += segundos / 60;
            segundos = segundos % 60;

            lbVisor.Text = $"{minutos:00}:{segundos:00}";

        }

        private void Ligar()
        {

            tempo_digitado = "";
            if (minutos == 0 && segundos == 0)
            {
                MessageBox.Show("Por favor, digite um tempo válido.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            timer.Start();
            pausa = false;

            

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int botao_numero = 1;
            adicionaNumero(botao_numero);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            int botao_numero = 2;
            adicionaNumero(botao_numero);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            int botao_numero = 3;
            adicionaNumero(botao_numero);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            int botao_numero = 4;
            adicionaNumero(botao_numero);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            int botao_numero = 5;
            adicionaNumero(botao_numero);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            int botao_numero = 6;
            adicionaNumero(botao_numero);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            int botao_numero = 7;
            adicionaNumero(botao_numero);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            int botao_numero = 8;
            adicionaNumero(botao_numero);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            int botao_numero = 9;
            adicionaNumero(botao_numero);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            int botao_numero = 0;
            adicionaNumero(botao_numero);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            if (pausa == true)
            {
                tempo_digitado = "";
                AtualizaVisor();
            }

            timer.Stop();
            pausa = true;
            
        }

        private void btnComecar_Click(object sender, EventArgs e)
        {
            Ligar();
        }
    }
}
