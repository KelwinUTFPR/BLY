using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bly_enterprise
{
    public partial class frm_principal : Form
    {
        public frm_principal()
        {
            InitializeComponent();
            SidePanel.Height = btn_Home.Height;
            SidePanel.Top = btn_Home.Top;
            telaCadastroControl1.BringToFront();
            telaHomeControl1.BringToFront();


     

        }
     
        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_Home.Height;
            SidePanel.Top = btn_Home.Top;
          
            telaCadastroControl1.BringToFront();
           
            telaHomeControl1.BringToFront();


        

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_Mapa.Height;
            SidePanel.Top = btn_Mapa.Top;
            
             telaMapaControl1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_Conta.Height;
            SidePanel.Top = btn_Conta.Top;
            telaContaControl1.BringToFront();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Close();
            frm_login Telalogin = new frm_login();
            Telalogin.Show();

          
           
        }

        private void telaHomeControl1_Load(object sender, EventArgs e)
        {

        }

        private void telaCadastroControl1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {


        }

        private void frm_principal_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (TelaCadastroControl.usuario == "1")
            {
                if (TelaHomeControl.valor == "1")
                {
                    telaUsuarioCad1.BringToFront();
                }
               
                else if(TelaHomeControl.valor == "2")
                {
                    telaUsuarioAlter1.BringToFront();
                }
                 else if (TelaHomeControl.valor =="3" )
                {
                  telaUsuarioDel1.BringToFront(); 
                }
                else if (TelaHomeControl.valor == "4")
                {
                    telaConsultaUsuario1.BringToFront();
                }
                TelaCadastroControl.usuario = "0";
               
            }


            else if (TelaCadastroControl.onibus == "1")
            {
                if (TelaHomeControl.valor == "1")
                {
                   telaBusCad1.BringToFront();
                }

                else if (TelaHomeControl.valor == "2")
                {
                    telaBusAlter1.BringToFront();
                }
                else if (TelaHomeControl.valor == "3")
                {
                    telaBusDel1.BringToFront();
                }
                TelaCadastroControl.onibus = "0";

            }

            else if (TelaCadastroControl.rotas == "1")
            {
                if (TelaHomeControl.valor == "1")
                {
                    telaRotCad1.BringToFront();
                }

                else if (TelaHomeControl.valor == "2")
                {
                    telaRotAlter1.BringToFront();
                }
                else if (TelaHomeControl.valor == "3")
                {
                    telaRotDel1.BringToFront();
                }
                else if (TelaHomeControl.valor == "4")
                {
                    telaConsultaRota1.BringToFront();
                }
                TelaCadastroControl.rotas = "0";

            }

            else if (TelaCadastroControl.saldo == "1")
            {
                if (TelaHomeControl.valor == "1")
                {
                    telaSaldoCad1.BringToFront();
                }

                else if (TelaHomeControl.valor == "2")
                {
                    telaSaldoAlter1.BringToFront();
                }
                else if (TelaHomeControl.valor == "3")
                {
                    telaSaldoDel1.BringToFront();
                }
                else if (TelaHomeControl.valor == "4")
                {
                    telaConsultarSaldo1.BringToFront();
                }
                TelaCadastroControl.saldo = "0";

            }

            else if (TelaCadastroControl.login == "1")
            {
                if (TelaHomeControl.valor == "1")
                {
                    telaLoginCad1.BringToFront();
                }

                else if (TelaHomeControl.valor == "2")
                {
                    telaLoginAlter1.BringToFront();
                }
                else if (TelaHomeControl.valor == "3")
                {
                    telaLoginDel1.BringToFront();
                }
                TelaCadastroControl.login = "0";

            }










        }

        private void telaMapaControl1_Load(object sender, EventArgs e)
        {

        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            TelaHomeControl.valor = "4";
            
            SidePanel.Height = btn_Consulta.Height;
            SidePanel.Top = btn_Consulta.Top;
            telaCadastroControl1.BringToFront();
        }
    }
}
