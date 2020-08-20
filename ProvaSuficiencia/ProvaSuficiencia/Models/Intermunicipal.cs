using System;

namespace WindowsFormsApp1
{
    //Lucas Rodrigo Krueger
    [Serializable]
    public class Intermunicipal : Viagem
    {
        public Intermunicipal(string placaOnibus, string nomeMotorista, DateTime dataViagem, int horaViagem) 
                       : base(placaOnibus, nomeMotorista, dataViagem, horaViagem){}

        public override int LimitePassageiro { get; set; } = 22;

        public void AddPassageiro(Passageiro passageiro)
        {
            base.AddPassageiro(passageiro);
        }

        public override float GetValorTotal()
        {
            return base.GetValorTotal() + (GetPassageiros().Count * 3.15f);
        }
    }
}
