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
    public partial class frm_table : Form
    {
        public frm_table()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_principal principal = new frm_principal();
            principal.Hide();
           
            Close();

            frm_login Telalogin = new frm_login();
            Telalogin.Show();


           






        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void telaCadastroControl1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
