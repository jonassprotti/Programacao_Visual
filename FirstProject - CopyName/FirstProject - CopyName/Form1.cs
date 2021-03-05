using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstProject___CopyName
{
    public partial class FrmNameCopier : Form
    {
        public FrmNameCopier()
        {
            InitializeComponent();
        }

        private void FrmNameCopier_Load(object sender, EventArgs e)
        {

        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            //Inserindo o nome e concatenando com o Sobrenome, após isso deixo visível a Label onde está sendo colocado
            lblResultado.Text = txtNome.Text + " " + txtSobrenome.Text;
            lblResultado.Visible = true;

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Limpando os campos da tela
            txtNome.Clear();
            txtSobrenome.Clear();
            lblResultado.Visible = false;
        }
    }
}
