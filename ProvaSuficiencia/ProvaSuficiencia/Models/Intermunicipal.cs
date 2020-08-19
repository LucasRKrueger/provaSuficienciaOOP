using System;

namespace WindowsFormsApp1
{
    //Lucas Rodrigo Krueger
    public class Intermunicipal : Viagem
    {
        public Intermunicipal(string placaOnibus, string nomeMotorista, DateTime dataViagem, int horaViagem) 
                       : base(placaOnibus, nomeMotorista, dataViagem, horaViagem){}

        public void AddPassageiro(Passageiro passageiro)
        {
            base.AddPassageiro(passageiro);
        }

        public float GetValorTotal()
        {
            return base.GetValorTotal() * 3.15f;
        }
    }
}
