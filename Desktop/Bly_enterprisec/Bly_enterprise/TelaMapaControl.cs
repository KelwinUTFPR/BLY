using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace Bly_enterprise
{
    public partial class TelaMapaControl : UserControl
    {
        public TelaMapaControl()
        {
            InitializeComponent();
        }

        private void TelaMapaControl_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Nome";

            GMarkerGoogle marcador;
            GMapOverlay marcadorsobreposicao;
            DataTable dt;
            int filaSeleccionada = 0;
            double LatInicial = -24.49898;
            double LngInicial = -47.84793;



            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(LatInicial, LngInicial);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 100;
            gMapControl1.Zoom = 18;
            gMapControl1.AutoScroll = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
    
      
        }

        private void button2_Click(object sender, EventArgs e)

        {
           
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = (" ");
        }
    }
}
