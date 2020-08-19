using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaSuficiencia
{
    public partial class FormPassageiros : Form
    {
        public FormPassageiros()
        {
            InitializeComponent();
        }

        private void SetDataGridView()
        {
            dgvPassageiros.Columns[0].Name = "Passageiro";
            dgvPassageiros.Columns[1].Name = "Idade";
            dgvPassageiros.Columns[2].Name = "Motorista";

            if (Program.viagens.Count > 0 && Program.passageiros.Count > 0)
            {
                foreach (var viagem in Program.viagens)
                {
                    foreach (var passageiro in viagem.passageiros)
                    {
                        dgvPassageiros.Rows.Add(passageiro.GetNome());
                        dgvPassageiros.Rows.Add(passageiro.GetIdade());
                        dgvPassageiros.Rows.Add(viagem.GetNomeMotorista());
                    }
                }
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            SetDataGridView();
        }

        protected override void OnClick(EventArgs e)
        {
            SetDataGridView();
        }
    }
}
