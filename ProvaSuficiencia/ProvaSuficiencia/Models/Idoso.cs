using System;

namespace WindowsFormsApp1
{
    //Lucas Rodrigo Krueger
    [Serializable]
    public class Idoso : Passageiro
    {              
        public string Rg { get; set; }

        public Idoso(string nome, string telefone, int idade, string rg) 
              : base(nome, telefone, idade)
        {
            Rg = rg;
        }

        public override float GetTarifa()
        {
            return 0;
        }

        public  string GetTelefone()
        {
            return base.GetTelefone();
        }

        public string GerarCSV()
        {
            return $"I, {GetNome()}, {GetTelefone()}, {GetIdade()}, {Rg}";
        }
    }
}
