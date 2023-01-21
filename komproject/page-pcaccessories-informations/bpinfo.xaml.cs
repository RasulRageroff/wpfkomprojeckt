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
    /// Логика взаимодействия для bpinfo.xaml
    /// </summary>
    public partial class bpinfo : Page
    {
        public bpinfo(pcpowersupply BP)
        {
            InitializeComponent();
            nametag.Text = BP.Name;
            price.Text = BP.Price.ToString();
            power.Text = BP.Power;
            PFC.Text = BP.PFC;
            FormFactor.Text = BP.FormFactor;
            Sertificate.Text = BP.certificate;
            dfans.Text = BP.Fansize;
        }

        private void BtnGobackk_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmobj.GoBack();
        }
    }
}