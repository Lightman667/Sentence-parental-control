using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ContentFilterApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

         GeoCoordinateWatcher Watcher = null;
         private void Watcher_StatusChanged(object sender, GeoPositionStatusChangedEventArgs e)
         {
             GeoCoordinateWatcher watcher = new GeoCoordinateWatcher(GeoPositionAccuracy.High);
                watcher.MovementThreshold = 1.0;
                watcher.TryStart(false, TimeSpan.FromMinutes(1.0));
                Thread.Sleep(100);

                if (watcher.Position.Location.IsUnknown == false)
                {
                    GeoCoordinate coor = watcher.Position.Location;
                    lab1.Content = coor.Latitude;
                    lab2.Content = coor.Longitude;
                }
         }

        private void ButtonLogout_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Authorization authorization = new Authorization();
            authorization.Show();
        }

        private void ButtonAccount_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonSettings_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonHelp_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ButtonHide_Click(object sender, RoutedEventArgs e)
        {
            ButtonShow.Visibility = Visibility.Visible;
            ButtonHide.Visibility = Visibility.Collapsed;
        }

        private void ButtonShow_Click(object sender, RoutedEventArgs e)
        {
            ButtonShow.Visibility = Visibility.Collapsed;
            ButtonHide.Visibility = Visibility.Visible;
        }

        private void ListViewItem_Selected(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Name_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void MainView_Selected(object sender, RoutedEventArgs e)
        {
            MainGrid.Visibility = Visibility.Visible;
        }

        private void GPS_Button_Click(object sender, RoutedEventArgs e)
        {
            LocationIP location = new LocationIP();
            location.Show();
        }

        private void MainGrid_Loaded(object sender, RoutedEventArgs e)
        {
            Watcher = new GeoCoordinateWatcher();
            Watcher.StatusChanged += Watcher_StatusChanged;
            Watcher.Start();
        }

        private void TimerOut_Click(object sender, RoutedEventArgs e)
        {
            Timer timer = new Timer();
            timer.Show();
        }

        private void HistoryButton_Click(object sender, RoutedEventArgs e)
        {
            History history = new History();
            history.Show();
        }

        private void DataTableItem_Selected(object sender, RoutedEventArgs e)
        {
            MainGrid.Visibility = Visibility.Hidden;
        }

        private void ContactItem_Selected(object sender, RoutedEventArgs e)
        {
            MainGrid.Visibility = Visibility.Hidden;
        }
    }
}
