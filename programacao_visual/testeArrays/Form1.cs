using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testeArrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lstResultados.Items.Clear();

            int i, j;

            string[] estados = new string[] {  "São Paulo", "Minas Gerais", "Rio de Janeiro", "Espírito Santo", "Amazonas", "Goiás","Amapá" };

            for (i = 0; i < estados.Length; i++)//Percorre as linhas
            { 
                lstResultados.Items.Add((i+1).ToString() + "º " + estados[i]);
            }
        }

        private void btnMostrarNomes_Click(object sender, EventArgs e)
        {
            lstResultados.Items.Clear();

            int lin, col;

            string[,] produtos = new string[,] {
                { "Refrigerante", "Coca-Cola", "4.5" },
                { "Refrigerante", "Guaraná", "3.5" },
                { "Cerveja", "Brahma Duplo Malte", "3.59" },
                { "Cerveja", "Colorado", "2.7" }
            };

            
            for(lin = 0; lin < produtos.Length/3; lin++)
            {
                string txt = "";
                for (col = 0; col < 3; col++)
                {
                    txt += produtos[lin, col] + " | ";
                }
                lstResultados.Items.Add(txt);
            }
            
        }

        private void btnFuncoes_Click(object sender, EventArgs e)
        {
            DateTime dataEntrada = DateTime.Now;
            int anoNascimento = Convert.ToInt32(txtAnoNascimento.Text);
            lstResultados.Items.Clear();
            lstResultados.Items.Add("Data/Hora:  " + dataEntrada.ToString());
            lstResultados.Items.Add("Idade:          " + calculaIdade(anoNascimento));
        }

        private string calculaIdade(int v)
        {
            int i = 2021 - v;
            string ret = i.ToString() + ((i > 1) ? " anos" : " ano");
            return ret;
        }
    }
}
