using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace ProvaSuficiencia
{
    static class Program
    {
        //Lucas Rodrigo Krueger
        public static List<Passageiro> _passageiros = new List<Passageiro>();
        public static List<Viagem> _viagens = new List<Viagem>();

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
