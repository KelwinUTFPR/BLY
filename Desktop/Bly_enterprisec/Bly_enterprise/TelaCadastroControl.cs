using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bly_enterprise

{

    public partial class TelaCadastroControl : UserControl
    {


        public TelaCadastroControl()
        {
            InitializeComponent();
        }
        public static string usuario, onibus, login, rotas, saldo, consulta;

        private void TelaCadastroControl_Load(object sender, EventArgs e)
        {
        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


                usuario = "1";
               
                this.SendToBack();
        }

   

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (TelaHomeControl.valor == "1")
            {
                label3.Text = "Tela de cadastramento";
                
                
            }
           else if(TelaHomeControl.valor == "2")
            {
                label3.Text = "Tela de alteração";
               
            }
            else if(TelaHomeControl.valor == "3")
            {
                label3.Text = "Tela de exclusão";
                
            }
            else if (TelaHomeControl.valor == "4")
            {
                label3.Text = "Clique no item que deseja consultar";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TelaHomeControl.valor == "1")
            {
                label3.Text = "Tela de test";


            }
            else if (TelaHomeControl.valor == "2")
            {
                label3.Text = "Tela de alteração";

            }
            else if (TelaHomeControl.valor == "3")
            {
                label3.Text = "Tela de exclusão";

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            onibus = "1";
            this.SendToBack();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            rotas = "1";
            this.SendToBack();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            saldo = "1";
            this.SendToBack();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            login = "1";
            this.SendToBack();
        }
    }
}
