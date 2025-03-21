using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadoradedesconto
{
    public partial class frmCalculadoraDesconto : Form
    {
        public frmCalculadoraDesconto()
        {
            InitializeComponent();
        }


        private void btn1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }



        double primeiroNumero = 0;
        string operador = "";
        bool novoNumero = true;

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            primeiroNumero = double.Parse(txtResultado.Text);

            operador = "*";

            novoNumero = true;

            txtResultado.Text = "";

        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            primeiroNumero = double.Parse(txtResultado.Text);

            operador = "/";

            novoNumero = true;

            txtResultado.Text = "";

        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            primeiroNumero = double.Parse(txtResultado.Text);

            operador = "+";

            novoNumero = true;

            txtResultado.Text = "";

        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            primeiroNumero = double.Parse(txtResultado.Text);

            operador = "-";

            novoNumero = true;

            txtResultado.Text = "";



        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            double segundoNumero = double.Parse(txtResultado.Text);
            double resultado = 0;

            switch (operador)
            {
                case "+":
                    resultado = primeiroNumero + segundoNumero;
                    break;
                case "-":
                    resultado = primeiroNumero - segundoNumero;
                    break;
                case "*":
                    resultado = primeiroNumero * segundoNumero;
                    break;
                case "/":
                    resultado = primeiroNumero / segundoNumero;
                    break;
            }

            txtResultado.Text = resultado.ToString();
            novoNumero = true;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            primeiroNumero = 0;
            operador = "";
            novoNumero = true;
        }
        private void btnPonto_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains(","))
            {
                txtResultado.Text += ",";

            }


        }


    }
}


