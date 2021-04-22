using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qui_2021_1_Animais
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.SelectedItem)
            {
                case "Gato":
                    pictureBox1.Load("..\\..\\Imagens\\gato.jpg");
                    break;
                case "Cachorro":
                    pictureBox1.Load(@"..\..\Imagens\cachorro.jpg");
                    break;
                case "Onça":
                    pictureBox1.Load(@"..\..\Imagens\onca.jpg");
                    break;
                default:
                    break;
            }

        }
    }
}
