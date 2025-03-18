using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maioroumenorquedez
{
    public partial class FrmMaiorMenor : Form
    {
        public FrmMaiorMenor()
        {
            InitializeComponent();
        }

        private void lblMaiorMenor_Click(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            {

                if (int.TryParse(txtMaiorMenor.Text, out int numero))

                {

                    if (numero >= 10)

                    {

                        MessageBox.Show("O número é maior/igual a 10.");

                    }

                    else if (numero < 10)

                    {

                        MessageBox.Show("O número é menor que 10.");

                    }

                }

                else

                {

                    MessageBox.Show("Insira um número válido.");

                }

            }

        }

        private void txt_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
    

