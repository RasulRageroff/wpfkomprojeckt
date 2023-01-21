using komproject.DataFiles;
using komproject.page_pcaccessories_informations;
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
    /// Логика взаимодействия для Pageinpcperiphery.xaml
    /// </summary>
    public partial class Pageinpcperiphery : Page
    {
        public Pageinpcperiphery()
        {
            InitializeComponent();

        }

        private void Listperiphery_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            if (Listperiphery.SelectedValue == VCRDbox)
            {
                GridList.ItemsSource = OdbConnectHelper.rspcdb.Videocard.ToList();
            }
            if (Listperiphery.SelectedValue == MTHbox)
            {
                GridList.ItemsSource = OdbConnectHelper.rspcdb.Motherboard.ToList();
            }
            if (Listperiphery.SelectedValue == HDDbox)
            {
                GridList.ItemsSource = OdbConnectHelper.rspcdb.HDD.ToList();
            }
            if (Listperiphery.SelectedValue == SSDbox)
            {
                GridList.ItemsSource = OdbConnectHelper.rspcdb.SSD.ToList();
            }
            if (Listperiphery.SelectedValue == COOLERbox)
            {
                GridList.ItemsSource = OdbConnectHelper.rspcdb.Cooling.ToList();
            }
            if (Listperiphery.SelectedValue == BPbox)
            {
                GridList.ItemsSource = OdbConnectHelper.rspcdb.pcpowersupply.ToList();
            }
            if (Listperiphery.SelectedValue == CPUbox)
            {
                GridList.ItemsSource = OdbConnectHelper.rspcdb.CPU.ToList();
            }
            if (Listperiphery.SelectedValue == RAMbox)
            {
                GridList.ItemsSource = OdbConnectHelper.rspcdb.RAM.ToList();
            }

        }

        private void Btninformation_Click(object sender, RoutedEventArgs e)
        {
            if (Listperiphery.SelectedValue == VCRDbox)
            {
             FrameApp.frmobj.Navigate(new videocardinfo((sender as Button).DataContext as Videocard)) ;
                
            }
            else if (Listperiphery.SelectedValue == MTHbox)
            {     
                FrameApp.frmobj.Navigate(new motherboardinfo((sender as Button).DataContext as Motherboard));           
            }
            else if (Listperiphery.SelectedValue == CPUbox)
            {
                FrameApp.frmobj.Navigate(new cpuinfo((sender as Button).DataContext as CPU));
            }
            else if (Listperiphery.SelectedValue == SSDbox)
            {
                FrameApp.frmobj.Navigate(new ssdinfo((sender as Button).DataContext as SSD));
            }
            else if (Listperiphery.SelectedValue == HDDbox)
            {
                FrameApp.frmobj.Navigate(new hddinfo((sender as Button).DataContext as HDD));
            }
            else if (Listperiphery.SelectedValue == BPbox)
            {
                FrameApp.frmobj.Navigate(new bpinfo((sender as Button).DataContext as pcpowersupply));
            }
            else if (Listperiphery.SelectedValue == RAMbox)
            {
                FrameApp.frmobj.Navigate(new raminfo((sender as Button).DataContext as RAM));
            }          
            else if (Listperiphery.SelectedValue == COOLERbox)
            {
                FrameApp.frmobj.Navigate(new cpucoolerinfo((sender as Button).DataContext as Cooling));
            }
        }

        private void BtnGoback_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmobj.GoBack();
        }
    }
}
