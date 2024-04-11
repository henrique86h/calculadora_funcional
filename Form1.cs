using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_funcional
{
    public partial class MarCalqui : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";
        public MarCalqui()
        {
            InitializeComponent();
        }

        private void labeloperacao_TextChanged(object sender, EventArgs e)
        {

        }
        private void btn3_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "9";
        }

        private void btn0_Click_1(object sender, EventArgs e)
        {
            textBoxResultado.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "2";
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            if (textBoxResultado.Text != "")
            {
                valor1 = decimal.Parse(textBoxResultado.Text, CultureInfo.InvariantCulture);
                textBoxResultado.Text = "";
                operacao = "SOMA";
                labeloperacao.Text = "+";
            }

        }
    }
}
