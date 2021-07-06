using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[4];
            vetor[0] = 7;
            vetor[1] = 3;
            vetor[2] = 5;
            vetor[3] = 1;
            int valor = vetor[1];
            System.Array.Sort(vetor);
            for (int index = 0; index < 4; index++)
                MessageBox.Show(vetor[index].ToString(), "Array");
            
            /*
             * Declarar e instanciar vetores
             * Atribuição de valores de acordo com cada índice
             * Declara a variável "valor" para acessar o vetor
             * System.Array.Sort - Esta classe ordena o vetor
             * Comando for - Percorre o vetor em cada índice
             * Condição - Para index menor que 4 ele exibe uma mensagem
             * com o vetor na MessageBox.
             */

        }

        private void btnVetorTextos_Click(object sender, EventArgs e)
        {
            string[] semana = new string[7];
            semana[0] = "Domingo";
            semana[1] = "Segunda-Feira";
            semana[2] = "Terça-Feira";
            semana[3] = "Quarta-Feira";
            semana[4] = "Quinta-Feira";
            semana[5] = "Sexta-Feira";
            semana[6] = "Sábado";

            string valor = semana[1];
            for (int index = 0; index <= 7; index++)
                MessageBox.Show(semana[index].ToString(), "Array");

            /*
             * Declarar e instanciar vetores
             * Atribuição de valores de acordo com cada índice
             * Nesse caso as variáveis são dias da semana (string)
             * Declara a variável "valor" para acessar o vetor
             * Por se tratar de string não será necessário ordenar
             * Comando for - Percorre o vetor em cada índice
             * Condição - Para index menor ou igual a 7, ele exibe uma mensagem
             * com o vetor na MessageBox.
             */

        }
    }
}
