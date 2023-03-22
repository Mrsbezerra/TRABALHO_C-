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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            Resultados.v_enio = 0;
            Resultados.v_estremote = 0;
            Resultados.v_codinhoto = 0;

           
        }

        private void lbl_Estremote_Click(object sender, EventArgs e)
        {

        }

        private void btn_Votar_Click(object sender, EventArgs e)
        {
            
            Form1 form1 = new Form1();
            form1.Show();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            

        }

        private void Form2_Enter(object sender, EventArgs e)
        {
        }

        private void Form2_Activated(object sender, EventArgs e)
        {
            lbl_Tcodinhoto2.Text = Resultados.v_codinhoto.ToString();
            lbl_Tenio2.Text = Resultados.v_enio.ToString();
            lbl_Testremote2.Text = Resultados.v_estremote.ToString();
        }
    }
}
