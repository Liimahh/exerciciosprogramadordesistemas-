using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculodedesconto
{
    public partial class frmCalculodeDesconto : Form
    {
        public frmCalculodeDesconto()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double valorCompra = double.Parse(txtValorCompra.Text);
            double desconto = double.Parse(txtDesconto.Text);

            double valorDesconto = valorCompra * (desconto / 100);
            double valorFinal = valorCompra - valorDesconto;

            lblResultado.Text = "Resultado da compra com desconto R$" + valorFinal.ToString("0.00");

        }
    }
}
