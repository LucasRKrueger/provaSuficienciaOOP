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
                        if (dgvPassageiros.Rows.Count > 1)
                        {
                            for (int i = 0; i < dgvPassageiros.Rows.Count ; i++)
                            {
                                if (!IsRowDuplicated(i, passageiro, viagem))
                                {
                                    dgvPassageiros.Rows.Add(passageiro.GetNome(), passageiro.GetIdade().ToString(), viagem.GetNomeMotorista());
                                }
                            }
                        }
                        else
                        {
                            dgvPassageiros.Rows.Add(passageiro.GetNome(), passageiro.GetIdade().ToString(), viagem.GetNomeMotorista());
                        }
                    }
                }
            }
        }

        private bool IsRowDuplicated(int index, Passageiro passageiro, Viagem viagem)
        {
            return CellIsNull(index) || dgvPassageiros.Rows[index].Cells[0].Value.ToString() == passageiro.GetNome() &&
                   dgvPassageiros.Rows[index].Cells[1].Value.ToString() == passageiro.GetIdade().ToString() &&
                   dgvPassageiros.Rows[index].Cells[2].Value.ToString() == viagem.GetNomeMotorista();
        }

        private bool CellIsNull(int index)
        {
            return dgvPassageiros.Rows[index].Cells[0].Value is null ||
                   dgvPassageiros.Rows[index].Cells[1].Value is null ||
                   dgvPassageiros.Rows[index].Cells[2].Value is null;
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
