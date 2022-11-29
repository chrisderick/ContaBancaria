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
        private Conta conta;

        public bool PodeAbrirContaSozinho { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            {
                conta = new ContaCorrente(500);
                conta.Numero = 1;
                Cliente cliente = new Cliente("Christhyan");
                conta.Titular = cliente;

                textoTitular.Text = conta.Titular.Nome;
                textoNumero.Text = Convert.ToString(conta.Numero);
                textoSaldo.Text = conta.Saldo.ToString("F");

                TotalizadorDeContas totalizadorDeContas = new TotalizadorDeContas();
                totalizadorDeContas.Adiciona(conta);
                MessageBox.Show("Saldo total de contas: " + totalizadorDeContas.SaldoTotal);
            }
        }

        private void botaoDeposito_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            conta.Deposita(valorOperacao);
            MessageBox.Show("Sucesso");

            RecarregarJanela();
        }

        private void botaoSaque_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);

            if (conta.Saca(valorOperacao))
                MessageBox.Show(" O saque foi efetuado com sucesso ! ");
            else
                MessageBox.Show(" O saldo não é suficiente para o saque ! ");

            RecarregarJanela();
        }

        private void RecarregarJanela()
        {
            textoSaldo.Text = conta.Saldo.ToString("F");
            textoValor.Text = null;
        }

        private void textoIdade_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
