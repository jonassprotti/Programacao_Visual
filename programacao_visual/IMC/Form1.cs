using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double peso, altura, imc;
            peso =Convert.ToDouble(txtPeso.Text);
            altura = Convert.ToDouble(txtAltura.Text);
            imc = peso / (altura * altura);

            lblResultado.Text = imc.ToString("F");

            string res = "";

            if(imc < 17)
            {
                res = "Você está muito abaixo do peso ideal!";
                picIMC.Load("..\\..\\Imagens\\imc01.png");
                lblResultado.ForeColor = Color.FromArgb(255, 0, 0);

            }
            else if (imc < 18.5)
            {
                res = "Você está abaixo do peso ideal!";
                picIMC.Load("..\\..\\Imagens\\imc02.png");
                lblResultado.ForeColor = Color.FromArgb(145, 0, 0);
            }
            else if (imc < 25)
            {
                res = "Parabéns! Você está em seu peso ideal!";
                picIMC.Load("..\\..\\Imagens\\imc03.png");
                lblResultado.ForeColor = Color.FromArgb(0, 0, 0);
            }
            else if (imc < 30)
            {
                res = "Você está acima do seu peso ideal!";
                picIMC.Load("..\\..\\Imagens\\imc04.png");
                lblResultado.ForeColor = Color.FromArgb(50, 0, 0);
            }
            else if (imc < 35)
            {
                res = "Obsidade Grau I";
                picIMC.Load("..\\..\\Imagens\\imc05.png");
                lblResultado.ForeColor = Color.FromArgb(100, 0, 0);
            }
            else if (imc < 40)
            {
                res = "Obsidade Grau II";
                picIMC.Load("..\\..\\Imagens\\imc06.png");
                lblResultado.ForeColor = Color.FromArgb(145, 0, 0);
            }
            else
            {
                res = "Obsidade Grau III (morbida)";
                picIMC.Load("..\\..\\Imagens\\imc07.png");
                lblResultado.ForeColor = Color.FromArgb(255, 0, 0);
            }
            this.lblResultado.Text = imc.ToString("N2") + " - " + res;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
