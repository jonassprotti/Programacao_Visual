using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qui_2021_1_Lacos
{
    public partial class Form1 : Form
    {
        Suporte sup = new Suporte();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                lblRes.Text += i.ToString() + "º  ";
            }

            for (int i = 10; i >= 1; i--)
            {
                lblRes2.Text += i.ToString() + "º  ";
            }
        }

        private void btnDias_Click(object sender, EventArgs e)
        {
            lstRes.Items.Clear();
            lstRes.Items.Add("DIAS DA SEMANA: ");
            for (int dia = 1; dia <= 7; dia++)
            {
                lstRes.Items.Add(sup.DiaSemana(dia));
            }
        }

        private void btnMeses_Click(object sender, EventArgs e)
        {
            lstRes.Items.Clear();
            lstRes.Items.Add("MESES DO ANO: ");
            int mes = 1;
            while (mes <= 12)
            {
                lstRes.Items.Add(sup.MesExtenso(mes));
                mes++;
            }
        }

    }
}
