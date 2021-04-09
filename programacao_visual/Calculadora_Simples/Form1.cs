using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Simples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {
            try
            {
                double x, y, resultado = 0;
                x = Convert.ToDouble(txtX.Text);
                y = Convert.ToDouble(txtY.Text);

                if (rbSomar.Checked)
                {
                    resultado = x + y;
                }
                if (rbSubtrair.Checked)
                {
                    resultado = x - y;
                }
                if (rbMultiplicar.Checked)
                {
                    resultado = x * y;
                }
                if (rbDividir.Checked)
                {
                    resultado = x / y;
                    if (y == 0)
                    {
                        txtTotal.Text = "Divisão por zero";
                        return;
                    }

                }
                txtTotal.Text = resultado.ToString();
            }
            catch(Exception erro)
            {
                MessageBox.Show("Preencha os campos!");
            }
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtX.Text = "";
            txtY.Text = "";
            txtTotal.Text = "";
            rbSomar.Checked = false;
            rbSubtrair.Checked = false;
            rbMultiplicar.Checked = false;
            rbDividir.Checked = false;
            txtX.Focus();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Informe um valor válido", "Calculadora", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                //MessageBox.Show("Informe um valor válido", "Calculadora", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
