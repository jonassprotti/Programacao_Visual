using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animais
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex.Equals(0))
            {
                pictureBox1.Load("https://s2.glbimg.com/MRvxwNk-tYkvrnJihlxI3A-bkm0=/0x0:2000x1500/984x0/smart/filters:strip_icc()/s.glbimg.com/jo/g1/f/original/2019/01/14/img_7549_felino_aJjLrq4.jpg");
            }
            if (listBox1.SelectedIndex.Equals(1))
            {
                pictureBox1.Load("https://static.poder360.com.br/2020/04/tigre-olhando-com-a-boca-aberta-626x630.jpg");
            }
            if (listBox1.SelectedIndex.Equals(2))
            {
                pictureBox1.Load("https://d168rbuicf8uyi.cloudfront.net/wp-content/uploads/2019/06/13145802/sonhar-com-leao-1024x649.jpg");
            }
        }
    }
}
