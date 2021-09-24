using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        decimal valor1 = 0;
        decimal valor2 = 0;
        String operacao = "";

        public Calculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button0_Click(object sender, EventArgs e)
        {
            testResultado.Text += "0";
        }

        private void buttonPonto_Click(object sender, EventArgs e)
        {
            if (testResultado.Text != "")
            {
                testResultado.Text += ".";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            testResultado.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            testResultado.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            testResultado.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            testResultado.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            testResultado.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            testResultado.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            testResultado.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            testResultado.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            testResultado.Text += "9";
        }

        private void buttonMais_Click(object sender, EventArgs e)
        {
            if (testResultado.Text != "")
            {
                valor1 = decimal.Parse(testResultado.Text, System.Globalization.CultureInfo.InvariantCulture);
                testResultado.Text = "";
                operacao = "SOMA";
                lblOperacao.Text = "+";
            }
        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            if (testResultado.Text != "")
            {
                valor2 = decimal.Parse(testResultado.Text, System.Globalization.CultureInfo.InvariantCulture);

                if (operacao == "SOMA")
                {
                    testResultado.Text = Convert.ToString(valor1 + valor2);
                }
                if (operacao == "SUBTRAIR")
                {
                    testResultado.Text = Convert.ToString(valor1 - valor2);
                }
                if (operacao == "DIVIDIR")
                {
                    testResultado.Text = Convert.ToString(valor1 / valor2);
                }
                if (operacao == "VEZES")
                {
                    testResultado.Text = Convert.ToString(valor1 * valor2);
                }
            }
        }

        private void buttonMenos_Click(object sender, EventArgs e)
        {
            if (testResultado.Text != "")
            {
                valor1 = decimal.Parse(testResultado.Text, System.Globalization.CultureInfo.InvariantCulture);

                testResultado.Text = "";
                operacao = "SUBTRAIR";
                lblOperacao.Text = "-";
            }
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            if (testResultado.Text != "")
            {
                valor1 = decimal.Parse(testResultado.Text, System.Globalization.CultureInfo.InvariantCulture);

                testResultado.Text = "";
                operacao = "DIVIDIR";
                lblOperacao.Text = "/";
            }
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            if (testResultado.Text != "")
            {
                valor1 = decimal.Parse(testResultado.Text, System.Globalization.CultureInfo.InvariantCulture);

                testResultado.Text = "";
                operacao = "VEZES";
                lblOperacao.Text = "x";
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            testResultado.Text = "";
            lblOperacao.Text = "";
            valor1 = 0;
            valor2 = 0;
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            testResultado.Text = "";
        }

        private void testResultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
