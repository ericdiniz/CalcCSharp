using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {

        // variaveis
        decimal valor1 = 0, valor2 = 0;
        String operacao = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            // botao 0
            txtResultado.Text += "0";  
        }

        private void button15_Click(object sender, EventArgs e)
        {
            // botao 1
            txtResultado.Text += "1";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // botao 2 
            txtResultado.Text += "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // botao 3
            txtResultado.Text += "3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // botao 4
            txtResultado.Text += "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // botao 5
            txtResultado.Text += "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // botao 6
            txtResultado.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // botao 7
            txtResultado.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // botao 8
            txtResultado.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // botao 9
            txtResultado.Text += "9";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            // botao .
            txtResultado.Text += ".";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            if(operacao == "SOMA")
            {
                txtResultado.Text = Convert.ToString(valor1 + valor2);
            }
            else if (operacao == "SUB")
            {
                txtResultado.Text = Convert.ToString(valor1 - valor2);
            }
            else if (operacao == "MULT")
            {
                txtResultado.Text = Convert.ToString(valor1 * valor2);
            }
            else
            {
                txtResultado.Text = Convert.ToString(valor1 / valor2);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

                txtResultado.Text = "";
                operacao = "SUB";
                lblOperacao.Text = "-";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

                txtResultado.Text = "";
                operacao = "MULT";
                lblOperacao.Text = "*";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

                txtResultado.Text = "";
                operacao = "DIV";
                lblOperacao.Text = "/";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            lblOperacao.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // o culture info invariant culture faz com que o txt seja convertido corretamente para decimal 
            // fazendo com que o valor1 passe de string (0.25) para decimal (0.25)
            if(txtResultado.Text != "") { 
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

            txtResultado.Text = "";
            operacao = "SOMA";
            lblOperacao.Text = "+";
            }
        }
    }
}
