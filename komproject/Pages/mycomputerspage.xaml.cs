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
using System.Windows.Threading;

namespace komproject.Pages
{
    /// <summary>
    /// Логика взаимодействия для mycomputerspage.xaml
    /// </summary>
    public partial class mycomputerspage : Page
    {
        public mycomputerspage()
        {

            
            InitializeComponent();
            
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += updateData; 
            timer.Start();

        }

        public void updateData(object sender, object e)
        {
            OdbConnectHelper.rspcdb.PC.ToList();
            OdbConnectHelper.rspcdb.User.ToList();

            //  var bar = OdbConnectHelper.rspcdb.PC.Where(x => x.id == x.id).FirstOrDefault();
            RasulpcEntities1 usr =  new RasulpcEntities1();
            var bar = usr.User.FirstOrDefault();
            ListProduct.ItemsSource = OdbConnectHelper.rspcdb.PC.Where(x => x.id == x.id).ToList();

                //ListProduct.ItemsSource = OdbConnectHelper.rspcdb.User.Where(x => x.Id == x.rel)
        }

        private void btnback_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmobj.GoBack();
        }
    }
}
