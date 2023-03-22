using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            Form2 form2 = new Form2();
            form2.Close();
        }

        private void btn_Num1_Click(object sender, EventArgs e)
        {
            lbl_Voto.Text = lbl_Voto.Text + "1";
        }

        private void lbl_Voto_TextChanged(object sender, EventArgs e)
        {
            if(lbl_Voto.Text == "51")
            {
                System.Drawing.Image image1 = System.Drawing.Image.FromFile("C:\\Visual_Studio_22\\Trabalho_3\\imagens\\Estremote_Touro2.png");
                ptb_Foto.Image = image1;
            }
            if (lbl_Voto.Text == "24")
            {
                System.Drawing.Image image1 = System.Drawing.Image.FromFile("C:\\Visual_Studio_22\\Trabalho_3\\imagens\\Codinhoto_3.png");
                ptb_Foto.Image = image1;
            }
            if (lbl_Voto.Text == "69")
            {
                System.Drawing.Image image1 = System.Drawing.Image.FromFile("C:\\Visual_Studio_22\\Trabalho_3\\imagens\\Enio_3.png");
                ptb_Foto.Image = image1;
            }

        }

        private void btn_Num5_Click(object sender, EventArgs e)
        {
            lbl_Voto.Text = lbl_Voto.Text + "5";
        }

        private void btn_Num2_Click(object sender, EventArgs e)
        {
            lbl_Voto.Text = lbl_Voto.Text + "2";
        }

        private void btn_Num4_Click(object sender, EventArgs e)
        {
            lbl_Voto.Text = lbl_Voto.Text + "4";
        }

        private void btn_Num6_Click(object sender, EventArgs e)
        {
            lbl_Voto.Text = lbl_Voto.Text + "6";
        }

        private void btn_Num9_Click(object sender, EventArgs e)
        {
            lbl_Voto.Text = lbl_Voto.Text + "9";
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            lbl_Voto.Text = null;
            ptb_Foto.Image = null;
        }

        private void btn_Confirme_Click(object sender, EventArgs e)
        {
           
            
            if (lbl_Voto.Text == "51")
            {
                int valor = Convert.ToInt32(lbl_Testremote.Text);
                valor++;
                lbl_Testremote.Text = valor.ToString();

                Resultados.v_estremote = valor;
               
            }
           
            if (lbl_Voto.Text == "24")
            {
                int valor = Convert.ToInt32(lbl_Tcodinhoto.Text);
                valor++;
                lbl_Tcodinhoto.Text = valor.ToString();

                Resultados.v_codinhoto = valor;

            }

            if (lbl_Voto.Text == "69")
            {
                int valor = Convert.ToInt32(lbl_Tenio.Text) ;
                valor++;
                lbl_Tenio.Text = valor.ToString();

                Resultados.v_enio = valor;


            }


            if (lbl_Voto.Text != "69")
                {

                    if (lbl_Voto.Text != "24")
                    {
                        if (lbl_Voto.Text != "51")
                        {
                            int valor = Convert.ToInt32(lbl_Tnulo.Text);
                            valor++;
                            lbl_Tnulo.Text = valor.ToString();
                        }
                    }

                }

            lbl_Voto.Text = null;
            ptb_Foto.Image = null;
            Form2 form2 = new Form2();
            form2.ShowDialog();
           

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Codinhoto_Click(object sender, EventArgs e)
        {

        }

        private void btn_Corrigir_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            lbl_Voto.Text = null;
            ptb_Foto.Image = null;
        }

        private void btn_Branco_Click(object sender, EventArgs e)
        {
            int valor = Convert.ToInt32(lbl_Tbranco.Text);
            valor++;
            lbl_Tbranco.Text = valor.ToString();
            lbl_Voto.Text = null;
            ptb_Foto.Image = null;
            //Form2 form2 = new Form2();
            //form2.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Voto_Click(object sender, EventArgs e)
        {
        }

        private void btn_Num3_Click(object sender, EventArgs e)
        {

            lbl_Voto.Text = lbl_Voto.Text + "3";
        }

        private void btn_Num7_Click(object sender, EventArgs e)
        {

            lbl_Voto.Text = lbl_Voto.Text + "7";
        }

        private void btn_Num8_Click(object sender, EventArgs e)
        {

            lbl_Voto.Text = lbl_Voto.Text + "8";
        }

        private void btn_Num0_Click(object sender, EventArgs e)
        {

            lbl_Voto.Text = lbl_Voto.Text + "0";
        }
    }
}
