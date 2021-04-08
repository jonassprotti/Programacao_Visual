﻿using System;
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
            }
            txtTotal.Text = resultado.ToString();
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
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}