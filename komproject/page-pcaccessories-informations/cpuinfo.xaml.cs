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
    /// Логика взаимодействия для cpuinfo.xaml
    /// </summary>
    public partial class cpuinfo : Page
    {
        public cpuinfo(CPU cpu)
        {
            InitializeComponent();
            txtcpuname.Text = cpu.Name;
        }

        private void BtnGoback_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmobj.GoBack();
        }
    }
}
