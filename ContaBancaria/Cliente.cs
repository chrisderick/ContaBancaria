using System.Diagnostics.Eventing.Reader;
using System.Linq;

namespace ContaBancaria
{
    internal class Cliente
    {
        public string Nome { get; private set; }

        public int Idade { get; set; }
        public string Documentos { get; set; }
        public string Cpf { get; set; }


        public Cliente(string nome)
        {
            Nome = nome;
        }

        //public bool PodeAbrirConta
        //{
        //    get
        //    {
        //        return (Idade >= 18 ||
        //        Documentos.Contains("emancipacao")) &&
        //            !string.IsNullOrEmpty(Cpf);
        //    }
        //}


    }
}