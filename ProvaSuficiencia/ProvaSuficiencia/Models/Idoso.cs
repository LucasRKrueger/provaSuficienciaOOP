using System;

namespace WindowsFormsApp1
{
    //Lucas Rodrigo Krueger
    public class Idoso : Passageiro
    {              
        public string Rg { get; set; }

        public Idoso(string nome, string telefone, int idade, string rg) 
              : base(nome, telefone, idade)
        {
            Rg = rg;
        }

        public float GetTarifa()
        {
            return 0;
        }
    }
}
