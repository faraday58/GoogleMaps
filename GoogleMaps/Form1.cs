using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace GoogleMaps
{
    public partial class Form1 : Form
    {

        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        DataTable dt;
        int filaSeleccionada = 0;
        double LaInicial = 19.3188;
        double LongitudInicial= -99.1843;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gmcMapa.DragButton = MouseButtons.Left;
            gmcMapa.CanDragMap = true;
            gmcMapa.MapProvider = GMapProviders.GoogleMap;
            gmcMapa.Position = new PointLatLng(LaInicial, LongitudInicial);
            gmcMapa.MinZoom = 0;
            gmcMapa.MaxZoom = 24;
            gmcMapa.Zoom = 9;
            gmcMapa.AutoScroll = true;
        }
    }
}
