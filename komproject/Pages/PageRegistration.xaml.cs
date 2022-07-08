using komproject.DataFiles;
using System;
using System.Collections.Generic;
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

namespace komproject.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageRegistration.xaml
    /// </summary>
    public partial class PageRegistration : Page
    {
        public PageRegistration()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btncreatee_Click(object sender, RoutedEventArgs e)
        {
            if(OdbConnectHelper.rspcdb.User.Count(x=> x.Login == txblogin.Text) > 0)
            {
                MessageBox.Show("Такой пользователь уже есть");
            }
            else
            {

                try
                {
                    User UserObj = new User()
                    {
                        Login = txblogin.Text,
                        Password = Apassw.Password,
                        IdRole = 2
                    };

                    OdbConnectHelper.rspcdb.User.Add(UserObj);
                    OdbConnectHelper.rspcdb.SaveChanges();

                MessageBox.Show("Пользователь создан!");
                FrameApp.frmobj.Navigate(new PageLogin());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка работы приложения");

                }


            }

        }

        

        private void Apassw_PasswordChanged_1(object sender, RoutedEventArgs e)
        {
            if(Apassw.Password == Passw.Password)
            {
                btncreatee.IsEnabled = true;
                Apassw.BorderBrush = Brushes.LightGreen;
                Apassw.Background = Brushes.LightGreen;
            }
            else
            {
                btncreatee.IsEnabled = false;
                Apassw.Background = Brushes.DarkRed;
                Apassw.BorderBrush = Brushes.DarkRed;
            }
        }

        private void BtnGoback_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmobj.GoBack();
        }
    }
}
