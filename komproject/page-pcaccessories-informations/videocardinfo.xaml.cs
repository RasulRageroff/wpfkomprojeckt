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
    /// Логика взаимодействия для informationpage.xaml
    /// </summary>
    public partial class videocardinfo : Page
    {
        public videocardinfo(Videocard vido)
        {

            InitializeComponent();
            
            nametag.Text = vido.Name;
            price.Text = vido.Price.ToString();

            VRAM.Text = vido.VRAM.ToString();
            VRAMType.Text = vido.VRAMType.ToString();
            BusWidth.Text = vido.BusWidth.ToString();
            RecommendedBP.Text = vido.Recommendedpowersupply.ToString();
            GPUBaseClock.Text = vido.GPUBaseClock;
            GPUBoostClock.Text = vido.GPUBoostClock;


        }




        private void BtnGoback_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmobj.GoBack();
        }
    }
}
