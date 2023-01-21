using komproject.DataFiles;
using komproject.Pages;
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
using static komproject.dataconnect;
using static komproject.Pages.LoginWindows;

namespace komproject
{
    /// <summary> 
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            UserNames.Text = dataconnect.nicknames;
            FrameApp.frmobj = FrmMain;
            OdbConnectHelper.rspcdb = new RasulpcEntities1();
            FrmMain.Navigate(new PageMenu());
            
            
            




        }

        
        
    }
}
