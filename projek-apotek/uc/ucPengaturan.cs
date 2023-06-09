﻿using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projek_apotek.uc
{
    public partial class ucPengaturan : UserControl
    {   
        GMapControl mapControl = new GMapControl();
        public ucPengaturan()
        {
            InitializeComponent();
        }

        private void ucPengaturan_Load(object sender, EventArgs e)
        {
            //setup map
            mapControl.MapProvider = GMapProviders.OpenStreetMap;
            mapControl.MaxZoom = 25;
            mapControl.MinZoom = 3;
            mapControl.Zoom = 16;
            mapControl.Position = new PointLatLng(Properties.Settings.Default.lat, Properties.Settings.Default.lng);
            mapControl.Dock = DockStyle.Fill;
            //add marker
            GMapOverlay overlay = new GMapOverlay();
            mapControl.Overlays.Add(overlay);
            GMapMarker marker = new GMarkerGoogle(new PointLatLng(Properties.Settings.Default.lat, Properties.Settings.Default.lng), GMarkerGoogleType.red);
            mapControl.Overlays[0].Markers.Add(marker);

            //add to panel
            panelMap.Controls.Clear();
            panelMap.Controls.Add(mapControl);

            //add mouse click
            mapControl.MouseClick += map_MouseClick;

            //set TextBox
            txtNamaAplikasi.Text =  Properties.Settings.Default.namaAplikasi;
            txtLat.Text = Properties.Settings.Default.lat.ToString();
            txtLng.Text = Properties.Settings.Default.lng.ToString();

        }

        private void map_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var point = mapControl.FromLocalToLatLng(e.X, e.Y);
                txtLat.Text = point.Lat.ToString();
                txtLng.Text = point.Lng.ToString();

                GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red);
                mapControl.Overlays[0].Markers.Clear();
                mapControl.Overlays[0].Markers.Add(marker);
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            double lat = 0;
            double lng = 0;
            if (String.IsNullOrEmpty(txtNamaAplikasi.Text) || String.IsNullOrEmpty(txtLng.Text) || String.IsNullOrEmpty(txtLat.Text))
            {
                MessageBox.Show("Lengkapi seluruh field!", "Field empty!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if(double.TryParse(txtLat.Text, out lat) && double.TryParse(txtLng.Text, out lng))
            {
                Properties.Settings.Default.lat = lat;
                Properties.Settings.Default.lng = lng;
                Properties.Settings.Default.Save();
                MessageBox.Show("Berhasil disimpan!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data lat atau lng anda tidak valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            double lat = 0;
            double lng = 0;
            if (String.IsNullOrEmpty(txtNamaAplikasi.Text) || String.IsNullOrEmpty(txtLng.Text) || String.IsNullOrEmpty(txtLat.Text))
            {
                MessageBox.Show("Lengkapi seluruh field!", "Field empty!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (double.TryParse(txtLat.Text, out lat) && double.TryParse(txtLng.Text, out lng))
            {
                GMapMarker marker = new GMarkerGoogle(new PointLatLng(Properties.Settings.Default.lat, Properties.Settings.Default.lng), GMarkerGoogleType.red);
                mapControl.Overlays[0].Markers.Clear();
                mapControl.Overlays[0].Markers.Add(marker);
                mapControl.Position = new PointLatLng(lat, lng);
            }
            else
            {
                MessageBox.Show("Data lat atau lng anda tidak valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
