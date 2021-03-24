using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Bly_enterprise
{
    public partial class TelaContaControl : UserControl
    {
        public TelaContaControl()
        {
            InitializeComponent();

            

        }
        public static string email;
        string arquivo;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            String imageLocation = "";
            try
            {

                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    foto.ImageLocation = imageLocation;
                    string nomeArquivo = Path.GetFileNameWithoutExtension(dialog.FileName);
                    arquivo = nomeArquivo;
                    frm_MenSalvar M = new frm_MenSalvar();
                    M.Show();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro inesperado ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath forma = new GraphicsPath();
            forma.AddEllipse(0, 0, foto.Width, foto.Height);
            foto.Region = new Region(forma);

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_senha fsenha = new frm_senha();
            fsenha.Show();
            email = lblLogin.Text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblLogin.Text = frm_login.email;

            if (frm_login.cod == "1")
            {
                MySqlConnection conn = null;
                string strConn = @"Server=localhost;Database=tcc;Uid=root;Pwd='';Connect Timeout=30;";
                conn = new MySqlConnection(strConn);
                conn.Open();
                string mSQL = "Select * from usuario where Usuario_CodLogin ='" + lblLogin.Text + "'";
                MySqlCommand cmd = new MySqlCommand(mSQL, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                string BancoFoto = dt.Rows[0]["Usuario_Foto"].ToString();
                foto.Image = Image.FromFile("C:\\foto\\" + BancoFoto + ".png ");


                frm_login.cod = "0";
            }

 
            if (frm_MenSalvar.salvar == "1")
            {
                OpenFileDialog dialog = new OpenFileDialog();
                foto.Image.Save("C:\\foto\\" + arquivo + ".png", System.Drawing.Imaging.ImageFormat.Png);
                string dbfile = dialog.FileName;


                Orientacao i = new Orientacao();
                i._UserFoto = arquivo;
                i._email = lblLogin.Text;
                i.atualizarFoto();
                frm_MenSalvar.salvar = "0";

            }
            else if (frm_MenSalvar.cancelar == "1")
            {
                MySqlConnection conn1 = null;
                string strConn1 = @"Server=localhost;Database=tcc;Uid=root;Pwd='';Connect Timeout=30;";
                conn1 = new MySqlConnection(strConn1);
                conn1.Open();
                string mSQL1 = "Select * from usuario where Usuario_CodLogin ='" + lblLogin.Text + "'";
                MySqlCommand cmd1 = new MySqlCommand(mSQL1, conn1);
                MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                string BancoFoto1 = dt1.Rows[0]["Usuario_Foto"].ToString();
                foto.Image = Image.FromFile("C:\\foto\\" + BancoFoto1 + ".png ");
                frm_MenSalvar.cancelar = "0";
            }
 
        }

        private void TelaContaControl_Load(object sender, EventArgs e)
        {
            
        }
    }
}
