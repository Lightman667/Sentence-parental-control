using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void LogOut_ButtonClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void LogIn_ButtonClick(object sender, RoutedEventArgs e)
        {
            string login = textbox_login.Text;
            string password = textbox_password.Password;

                SqlConnection connection = new SqlConnection(@"Data Source=light;Initial Catalog=Sentence;Persist Security Info=True;User ID=sa;Password=GtslapdGkfk1548");
                using (connection)
                {
                    connection.Open();
                    var cmd = new SqlCommand("SELECT Login, Password, Name FROM [dbo].[Authorization] WHERE Login='" + login + "' and Password = '" + password +"';", connection);
                    var reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                        {
                            if (reader.Read())
                            {
                                string nameUser = reader.GetValue(2).ToString();
                                MainWindow main = new MainWindow();
                                main.Name.Text=nameUser;
                                this.Hide();
                                main.Show();
                            } 
                        }
                    else
                        {
                            MessageBox.Show("Пароль неправильный!");
                        }
                 }
        }

        private void textbox_login_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            textbox_login.Clear();
        }

        private void textbox_password_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            textbox_password.Clear();
        }
    }
}
