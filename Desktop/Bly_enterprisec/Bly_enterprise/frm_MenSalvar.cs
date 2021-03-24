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
    public partial class frm_MenSalvar : Form
    {
        public frm_MenSalvar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public static string salvar, cancelar; 

        private void button2_Click(object sender, EventArgs e)
        {
            salvar = "1";
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            cancelar = "1";
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cancelar = "1";
            Close();
        }

    }
}
