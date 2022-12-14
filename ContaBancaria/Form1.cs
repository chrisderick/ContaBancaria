using System;
using System.Windows.Forms;

namespace ContaBancaria
{
    public partial class Form1 : Form
    {
        private Conta contaSelecionada;
        private Conta[] contas = new Conta[3];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            {
                contas[0] = new Conta(500);
                contas[0].Titular = new Cliente("Christhyan");
                contas[0].Numero = 1;

                contas[1] = new ContaPoupanca(400);
                contas[1].Titular = new Cliente("Caio");
                contas[1].Numero = 2;

                contas[2] = new ContaCorrente(450);
                contas[2].Titular = new Cliente("Guilherme");
                contas[2].Numero = 3;

                foreach (Conta conta in contas)
                {
                    comboContas.Items.Add(conta.Titular.Nome);
                }

                //conta = new ContaCorrente(500);
                //conta.Numero = 1;
                //Cliente cliente = new Cliente("Christhyan");
                //conta.Titular = cliente;

                //textoTitular.Text = conta.Titular.Nome;
                //textoNumero.Text = Convert.ToString(conta.Numero);
                //textoSaldo.Text = conta.Saldo.ToString("F");
            }
        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            this.contaSelecionada = contas[indice];

            textoNumero.Text = Convert.ToString(contaSelecionada.Numero);
            textoTitular.Text = contaSelecionada.Titular.Nome;
            textoSaldo.Text = Convert.ToString(contaSelecionada.Saldo);
        }

        private void botaoDeposito_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            contaSelecionada.Deposita(valorOperacao);

            MessageBox.Show("Sucesso");
            RecarregarJanela();
        }

        private void botaoSaque_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);

            if (contaSelecionada.Saca(valorOperacao))
                MessageBox.Show("O saque foi efetuado com sucesso !");
            else
                MessageBox.Show("O saldo não é suficiente para o saque !");

            RecarregarJanela();
        }

        private void RecarregarJanela()
        {
            textoSaldo.Text = contaSelecionada.Saldo.ToString("F");
            textoValor.Text = null;
        }

        private void botaoTotal_Click(object sender, EventArgs e)
        {
            //Pode ser substituído por uma variável e um forEach simples no saldo das contas;

            TotalizadorDeContas totalizadorDeContas = new TotalizadorDeContas();
            foreach (Conta c in contas)
                totalizadorDeContas.Adiciona(c);

            MessageBox.Show("Saldo total de contas: " + totalizadorDeContas.SaldoTotal);
        }
    }
}
