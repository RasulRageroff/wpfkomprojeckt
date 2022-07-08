using komproject.DataFiles;
using komproject.Pages;
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
    /// Логика взаимодействия для PageLogin.xaml
    /// </summary>
    public partial class PageLogin : Page
    {
        public PageLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var userObj = OdbConnectHelper.rspcdb.User.FirstOrDefault(
                    x => x.Login == TxbLogin.Text && x.Password == Psbpassword.Password
                    
                    );
                if(userObj == null)
                {
                    MessageBox.Show("Такой пользователь уже есть");
                }
                else
                {
                    switch (userObj.IdRole)
                    {
                        case 1: FrameApp.frmobj.Navigate(new Pageadmin());
                            break;
                        case 2:
                            FrameApp.frmobj.Navigate(new PageMenu());
                            break;
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Критический сбой в работе приложения");
            }
        }

        private void BtnRegistration_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmobj.Navigate(new PageRegistration());
        }
    }
}
