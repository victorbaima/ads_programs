using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conceito_Do_While
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            int c = 0;
            do
            {
                c = c + 1;
                label1.Text = Convert.ToString(c);
                label1.Refresh();
            }
            while (c < 10000);

            /*Sempre executa pois a condição só aparece no final, só é utilizado quando é necessário testar a condição depois.*/
        }
    }
}
