namespace ContaBancaria
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente(int s) : base(s)
        {
        }

        public override void Deposita(double valor)
        {
            base.Deposita(valor - 0.10);
        }

        public override bool Saca(double valor)
        {
            return base.Saca(valor - 0.05);
        }
    }
}
