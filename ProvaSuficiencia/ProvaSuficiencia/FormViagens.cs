using System;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace ProvaSuficiencia
{
    public partial class FormViagens : Form
    {
        public FormViagens(Viagem viagem = null)
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            new FormCadastroViagens().Show();
        }

        private void SetDataGridView()
        {
            dgvPassageiros.ColumnCount = 3;
            dgvPassageiros.ColumnHeadersVisible = true;

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
                        dgvPassageiros.Rows.Add(passageiro.GetIdade().ToString());
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
