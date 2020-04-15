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

namespace ContentFilterApp
{
    /// <summary>
    /// Логика взаимодействия для LocationIP.xaml
    /// </summary>
    public partial class LocationIP : Window
    {
        DataSet ds;
        SqlDataAdapter adp;
        SqlConnection connection = new SqlConnection(@"Data Source=light;Initial Catalog=Sentence;Persist Security Info=True;User ID=sa;Password=GtslapdGkfk1548");
        string cmdsql = "select * from Location";
        public LocationIP()
        {
            InitializeComponent();

            using (connection)
            {
                connection.Open();
                adp = new SqlDataAdapter(cmdsql, connection);
                ds = new DataSet();
                adp.Fill(ds);
                dataGrid_Location.ItemsSource = ds.DefaultViewManager;
            }
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
