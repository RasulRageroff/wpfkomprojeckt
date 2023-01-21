using komproject.DataFiles;
using komproject.Pages;
using System;
using System.Collections.Generic;
using System.Drawing;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Brushes = System.Windows.Media.Brushes;
using Image = System.Drawing.Image;

namespace komproject.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();

            OdbConnectHelper.rspcdb = new RasulpcEntities1();
        }

        private void Btnregistration_Click(object sender, RoutedEventArgs e)
        {
            if (OdbConnectHelper.rspcdb.User.Count(x => x.Login == TxbLogin.Text) > 0)
            {
                MessageBox.Show("Такой пользователь уже есть");
            }
            else
            {

                try
                {
                    User UserObj = new User()
                    {
                        Login = TxbLogin.Text,
                        Password = Psbpassword.Password,
                        IdRole = 2
                    };

                    OdbConnectHelper.rspcdb.User.Add(UserObj);
                    OdbConnectHelper.rspcdb.SaveChanges();

                    MessageBox.Show("Пользователь создан!");

                    LoginWindows taskWindow = new LoginWindows();
                    taskWindow.Show();
                    Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка работы приложения");

                }


            }
        }

        private void secondpsbpassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (secondpsbpassword.Password == Psbpassword.Password)
            {
                Btnregistration.IsEnabled = true;
                secondpsbpassword.BorderBrush = Brushes.LightGreen;
                secondpsbpassword.Background = Brushes.LightGreen;
            }
            else
            {
                Btnregistration.IsEnabled = false;
                secondpsbpassword.Background = Brushes.DarkRed;
                secondpsbpassword.BorderBrush = Brushes.DarkRed;
            }
        }
    }
}
