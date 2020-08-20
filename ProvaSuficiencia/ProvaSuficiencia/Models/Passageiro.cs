using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1
{
    //Lucas Rodrigo Krueger
    [Serializable]
    public class Passageiro
    {
        private string Nome { get; set; }
        private string Telefone { get; set; }
        private int Idade { get; set; }
        private float TarifaInteira { get; set; } = 5.0f;

        public Passageiro (string nome, string telefone, int idade)
        {
            Nome = nome;
            Telefone = telefone;
            Idade = idade;
        }

        public virtual float GetTarifa() { return TarifaInteira; }
        public string GetNome(){ return Nome; }
        public int GetIdade() { return Idade; }
        public string GetTelefone() { return Telefone; }

        public string GerarCSV()
        {
            return $"P, {Nome}, {Telefone}, {Idade}";
        }
    }
}
