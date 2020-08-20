using System;
using System.Collections.Generic;
using System.Linq;

namespace WindowsFormsApp1
{
    //Lucas Rodrigo Krueger
    [Serializable]
    public class Empresa
    {
        public List<Viagem> Viagens { get; set; }
        public List<Passageiro> GetPassageirosMaisVelhos()
        {
            return Viagens.Select(p => p.passageiros).SelectMany(p => p)
                          .OrderByDescending(p => p.GetIdade())
                          .ThenBy(p => p.GetNome()).ToList();
        }
    }
}
