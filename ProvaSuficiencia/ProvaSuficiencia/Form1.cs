using System;
using System.Windows.Forms;

namespace ProvaSuficiencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnViagem_Click(object sender, EventArgs e)
        {
            new FormViagens().Show();
            this.Hide();
        }
    }
}
