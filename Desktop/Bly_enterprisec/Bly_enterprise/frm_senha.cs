using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data; // Biblioteca da conexão do SQL.
using MySql.Data.MySqlClient; // Biblioteca da conexão do SQL.

namespace Bly_enterprise
{
    public partial class frm_senha : Form
    {
        public frm_senha()
        {
            InitializeComponent();


        }

        private void btn_acessar_Click(object sender, EventArgs e)
        {






            MySqlConnection conn = null;
            string strConn = @"Server=localhost;Database=tcc;Uid=root;Pwd='';Connect Timeout=30;";
            conn = new MySqlConnection(strConn);
            conn.Open();
            string mSQL = "Select * from login where Login_Email ='" + TelaContaControl.email + "'"; 
            MySqlCommand cmd = new MySqlCommand(mSQL, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            string BancoSenha = dt.Rows[0]["Login_Senha"].ToString();
            string SenhaAtual = txt_SenhaAntiga.Text;
          
            if (BancoSenha == SenhaAtual)
            {
                if (txt_NewSenha.Text == txt_ConfirmSenha.Text)
                {
                    Orientacao senha = new Orientacao();
                    senha._senha = txt_ConfirmSenha.Text;
                    senha._senha = txt_ConfirmSenha.Text;
                    senha._email = TelaContaControl.email;
                    senha.atualizar();
                }
                else
                {
                    MessageBox.Show("Digite senhas iguais", "Acesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            else
            {
                MessageBox.Show("Usuario ou Senha invalidos", "Acesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            frm_MenOk ok = new frm_MenOk();
            ok.Show();
            Close();


        }
        private void frm_senha_Load(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            float Espessura = 2.0f;
            Color COR = Color.DeepSkyBlue;

            txt_NewSenha.BorderStyle = BorderStyle.None;
            txt_SenhaAntiga.BorderStyle = BorderStyle.None;
            txt_ConfirmSenha.BorderStyle = BorderStyle.None;

            Graphics g = this.CreateGraphics();
            g.DrawRectangle(new Pen(COR, Espessura), txt_NewSenha.Location.X, txt_NewSenha.Location.Y, txt_NewSenha.Width, txt_NewSenha.Height);
            g.DrawRectangle(new Pen(COR, Espessura), txt_SenhaAntiga.Location.X, txt_SenhaAntiga.Location.Y, txt_SenhaAntiga.Width, txt_SenhaAntiga.Height);
            g.DrawRectangle(new Pen(COR, Espessura), txt_ConfirmSenha.Location.X, txt_ConfirmSenha.Location.Y, txt_ConfirmSenha.Width, txt_ConfirmSenha.Height);
        }


        private void txt_SenhaAntiga_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txt_NewSenha_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_ConfirmSenha_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void txt_SenhaAntiga_MouseClick(object sender, MouseEventArgs e)
        {
       
 
        }

        private void txt_NewSenha_MouseClick(object sender, MouseEventArgs e)
        {
            txt_NewSenha.Clear();
            txt_NewSenha.Multiline = true;
            txt_NewSenha.MinimumSize = new Size(220, 30);
            txt_NewSenha.Size = new Size(220, 30);
            txt_NewSenha.Multiline = false;

        }

        private void txt_ConfirmSenha_MouseClick(object sender, MouseEventArgs e)
        {
            txt_ConfirmSenha.Clear();
            txt_ConfirmSenha.Multiline = true;
            txt_ConfirmSenha.MinimumSize = new Size(220, 30);
            txt_ConfirmSenha.Size = new Size(220, 30);
            txt_ConfirmSenha.Multiline = false;
        }

        private void txt_SenhaAntiga_MouseClick_1(object sender, MouseEventArgs e)
        {
            txt_SenhaAntiga.Clear();
            txt_SenhaAntiga.Multiline = true;
            txt_SenhaAntiga.MinimumSize = new Size(220, 30);
            txt_SenhaAntiga.Size = new Size(220, 30);
            txt_SenhaAntiga.Multiline = false;
        }
    }
}
