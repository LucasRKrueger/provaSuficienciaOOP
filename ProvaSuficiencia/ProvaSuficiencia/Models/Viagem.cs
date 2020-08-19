using System;
using System.Collections.Generic;
using System.Linq;

namespace WindowsFormsApp1
{
    //Lucas Rodrigo Krueger
    public class Viagem
    {
        private string PlacaOnibus { get; set; }
        private string NomeMotorista { get; set; }
        private DateTime DataViagem { get; set; }
        private int HoraViagem { get; set; }
        public List<Passageiro> passageiros { get; set; }

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

        public float GetValorTotal()
        {
            return passageiros.Sum(p => p.GetTarifa());
        }

        public string GetNomeMotorista() {return NomeMotorista;}
        public string GetPlacaOnibus() {return PlacaOnibus; }


        public List<Passageiro> GetPassageiros()
        {
            return passageiros;
        }
    }
}
