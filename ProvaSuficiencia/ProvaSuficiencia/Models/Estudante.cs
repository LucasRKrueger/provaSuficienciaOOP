using System;

namespace WindowsFormsApp1
{
    //Lucas Rodrigo Krueger
    [Serializable]
    public class Estudante : Passageiro
    {
        private string Escola { get; set; }        

        public Estudante(string nome, string telefone, int idade, string escola) 
                  : base(nome, telefone, idade)
        {            
            Escola = escola;
        }

        public override float GetTarifa()
        {
            return  base.GetTarifa() * 0.5f;
        }

        public string GerarCSV()
        {
            return $"E, {GetNome()}, {GetTelefone()}, {GetIdade()}, {Escola}";
        }
    }
}
