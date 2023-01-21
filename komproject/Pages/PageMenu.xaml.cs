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
    /// Логика взаимодействия для PageMenu.xaml
    /// </summary>
    public partial class PageMenu : Page
    {
        public PageMenu()
        {
            InitializeComponent();

           

           
        }

        private void Createpc_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmobj.Navigate(new PageCreatepc());
        }

        private void Topinpc_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmobj.Navigate(new pagetopik());
        }

        private void POforpc_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnGoback_Click(object sender, RoutedEventArgs e)
        {
           /////exit
        }

        private void Mycomputers_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmobj.Navigate(new mycomputerspage());
        }

        private void PCaccessories_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmobj.Navigate(new Pageinpcperiphery());
        }
    }
}
