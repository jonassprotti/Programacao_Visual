using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_18_03_21
{
    public partial class FrmMedia : Form
    {
        public FrmMedia()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double nota1, nota2, nota3, media;

            nota1 = Convert.ToDouble(txtNota1.Text);
            nota2 = Convert.ToDouble(txtNota2.Text);
            nota3 = Convert.ToDouble(txtNota3.Text);

            media = (nota1 + nota2 + nota3) / 3;

            if(media >= 7.0)
            {
                lblResposta.Text = "Sua média é " + Math.Round(media, 2) + ", você foi aprovado!";
            }
            else
            {
                lblResposta.Text = "Sua média é " + Math.Round(media, 2) + ", você foi reprovado!";
            }

            lblResposta.Visible = true;
        }
    }
}
