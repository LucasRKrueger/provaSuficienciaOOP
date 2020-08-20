using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace ProvaSuficiencia
{
    public partial class Form1 : Form
    {
        //Lucas Rodrigo Krueger
        public Form1()
        {
            InitializeComponent();
        }

        private void btnViagem_Click(object sender, EventArgs e)
        {
            new FormViagens().Show();
            this.Hide();
        }

        protected override void OnLoad(EventArgs e)
        {
            if (Program._viagens.Count < 1)
            {
                try
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();

                    FileStream fileStream = new FileStream("registro.bin", FileMode.Open, FileAccess.Read, FileShare.None);

                
                    using (fileStream)
                    {
                        Program._viagens = (List<Viagem>)binaryFormatter.Deserialize(fileStream);
                        MessageBox.Show("Arquivo carregado com sucesso");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nenhum arquivo salvo encontrado.");
                }
            }
        }
    }
}
