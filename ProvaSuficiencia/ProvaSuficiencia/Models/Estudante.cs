using System;

namespace WindowsFormsApp1
{
    //Lucas Rodrigo Krueger
    public class Estudante : Passageiro
    {
        private string Escola { get; set; }        

        public Estudante(string nome, string telefone, int idade, string escola) 
                  : base(nome, telefone, idade)
        {            
            Escola = escola;
        }

        public float GetTarifa()
        {
            return base.GetTarifa() * 0.5f;
        }
    }
}
