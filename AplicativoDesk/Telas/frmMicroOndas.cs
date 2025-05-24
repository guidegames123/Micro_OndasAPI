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
        int potencia = 10;
        string tempo_digitado = "";
        string caractere = ".";
        bool input = false;
        bool pausa = false;


        public frmMicroOndas(int usuario_id)
        {
            this.usuario_id = usuario_id;
            InitializeComponent();

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1 segundo
            timer.Tick += Tick;

            lblTempoPotencia.Text = "";

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
            input = false;
            if (minutos == 0 && segundos == 0)
            {
                timer.Stop();
                potencia = 10;
                lblPotencia.Text = "Potencia: " + potencia;
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
                lblTempoPotencia.Text += new string(char.Parse(caractere), potencia) + " ";
            }

            lbVisor.Text = $"{minutos:00}:{segundos:00}";
        }

        private void AtualizaVisor()
        {

            input = true;
            string texto = tempo_digitado.PadLeft(4, '0');

            minutos = int.Parse(texto.Substring(0, 2));
            segundos = int.Parse(texto.Substring(2, 2));

            minutos += segundos / 60;
            segundos = segundos % 60;

            lbVisor.Text = $"{minutos:00}:{segundos:00}";

        }

        private void InicioRapido() {
            if (pausa == false)
            {
                lblTempoPotencia.Text = "";
                segundos += 30;
                if (segundos >= 60)
                {
                    minutos += 1;
                    segundos -= 60;
                    if (minutos > 2)
                    {
                        minutos = 2;
                        segundos = 0;
                    }
                }
            }
        }

        private void Ligar()
        {

            if (input == false) {
                InicioRapido();
            }

            if (minutos >= 2 && segundos > 0 || minutos > 2)
            {
                MessageBox.Show("Por favor, digite um valor menor que 2 minutos.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            tempo_digitado = "";

            
            timer.Start();
            pausa = false;
            



        }


        private void btnPotencia_Click(object sender, EventArgs e)
        {
            try
            {
                potencia = int.Parse(tempo_digitado);
            }
            catch (Exception err)
            {
                potencia = 0;
            }

            if (potencia >= 1 && potencia <= 10)
            {
                lblPotencia.Text = "Potencia: " + potencia;
                tempo_digitado = "";
                AtualizaVisor();
            }
            else
            {
                MessageBox.Show("Por favor, digite uma potência válida de 1 a 10.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                potencia = 10;
                lblPotencia.Text = "Potencia: " + potencia;
            }

            if (segundos <= 0 && minutos <=0) {
                input = false;
            }


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

            if (pausa == true || segundos <= 0 && minutos <=0)
            {
                lblTempoPotencia.Text = "";
                tempo_digitado = "";
                AtualizaVisor();
                potencia = 10;
                lblPotencia.Text = "Potencia: " + potencia;
                input = false;
                pausa = false;
                return;
            }

            timer.Stop();

            pausa = true;

            

        }

        private void btnComecar_Click(object sender, EventArgs e)
        {
            Ligar();
        }

        private void frmMicroOndas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) // Teclado normal
            {
                int numero = e.KeyCode - Keys.D0;
                adicionaNumero(numero);
            }
            else if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9) // Teclado numérico
            {
                int numero = e.KeyCode - Keys.NumPad0;
                adicionaNumero(numero);
            }
            else if (e.KeyCode == Keys.Decimal) // Começar
            {
                Ligar();
            }
            else if (e.KeyCode == Keys.Back) // Cancelar
            {
                btnCancelar.PerformClick();
            }
            else if (e.KeyCode == Keys.P) // Potência
            {
                btnPotencia.PerformClick();
            }
        }
    }
}
