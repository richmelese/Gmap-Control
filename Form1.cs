using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;
using GMap.NET;
using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GMap.NET.Entity.OpenStreetMapGraphHopperGeocodeEntity;

namespace CheekMap
{
    public partial class Form1 : Form
    {
        private List<PointLatLng> _Points;
        

        // private 

        public Form1()
        {
            List<PointLatLng> Points_route = new List<PointLatLng>();
            _Points = new List<PointLatLng>();
            InitializeComponent();
        }
        GMapOverlay markers = new GMapOverlay("markers");
        List<PointLatLng> Points_route = new List<PointLatLng>();
        List<PointLatLng> points = new List<PointLatLng>();
        List<PointLatLng> addedPoints = new List<PointLatLng>();
        GMapOverlay routes = new GMapOverlay("routes");
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLoadToMap_Click(object sender, EventArgs e)
        {
            var point = new PointLatLng(Convert.ToDouble(textlat.Text), Convert.ToDouble(txtlongt.Text));
            map.MapProvider = GMapProviders.GoogleMap;
            map.Zoom = 10;

            map.MinZoom = 5;
            map.MaxZoom = 100;
            map.Position = point;

            GMapOverlay markers = new GMapOverlay("markers");
            // GMapOverlay route = new GMapOverlay("Route");
            GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.green);
            markers.Markers.Add(marker);
            map.Overlays.Add(markers);

         
            /*
            map.DragButton = MouseButtons.Left;
            map.MapProvider = GMapProviders.GoogleMap;
            double lat = Convert.ToDouble(textlat.Text);
            double lng = Convert.ToDouble(txtlongt.Text);
            map.Position = new PointLatLng(lat, lng);
            map.Zoom = 10;
            map.MinZoom = 5;
            map.MaxZoom = 100;
            PointLatLng Point = new PointLatLng(lat, lng);
            GMapMarker marker = new GMarkerGoogle(Point, GMarkerGoogleType.green);
           
            GMapOverlay markers = new GMapOverlay("markers");
            GMapOverlay route = new GMapOverlay("Route");
   
            markers.Markers.Add(marker);
         
            map.Overlays.Add(markers);
        */

            }

      

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            /*var route = GoogleMapProvider.Instance
                          .GetRoute(_Points[0], _Points[1], false, false, 14);
                       var r = new GMapRoute(route.Points, "my waypoints");
                       {
                            Pen Stroke = new Pen(Color.Blue, 3);
                            // r.Stroke = new System.Drawing.Pen(System.Drawing.Color.Red, 4);
                            //map.Add(r);
                        };
                       var routes = new GMapOverlay("routes");
                       routes.Routes.Add(r);*/

            addedPoints.Add(new PointLatLng(Convert.ToDouble(textlat.Text), Convert.ToDouble(txtlongt.Text)));
        
        var point = new PointLatLng(Convert.ToDouble(textlat.Text), Convert.ToDouble(txtlongt.Text));
                LoadMap(point);
                AddMarker(point);
           // MapDoubleClick.Remove(marker);


            
        }
        //int delay = 0;
        private void map_MouseMove(object sender, MouseEventArgs e)
        {
          /*  try
            {
                delay ++;
                if (delay==10)
                {
                    int X = e.X;
                    int Y = e.Y;
                    double lat = map.FromLocalToLatLng(e.X, e.Y).Lat;
                    double lng = map.FromLocalToLatLng(e.X, e.Y).Lng;
                    lbl_lat.Text = Convert.ToString(lat + 1000);
                    lbl_lng.Text = Convert.ToString(lng);
                    delay = 0;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }


        private void btnAddPolygon_Click(object sender, EventArgs e)
        {
            var polygon = new GMapPolygon(_Points, "my Area") 
            {
                Stroke = new Pen(Color.DarkGreen, 2),
                Fill = new SolidBrush(Color.BurlyWood)

            };
            var polygons = new GMapOverlay("polygons");
            polygons.Polygons.Add(polygon);
            map.Overlays.Add(polygons);
        }

        private void map_Load(object sender, EventArgs e)
        {

        }
        /*private RemoveMarker(GMapMarker)
        {
            MapDoubleClick.Remove
        }*/
          
               

        private void map_MouseDoubleClick(object sender, MouseEventArgs e)
        {
          /* addPoints.Add(new PointLatLng(Convert.ToDouble(textlat.Text), Convert.ToDouble(txtlongt.Text)));
            AddMarker(PointLatLng pointToAdd, GMarkerGoogleType markerType = GMarkerGoogleType.red);
            AddPoints.Clear();*/

        }

        private void map_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                /// MessageBox.Show(e.X + " " + e.Y);
                var point = map.FromLocalToLatLng(e.X, e.Y);
                double lat = point.Lat;
                double lng = point.Lng;

                textlat.Text = lat+"";
                txtlongt.Text = lng + "";




            }
        }
        private void LoadMap(PointLatLng point)
        {
           // map.DragButton = MouseButtons.Left;
            map.MapProvider = GMapProviders.GoogleMap;
             map.Zoom = 10;
          
            map.MinZoom = 5;
            map.MaxZoom = 100;
            map.Position = point;

        }
        private void AddMarker(PointLatLng pointToAdd, GMarkerGoogleType markerType= GMarkerGoogleType.red)
        {
      
            //GMapOverlay markers = new GMapOverlay("markers");
           // GMapOverlay route = new GMapOverlay("Route");
            GMapMarker marker = new GMarkerGoogle(pointToAdd, markerType);
            markers.Markers.Add(marker);
            map.Overlays.Add(markers);
           // MapDoubleClick.Remove(marker,m);

        }

        private void btnAddPoint_Click(object sender, EventArgs e)
        {
            //var point = new PointLatLng(Convert.ToDouble(textlat.Text), Convert.ToDouble(txtlongt.Text));
//LoadMap(point);
           // AddMarker(point);
        }

        private void DrowRoute_Click(object sender, EventArgs e)
        {
            //GMapOverlay routes = new GMapOverlay("routes");
            if (addedPoints.Count > 1)
            {
                GMapRoute route = new GMapRoute(addedPoints, "A walk in the park");
                route.Stroke = new Pen(Color.Red, 3);
                routes.Routes.Add(route);
                map.Overlays.Add(routes);
               // map.Zoom--;
               // map.Zoom++;
            }
        }
       
        private void RemoveMarker_Click(object sender, EventArgs e)
        {
           
            try
            {
               map.Overlays.Remove(markers);
              //map.Overlays.Remove(routes);
                map.Refresh();
            }catch(Exception ex)
            {
                MessageBox.Show("no more marker");
            } 
            
        }

        private void RemoveRoute_Click(object sender, EventArgs e)
        {
            try { 
            map.Overlays.Remove(routes);
                map.Refresh();
        }catch(Exception ex)
            {
                MessageBox.Show("no more route");
            }

}
    }
       
    }

