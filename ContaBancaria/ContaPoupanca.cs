namespace ContaBancaria
{
    public class ContaPoupanca : Conta
    {
        public ContaPoupanca(int s) : base(s)
        {
        }

        public override bool Saca(double valor)
        {
            return base.Saca(valor + 0.10);
        }
    }
}
