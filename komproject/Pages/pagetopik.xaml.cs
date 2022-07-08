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
using komproject.DataFiles;
using komproject.Pages;
using komproject.Properties;


namespace komproject.Pages
{
    /// <summary>
    /// Логика взаимодействия для pagetopik.xaml
    /// </summary>
    public partial class pagetopik : Page
    {
        public pagetopik()
        {
            InitializeComponent();
            //Namepcs.Text = OdbConnectHelper.rspcdb.PC.Where(x => x.Name == Name).FirstOrDefault().ToString();

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += updateData;
            timer.Start();

        }

        public void updateData(object sender, object e)
        {
            var idinahuy = OdbConnectHelper.rspcdb.PC.ToList();
            ListProduct.ItemsSource = idinahuy;

            ListProduct.ItemsSource = OdbConnectHelper.rspcdb.PC.Where(x => x.Name.StartsWith(TxtSearch.Text)).ToList();
        }

        private void btnback_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmobj.GoBack();
        }


 
    }
}
