using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsPresentation;
using GMap.NET.Internals;

namespace ContentFilterApp
{
    /// <summary>
    /// Логика взаимодействия для LocationIP.xaml
    /// </summary>
    public partial class LocationIP : Window
    {
        //GMapMarker marker;
        double LatIn = 40.62;
        double LngIn = 20.12;
        GMapMarker marker;

        SqlConnection connection = new SqlConnection(@"Data Source=light;Initial Catalog=Sentence;Persist Security Info=True;User ID=sa;Password=GtslapdGkfk1548");
        string cmdsql = "select Time, Latitude, Longitude from Location";
        public LocationIP()
        {
            InitializeComponent();

            //Добавление маркера в виде фиолетового кружка
            marker = new GMapMarker(new PointLatLng(LatIn, LngIn));
            GMap_1.Markers.Add(marker);
            marker.Shape = new Ellipse
            {
                Width = 10,
                Height = 10,
                Stroke = Brushes.BlueViolet,
                StrokeThickness = 1.5
            };

            GMap_1.DragButton = MouseButton.Left;
            GMap_1.CanDragMap = true;
            GMap_1.MapProvider = GMapProviders.GoogleMap;
            GMap_1.Position = new PointLatLng(LatIn, LngIn);
            GMap_1.MinZoom = 0;
            GMap_1.MaxZoom = 24;
            GMap_1.Zoom = 9;


            using (connection)
            {
                connection.Open();
                SqlDataAdapter adp = new SqlDataAdapter(cmdsql, connection);
                SqlCommandBuilder cmdb = new SqlCommandBuilder(adp);
                DataSet ds = new DataSet();
                adp.Fill(ds, "Location");
                dataGrid_Location.ItemsSource = ds.Tables["Location"].DefaultView;
                connection.Close();
            }
        }
    }
}
