﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace While
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = 1;
            while (numero <= 10)
            {
                listBox1.Items.Add(numero);
                numero = numero + 1;

                /*Declaração da variável número do tipo inteiro, a variável foi 
                 * inicializada com o número 1.
                 * "Enquanto" o número for menor ou igual a 10 o listbox será preenchido
                 * expressão = numero+ numero1 é o incremento*/
            }
        }
    }
}
