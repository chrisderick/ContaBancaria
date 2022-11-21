using System;
using System.Drawing;

namespace ContaBancaria
{
    public class Conta
    {


        private int v;

        public Conta()
        {
        }

        public int Numero { get; set; }
        public double Saldo { get; private set; }
        public int V { get; }
        internal Cliente Titular { get; set; }


        public Conta(int s)
        {
            this.Saldo = s;
        }

        public void Deposita(double valorOperacao)
        {
            this.Saldo += valorOperacao;

        }

        internal bool Saca(double valorOperacao)
        {
            if (valorOperacao <= this.Saldo)
            {
                this.Saldo -= valorOperacao;
                return true;
            }
            else
            {
                return false;
            }
            //this.Saldo -= valorOperacao;
        }


    }
}