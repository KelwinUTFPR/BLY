using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using MySql.Data; // Biblioteca da conexão do SQL.
using MySql.Data.MySqlClient; // Biblioteca da conexão do SQL.

namespace catraca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
   
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            MySqlConnection conn = null;
            string strConn = @"Server = localhost; Database=tcc; Uid=root;Pwd=''; Connect Timeout=30;";
            conn = new MySqlConnection(strConn);
            conn.Open();
            string mSQL = "Select Saldo_Passar from saldo ";
            MySqlCommand cmd = new MySqlCommand(mSQL, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Dispose();
            int registro;
            registro = count;
         
            if (registro == 1)
            {
                SerialPort port = new SerialPort("COM5", 9600);
                port.Open();
                port.Write("1");
                port.Close();


                port.Open();
                port.Write("0");
                port.Close();

                MySqlConnection conn1 = null;
                string strConn1 = @"Server = localhost; Database=tcc; Uid=root;Pwd=''; Connect Timeout=30;";
                conn1 = new MySqlConnection(strConn1);
                conn1.Open();
                string mSQL1 =  "Update saldo set Saldo_Passar = 0 WHERE Saldo_Codigo = 1 ";
                MySqlCommand cmd1 = new MySqlCommand(mSQL1, conn1);
                MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
                Int32 count1 = Convert.ToInt32(cmd1.ExecuteScalar());
                cmd1.Dispose();
                int registro1;
                registro1 = count1;
             

              

            }
            else if (registro==0)
            {
                SerialPort port = new SerialPort("COM5", 9600);
                port.Open();
                port.Write("0");
                port.Close();
            }


        }
    }
}
