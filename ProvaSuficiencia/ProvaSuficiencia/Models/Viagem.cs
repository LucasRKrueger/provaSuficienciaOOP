using System;
using System.Collections.Generic;
using System.Linq;

namespace WindowsFormsApp1
{
    //Lucas Rodrigo Krueger
    [Serializable]
    public abstract class Viagem
    {
        private string PlacaOnibus { get; set; }
        private string NomeMotorista { get; set; }
        private DateTime DataViagem { get; set; }
        private int HoraViagem { get; set; }
        public List<Passageiro> passageiros { get; set; }
        public abstract int LimitePassageiro {get; set;}

        public Viagem(string placaOnibus, string nomeMotorista, DateTime dataViagem, int horaViagem)
        {
            PlacaOnibus = placaOnibus;
            NomeMotorista = nomeMotorista;
            DataViagem = dataViagem;
            HoraViagem = horaViagem;
        }

        public void AddPassageiro(Passageiro passageiro)
        {
            if (passageiros is null)
            {
                passageiros = new List<Passageiro>();
                passageiros.Add(passageiro);
            }
            else
                passageiros.Add(passageiro);
        }

        public virtual float GetValorTotal() { return passageiros.Sum(p => p.GetTarifa()); }
        public string GetNomeMotorista() { return NomeMotorista; }
        public string GetPlacaOnibus() {return PlacaOnibus; }
        public int GetHoraViagem() { return HoraViagem; }
        public DateTime GetDataViagem() { return DataViagem; }

        public List<Passageiro> GetPassageiros(){ return passageiros; }
    }
}
