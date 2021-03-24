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
using System.Drawing.Drawing2D; 

namespace Bly_enterprise
{
    public partial class frm_login : Form
    {
        public frm_login()
        {

            InitializeComponent();

            txt_senha.Multiline = true;
            txt_senha.MinimumSize = new Size(220, 30);
            txt_senha.Size = new Size(220, 30);
            txt_senha.Multiline = false;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            float Espessura = 2.0f;
            Color COR = Color.DeepSkyBlue;

            txt_usuario.BorderStyle = BorderStyle.None;
            txt_senha.BorderStyle = BorderStyle.None;
         
            Graphics g = this.CreateGraphics();
            g.DrawRectangle(new Pen(COR, Espessura), txt_usuario.Location.X, txt_usuario.Location.Y, txt_usuario.Width, txt_usuario.Height);
            g.DrawRectangle(new Pen(COR, Espessura), txt_senha.Location.X, txt_senha.Location.Y, txt_senha.Width, txt_senha.Height);

 
        }

        public static string email, cod;
        private void btn_acessar_Click(object sender, EventArgs e)
        {
            string usuario = txt_usuario.Text;
            string senha = txt_senha.Text;

            MySqlConnection conn = null;
            string strConn = @"Server = localhost; Database=tcc; Uid=root;Pwd=''; Connect Timeout=30;";
            conn = new MySqlConnection(strConn);
            conn.Open();
            string mSQL = "Select count(Login_Email) from login where Login_Email='" + usuario + "' and Login_Senha='" + senha + "'";
            MySqlCommand cmd = new MySqlCommand(mSQL, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Dispose();
            int registro;
            registro = count;

            if (registro == 1)
            {
                frm_principal formulario = new frm_principal();
                formulario.Show();
                this.Hide();
                email = txt_usuario.Text;
                cod = "1";

            }
            else if (usuario == "Admin" && senha == "Admin")
            {
                frm_principal formulario = new frm_principal();
                formulario.Show();
                this.Hide();
                email = "Admin";
            }
            else
            {
                MessageBox.Show("Usuario ou Senha invalidos", "Acesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }
    }
}
