using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiraCalculadora
{
    public partial class FrmCalculadora : Form
    {
        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void txtValorA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente número e vírgula");
            }
        }

        private void txtValorB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente número e vírgula");
            }
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            Double v1 = Convert.ToDouble(txtValorA.Text);
            Double v2 = Convert.ToDouble(txtValorB.Text);
            Double resultado = v1 + v2;
            lblResultado.Text = resultado.ToString();
            lblResultado.Visible = true;
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            Double v1 = Convert.ToDouble(txtValorA.Text);
            Double v2 = Convert.ToDouble(txtValorB.Text);
            Double resultado = v1 - v2;
            lblResultado.Text = resultado.ToString();
            lblResultado.Visible = true;
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            Double v1 = Convert.ToDouble(txtValorA.Text);
            Double v2 = Convert.ToDouble(txtValorB.Text);
            Double resultado = v1 * v2;
            lblResultado.Text = resultado.ToString();
            lblResultado.Visible = true;
        }

        private void btnSubtração_Click(object sender, EventArgs e)
        {
            Double v1 = Convert.ToDouble(txtValorA.Text);
            Double v2 = Convert.ToDouble(txtValorB.Text);
            Double resultado = v1 / v2;
            lblResultado.Text = resultado.ToString();
            lblResultado.Visible = true;
        }

        private void FrmCalculadora_Load(object sender, EventArgs e)
        {

        }
    }
}
