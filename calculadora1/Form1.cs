using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora1
{
    public partial class frmCalculadora1 : Form
    {
        public frmCalculadora1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "0";
        }

        double primeiroNumero = 0;
        string operador = "";
        bool novoNumero = true;

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            primeiroNumero = double.Parse(txtVisor.Text);

            operador = "/";

            novoNumero = true;

            txtVisor.Text = "";
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            primeiroNumero = double.Parse(txtVisor.Text);

            operador = "x";

            novoNumero = true;

            txtVisor.Text = "";
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            primeiroNumero = double.Parse(txtVisor.Text);

            operador = "-";

            novoNumero = true;

            txtVisor.Text = "";
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            primeiroNumero = double.Parse(txtVisor.Text);

            operador = "+";

            novoNumero = true;

            txtVisor.Text = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            double segundoNumero = double.Parse(txtVisor.Text);
            double resultado = 0;

            switch (operador)
            {
                case "+":
                    resultado = primeiroNumero + segundoNumero;
                    break;
                case "-":
                    resultado = primeiroNumero - segundoNumero;
                    break;
                case "x":
                    resultado = primeiroNumero * segundoNumero;
                    break;
                case "/":
                    resultado = primeiroNumero / segundoNumero;
                    break;
            }

            txtVisor.Text = resultado.ToString();
            novoNumero = true;


        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            txtVisor.Text = "";
            primeiroNumero = 0;
            operador = "";
            novoNumero = true;
        }
    }
}
