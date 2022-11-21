using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContaBancaria
{
    public partial class Form1 : Form
    {
        private Conta c;

        public bool PodeAbrirContaSozinho { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            {

                this.c = new Conta(500);
                //Conta c = new Conta();
                c.Numero = 1;
                Cliente cliente = new Cliente("victor");
                c.Titular = cliente;


                textoTitular.Text = c.Titular.Nome;
                textoNumero.Text = Convert.ToString(c.Numero);
                //textoSaldo.Text = Convert.ToString(c.Saldo);
                textoSaldo.Text = Convert.ToString(this.c.Saldo);
            }
        }

        private void botaoDeposito_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            this.c.Deposita(valorOperacao);
            textoSaldo.Text = Convert.ToString(this.c.Saldo);
            MessageBox.Show("Sucesso");
            textoValor.Text = null;


        }

        private void botaoSaca_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            //this.c.Saca(valorOperacao);

            if (this.c.Saca(valorOperacao))
            //if (resultado)
            {
                MessageBox.Show(" O saque foi efetuado com sucesso ! ");
            }
            else
            {
                MessageBox.Show(" O saldo não é suficiente para o saque ! ");
            }

            textoSaldo.Text = Convert.ToString(this.c.Saldo);
            //MessageBox.Show("Sucesso");
        }

        private void button3_Click(object sender, EventArgs e)
        {

            /*
            string valorIdade = textoIdade.Text;
            this.c.Titular.idade = Convert.ToInt16(valorIdade);
            this.c.Titular.PodeAbrirContaSozinho();
            textoIdade.Text = valorIdade;
            string valorEmancipado = textoEmancipado.Text;
            this.c.Titular.PodeAbrirContaSozinho();
            textoEmancipado.Text = valorEmancipado;
            string valorCpf = textoCPF.Text;
            this.c.Titular.PodeAbrirContaSozinho();
            textoCPF.Text = valorCpf ;
            */


            string valorIdade = textoIdade.Text;
            this.c.Titular.idade = int.Parse(valorIdade);
            //this.c.Titular.PodeAbrirContaSozinho();
            //textoIdade.Text = valorIdade;
            //valorIdade = textoIdade.Text;

            string valorEmancipado = textoEmancipado.Text;
            this.c.Titular.documentos = Convert.ToString(valorEmancipado);
            //this.c.Titular.PodeAbrirContaSozinho();
            //textoEmancipado.Text = valorEmancipado;
            //valorEmancipado = textoEmancipado.Text;

            string valorCpf = textoCPF.Text;
            this.c.Titular.cpf = Convert.ToString(valorCpf);
            //this.c.Titular.PodeAbrirContaSozinho();
            //textoCPF.Text = valorCpf;
            //valorCpf = textoCPF.Text;


            /*
            // CPF
            c.Titular.cpf = textoCPF.Text;
            //Idade
            c.Titular.idade = int.Parse(textoIdade.Text);
            //Emancipado
            c.Titular.documentos = textoEmancipado.Text;
            */

            //bool resultado = c.Titular.PodeAbrirContaSozinho();
            //bool idade = c.Titular.MaiorIdade();

            if (c.Titular.PodeAbrirContaSozinho())
            //if (resultado)
            {
                MessageBox.Show(" Você pode abrir a conta ! ");
            }
            else
            {
                MessageBox.Show(" Infelizmente a conta não poderá ser aberta ! ");
            }

        }

        private void textoIdade_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
