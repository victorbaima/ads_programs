using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_media
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double n1, n2, n3, media;
            n1 = Convert.ToDouble(txtNota1.Text);
            n2 = Convert.ToDouble(txtNota2.Text);
            n3 = Convert.ToDouble(txtNota3.Text);
            media = (n1 + n2 + n3) / 3;
            txtMedia.Text = media.ToString();

            if (media < 5)
                MessageBox.Show("O aluno foi reprovado!");
            else if (media >= 7)
                MessageBox.Show("O aluno foi aprovado!!!");
            else
                MessageBox.Show("O aluno ficou de recuperação!");

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNota1.Text = "";
            txtNota2.Text = "";
            txtNota3.Text = "";
            txtMedia.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
