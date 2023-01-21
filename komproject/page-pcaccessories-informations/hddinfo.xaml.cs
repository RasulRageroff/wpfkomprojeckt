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

namespace komproject.page_pcaccessories_informations
{
    /// <summary>
    /// Логика взаимодействия для hddinfo.xaml
    /// </summary>
    public partial class hddinfo : Page
    {
        public hddinfo(HDD hdd)
        {
            InitializeComponent();

            nametag.Text = hdd.Name;
            price.Text = hdd.Price.ToString();
            FormFactor.Text = hdd.Formfactor;
            capacity.Text = hdd.Capacity;
            Cache.Text = hdd.Cache;
            Spindlespeed.Text = hdd.SpindleSpeed;
            interfacetype.Text = hdd.InterfaceType;
        }

        private void BtnGoback_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmobj.GoBack();
        }
    }
}
