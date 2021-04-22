using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lacos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDias_Click(object sender, EventArgs e)
        {
            for(int dia = 1; dia <= 7; dia++)
            {
                lstResposta.Items.Add(diaSemana(dia));
            }
        }

        private String diaSemana(int dia)
        {
            string[] sDias = { "Domingo", "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado" };

            return sDias[dia - 1];
        }
    }
}
