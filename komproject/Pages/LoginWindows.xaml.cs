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
using System.Xml.Linq;
using static komproject.dataconnect;
using Image = System.Drawing.Image;

namespace komproject.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginWindows.xaml
    /// </summary>
    public partial class LoginWindows : Window
    {
        public LoginWindows()
        {
            InitializeComponent();
            
            OdbConnectHelper.rspcdb = new RasulpcEntities1();
            dataconnect dtc = new dataconnect();
        }

        

        private void BtnLogins_Click(object sender, RoutedEventArgs e)
        {

            dataconnect dtc = new dataconnect();


            



            try
            {
                

                var userObj = OdbConnectHelper.rspcdb.User.FirstOrDefault(
                    x => x.Login == TxbLoginn.Text && x.Password == Psbpasswordd.Password

                    );
                if (userObj == null)
                {
                    MessageBox.Show("Такого пользователя нету");
                }
                else
                {
                    


                    switch (userObj.IdRole)
                    {
                        case 1:
                            dataconnect.nicknames = TxbLoginn.Text;
                            MessageBox.Show("Ты Админ");
                            
                            break;
                        case 2:
                            dataconnect.nicknames = TxbLoginn.Text;
                            MainWindow skWindow = new MainWindow();
                            skWindow.Show();


                            Hide();

                            break;
                    }
                }




            }
            catch (Exception)
            {
                MessageBox.Show("Критический сбой в работе приложения");
            }

            

        }

        private void BtnRegistrations_Click(object sender, RoutedEventArgs e)
        {
           

            RegistrationWindow taskWindow = new RegistrationWindow();
            taskWindow.Show();
            Hide();


        }

        
    }
}
