using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            
            if (txtNome.Text == "" || txtDataNascimento.Text == "" || txtEndereco.Text == "" || txtTelefone.Text == "" || txtEscola.Text == "" || txtSerie.Text == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos!");
                return;
            }

            
            DateTime dataNascimento;
            if (DateTime.TryParse(txtDataNascimento.Text, out dataNascimento))
            {
                MessageBox.Show("Por favor, insira uma data de nascimento válida!");
                return;
            }

            
            long telefone;
            if (!long.TryParse(txtTelefone.Text, out telefone))
            {
                MessageBox.Show("Por favor, insira um número de telefone válido!");
                return;
            }

            
            string mensagem = "Nome: " + txtNome.Text + "\nData de nascimento: " + dataNascimento.ToShortDateString() + "\nEndereço: " + txtEndereco.Text + "\nTelefone: " + telefone + "\nEscola: " + txtEscola.Text + "\nSérie: " + txtSerie.Text;
            MessageBox.Show(mensagem);

            
            txtNome.Text = "";
            txtDataNascimento.Text = "";
            txtEndereco.Text = "";
            txtTelefone.Text = "";
            txtEscola.Text = "";
            txtSerie.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
            txtNome.Text = "";
            txtDataNascimento.Text = "";
            txtEndereco.Text = "";
            txtTelefone.Text = "";
            txtEscola.Text = "";
            txtSerie.Text = "";
        }
    }
    
}
