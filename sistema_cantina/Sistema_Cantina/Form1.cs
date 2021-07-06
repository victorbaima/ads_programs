using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Cantina
{
    public partial class Form1 : Form
    {
        string[] produtos = new string[10];
        string[] codigo = new string[10];
        double[] valor = new double[10];
        double soma;

        /*
         * Declaração de 3 arrays para armazenar 10 produtos,
         * e seus respectivos códigos e valores.
         */

        public Form1()
        {
            InitializeComponent();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length == 3)
            { 

           /*
            * Inicia com uma condição, se o usuário digitar um código
            * com 3 caracteres (length), esse código é adicionado ao
            * listBox.
            * A propriedade length retorna a quantidade de caracteres.
            */

                int indice = 0;
                for (int prod = 1; prod < codigo.Length; prod++)
                /*Faça enquanto o prod for menor que a quantidade de itens
                 * do array*/
                {
                    if (txtCodigo.Text == codigo[prod])
                    {
                        indice = prod;

                    }
                }
                if (indice == 0)
                {
                    MessageBox.Show("Produto não encontrado!");

                    /*
                     * Condição se foi encontrado o produto ele retorna
                     * as informações de acordo com o índice.
                     * Caso não encontre, aparecerá a mensagem: Produto não
                     * encontrado!
                     */

                }
                else
                {
                    lstCaixa.Items.Add(txtCodigo.Text + " -- " + produtos[indice] + "-- R$ " + valor[indice]);
                    /*
                     * Conteúdo adicionado ao ListBox, concatena (+) as infor-
                     * mações (código/nome/valor).
                     */

                    soma = soma + valor[indice];
                    label1.Text = ("Valor Total R$ " + soma);
                    picImagem.ImageLocation = "c:/imagem/" + codigo[indice] + ".jpg";
                    txtCodigo.Text = "";
                    txtCodigo.Focus();

                    /*
                     * Localização da imagem que deve ser colocada em uma pasta
                     * Imagem
                     * O listBox, o textbox será limpo e o Focus posiciona o 
                     * cursor no TextBox para uma nova digitação.
                     */
                }
                        
            }
           
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            carregarArray();
            soma = 0;
        }
        
         // Ao entrar no Form1Load será chamado o método
         

        private void carregarArray()
        /*
         * Criação do método para ser chamado quando necessário,
         * isso evita repetir várias vezes o mesmo código.
         */
                    {
            codigo[1] = "001";
            codigo[2] = "002";
            codigo[3] = "003";
            codigo[4] = "004";
            codigo[5] = "005";

            produtos[1] = "Pastel";
            produtos[2] = "Coxinha";
            produtos[3] = "Hot Dog";
            produtos[4] = "Chocolate";
            produtos[5] = "Suco";

            valor[1] = 6.00;
            valor[2] = 5.00;
            valor[3] = 12.00;
            valor[4] = 3.50;
            valor[5] = 8.00;

            /*
             * Códigos, produtos e valores ref. aos arrays que
             * foram declarados.
             */

        }
    }
}
