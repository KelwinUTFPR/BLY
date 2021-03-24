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
    public partial class TelaHomeControl : UserControl 
    {
        public TelaHomeControl()
        {
            InitializeComponent();
        }
        public static string valor;
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
      
        private void button2_Click(object sender, EventArgs e)
        {
            valor = "1";
            this.SendToBack();
            
        }

        private void TelaHomeControl_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            valor = "2";
            this.SendToBack();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            valor = "3";
            this.SendToBack();
        }
    }
}
