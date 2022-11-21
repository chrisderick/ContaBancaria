using System.Diagnostics.Eventing.Reader;
using System.Linq;

namespace ContaBancaria
{
    internal class Cliente
    {
        private string v;

        public string Nome { get; private set; }

        public int idade { get; set; }
        public string documentos { get; set; }
        public string cpf { get; set; }
        

        public bool PodeAbrirContaSozinho()
        {

            return (this.idade >= 18 ||
            this.documentos.Contains("emancipacao")) &&
                !string.IsNullOrEmpty(this.cpf);
            
        }
        /*
        public bool MaiorIdade()

        {
            return (this.idade >= 18);
        }
        */

        public Cliente(string v)
        {
            this.Nome = v;
        }

        
    }
}