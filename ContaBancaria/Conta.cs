using System;
using System.Drawing;

namespace ContaBancaria
{
    public class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; private set; }
        public int Tipo { get; set; }
        internal Cliente Titular { get; set; }

        public Conta()
        {
        }

        public Conta(int saldo)
        {
            Saldo = saldo;
        }

        public virtual void Deposita(double valor)
        {
            Saldo += valor;
        }

        public virtual bool Saca(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
                return true;
            }
            else
                return false;
        }


    }
}