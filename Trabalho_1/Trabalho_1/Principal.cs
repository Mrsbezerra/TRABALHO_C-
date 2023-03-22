using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_1
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void lbl_Total_Click(object sender, EventArgs e)
        {

        }

        private void btn_Somar_Click(object sender, EventArgs e)
        {
            int valor1, valor2, resultado;

            valor1 = Convert.ToInt32(txb_Valor1.Text);
            valor2 = Convert.ToInt32(txb_Valor2.Text);

            resultado = valor1 + valor2;

            lbl_Total.Text = resultado.ToString();
        }

        private void btn_Subtrair_Click(object sender, EventArgs e)
        {
            int valor1, valor2, resultado;

            valor1 = Convert.ToInt32(txb_Valor1.Text);
            valor2 = Convert.ToInt32(txb_Valor2.Text);

            resultado = valor1 - valor2;

            lbl_Total.Text = resultado.ToString();
        }

        private void btn_Multiplicar_Click(object sender, EventArgs e)
        {
            int valor1, valor2, resultado;

            valor1 = Convert.ToInt32(txb_Valor1.Text);
            valor2 = Convert.ToInt32(txb_Valor2.Text);

            resultado = valor1 * valor2;

            lbl_Total.Text = resultado.ToString();
        }

        private void btn_Dividir_Click(object sender, EventArgs e)
        {
            int valor1, valor2, resultado;

            valor1 = Convert.ToInt32(txb_Valor1.Text);
            valor2 = Convert.ToInt32(txb_Valor2.Text);

            resultado = valor1 / valor2;

            lbl_Total.Text = resultado.ToString();
        }
    }
}
