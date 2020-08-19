using System;

namespace WindowsFormsApp1
{
    //Lucas Rodrigo Krueger
    public class Municipal : Viagem
    {        
        public Municipal(string placaOnibus, string nomeMotorista, DateTime dataViagem, int horaViagem) 
            : base(placaOnibus, nomeMotorista, dataViagem, horaViagem){}

        public void AddPassageiro(Passageiro passageiro)
        {
            base.AddPassageiro(passageiro);
        }

    }
}
