using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data; // Biblioteca da conexão do SQL.
using MySql.Data.MySqlClient; // Biblioteca da conexão do SQL.

namespace Bly_enterprise
{
    public partial class TelaConsultaUsuario : UserControl
    {
        public TelaConsultaUsuario()
        {
            InitializeComponent();

        }
        

        private void TelaConsultaUsuario_Load(object sender, EventArgs e)
        {

            MySqlConnection conn = null;
            string strConn = @"Server=localhost;Database=tcc;Uid=root;Pwd='';Connect Timeout=30;";
            conn = new MySqlConnection(strConn);
            conn.Open();
            string mSQL = "Select * from usuario ";
        

            MySqlCommand cmd = new MySqlCommand(mSQL, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            MySqlConnection conn1 = null;
            string strConn1 = @"Server = localhost; Database=tcc; Uid=root;Pwd=''; Connect Timeout=30;";
            conn1 = new MySqlConnection(strConn1);
            conn1.Open();
            string mSQL1 = "Select count(*) from usuario ";
            MySqlCommand cmd1 = new MySqlCommand(mSQL1, conn1);
            MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
            Int32 count = Convert.ToInt32(cmd1.ExecuteScalar());
            cmd1.Dispose();
            int registro;
            registro = count;




            
            string Cod, Nome, Tipo, Nas, Cpf;
            int R = 0;
            int n = 0;
            for (int i = 0; i < registro; i++)
            {
              
                Cod = dt.Rows[R]["Usuario_Codigo"].ToString();
                Nome = dt.Rows[R]["Usuario_Nome"].ToString();
                Tipo = dt.Rows[R]["Usuario_Tipo"].ToString();
                Nas = dt.Rows[R]["Usuario_Nascimento"].ToString();
                Cpf = dt.Rows[R]["Usuario_CPF"].ToString();


                
                n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = Cod;
                dataGridView1.Rows[n].Cells[1].Value = Nome;
                dataGridView1.Rows[n].Cells[2].Value = Cpf;
                dataGridView1.Rows[n].Cells[3].Value = Tipo;
                dataGridView1.Rows[n].Cells[4].Value = Nas;

                R = R + 1;
            }
       





            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;






        }

        public void consultaData()
        {
            /*  MySqlConnection conn = null;
  string strConn = @"Server = localhost; Database=tcc; Uid=root;Pwd=''; Connect Timeout=30;";
  conn = new MySqlConnection(strConn);
  conn.Open();
  string mSQL = "Select * from usuario";
  MySqlCommand cmd = new MySqlCommand(mSQL, conn);
  MySqlDataAdapter da = new MySqlDataAdapter(cmd);
  DataTable dt = new DataTable();
  da.Fill(dt);
  this.dvg_consulta.DataSource = dt;*/

         }

        private void dvg_consulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
