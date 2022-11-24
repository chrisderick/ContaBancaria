using System.Diagnostics.Eventing.Reader;
using System.Linq;

namespace ContaBancaria
{
    internal class Cliente
    {
        private string v;

        public string Nome { get; private set; }

        public int Idade { get; set; }
        public string Documentos { get; set; }
        public string Cpf { get; set; }
        

        public bool PodeAbrirContaSozinho
        {
            get
            {
                return (Idade >= 18 ||
                Documentos.Contains("emancipacao")) &&
                    !string.IsNullOrEmpty(Cpf);
            }
        }
        /*
        public bool MaiorIdade()

        {
            return (this.idade >= 18);
        }
        */

        public Cliente(string v)
        {
            Nome = v;
        }

        
    }
}