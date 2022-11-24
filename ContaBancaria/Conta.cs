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
            Saldo = s;
        }

        public void Deposita(double valor)
        {
            Saldo += valor;
        }

        internal bool Saca(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
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