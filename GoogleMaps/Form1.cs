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
            dt = new DataTable();
            dt.Columns.Add(new DataColumn("Decripción", typeof(string)));
            dt.Columns.Add(new DataColumn("Latitud", typeof(double)));
            dt.Columns.Add(new DataColumn("Longitud", typeof(double)));

            //Insertando datos al dt
            dt.Rows.Add("Ubicación 1", LaInicial, LongitudInicial);
            dgvLocalizacion.DataSource = dt;

            //Desactivar las columnas de latitud y longitud

            dgvLocalizacion.Columns[1].Visible = false;
            dgvLocalizacion.Columns[2].Visible = false;

            gmcMapa.DragButton = MouseButtons.Left;
            gmcMapa.CanDragMap = true;
            gmcMapa.MapProvider = GMapProviders.GoogleMap;
            gmcMapa.Position = new PointLatLng(LaInicial, LongitudInicial);
            gmcMapa.MinZoom = 0;
            gmcMapa.MaxZoom = 24;
            gmcMapa.Zoom = 9;
            gmcMapa.AutoScroll = true;

            //Marcador 
            markerOverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new PointLatLng(LaInicial,LongitudInicial),GMarkerGoogleType.green);
            markerOverlay.Markers.Add(marker); //Agregamos al mapa
            //agregando tooltip de texto marcadores
            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = string.Format("Ubicación : \n Latitud: {0} \n Longitud: {1} ", LaInicial, LongitudInicial);


            //Agregando el mapa y el marcador al map Control

            gmcMapa.Overlays.Add(markerOverlay);

        }

        private void SeleccionarRegistro(object sender, DataGridViewCellMouseEventArgs e)
        {
            filaSeleccionada = e.RowIndex;
            txtbDescripcion.Text = dgvLocalizacion.Rows[filaSeleccionada].Cells[0].Value.ToString();
            txtbLatitud.Text = dgvLocalizacion.Rows[filaSeleccionada].Cells[1].Value.ToString();
            txtbLongitud.Text = dgvLocalizacion.Rows[filaSeleccionada].Cells[2].Value.ToString();

            //Asignando valores del grid al marcador
            marker.Position = new PointLatLng(double.Parse(txtbLatitud.Text), double.Parse(txtbLongitud.Text));
            gmcMapa.Position = marker.Position;


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dt.Rows.Add(txtbDescripcion.Text, double.Parse(txtbLatitud.Text), double.Parse(txtbLongitud.Text));
        }
    }
}
