using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MesDataExtenso
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void ExibeDataExtenso(object sender, EventArgs e)
        {
            int dia, mes, ano;

       
            lblResultado.Text = "São Paulo, ";
            

            if(Convert.ToInt32(txtDia.Text) > 0 && Convert.ToInt32(txtDia.Text) <= 31)
            {
                dia = Convert.ToInt32(txtDia.Text);
                lblResultado.Text += txtDia.Text;
            }
            if (!txtMes.Text.Equals(""))
            {
                mes = Convert.ToInt32(txtMes.Text);
                
                switch (mes)
                {
                    case 1: lblResultado.Text += " de Janeiro"; break;
                    case 2: lblResultado.Text += " de Fevereiro"; break;
                    case 3: lblResultado.Text += " de Março"; break;
                    case 4: lblResultado.Text += " de Abril"; break;
                    case 5: lblResultado.Text += " de Maio"; break;
                    case 6: lblResultado.Text += " de Junho"; break;
                    case 7: lblResultado.Text += " de Julho"; break;
                    case 8: lblResultado.Text += " de Agosto"; break;
                    case 9: lblResultado.Text += " de Setembro"; break;
                    case 10: lblResultado.Text += " de Outubro"; break;
                    case 11: lblResultado.Text += " de Novembro"; break;
                    case 12: lblResultado.Text += " de Dezembro"; break;
                    default: lblResultado.Text += " de ?"; break; 


                }
            }
            if (!txtAno.Text.Equals(""))
            {
                ano = Convert.ToInt32(txtAno.Text);
                lblResultado.Text += " de " + txtAno.Text;
            }

        }
    }
}
