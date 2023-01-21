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
    /// Логика взаимодействия для ssdinfo.xaml
    /// </summary>
    public partial class ssdinfo : Page
    {
        public ssdinfo(SSD ssd)
        {
            InitializeComponent();
            nametag.Text = ssd.Name;
            price.Text = ssd.Price.ToString();
            Writingspeed.Text = ssd.Writingspeed;
            Readingspeed.Text = ssd.ReadingSpeed;
            Formfactor.Text = ssd.Formfactor;
        }

        private void BtnGoback_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmobj.GoBack();
        }
    }
}
