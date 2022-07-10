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
    /// Логика взаимодействия для PageCreatepc.xaml
    /// </summary>
    public partial class PageCreatepc : Page
    {
         int generalPrice;

        public PageCreatepc()
        {
            InitializeComponent();
            
            CmbGPU.SelectedValuePath = "Id";
            CmbGPU.DisplayMemberPath = "Name";
            CmbGPU.ItemsSource = OdbConnectHelper.rspcdb.Videocard.ToList();

            CmbCPU.SelectedValuePath = "Id";
            CmbCPU.DisplayMemberPath = "model";
            CmbCPU.ItemsSource = OdbConnectHelper.rspcdb.CPU.ToList();

            CmbMth.SelectedValuePath = "Id";
            CmbMth.DisplayMemberPath = "Name";
            

            CmbOP.SelectedValuePath = "Id";
            CmbOP.DisplayMemberPath = "Name";
            CmbOP.ItemsSource = OdbConnectHelper.rspcdb.RAM.ToList();

            Cmbbp.SelectedValuePath = "Id";
            Cmbbp.DisplayMemberPath = "Name";
            Cmbbp.ItemsSource = OdbConnectHelper.rspcdb.pcpowersupply.ToList();

            CmbHDD.SelectedValuePath = "Id";
            CmbHDD.DisplayMemberPath = "Name";
            CmbHDD.ItemsSource = OdbConnectHelper.rspcdb.HDD.ToList();

            CmbSSD.SelectedValuePath = "Id";
            CmbSSD.DisplayMemberPath = "Name";
            CmbSSD.ItemsSource = OdbConnectHelper.rspcdb.SSD.ToList();

            CmbCPUCooler.SelectedValuePath = "Id";
            CmbCPUCooler.DisplayMemberPath = "Name";
            CmbCPUCooler.ItemsSource = OdbConnectHelper.rspcdb.Cooling.ToList();

            CmbCase.SelectedValuePath = "Id";
            CmbCase.DisplayMemberPath = "Name";
            CmbCase.ItemsSource = OdbConnectHelper.rspcdb.Case.ToList();

            

        }

        private void BtnGoback_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmobj.GoBack();
        }

        

        public void CmbCPU_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //умные мысли преследовали тебя, но ты оказался быстрее!
            
            var idCPU = Convert.ToInt32(CmbCPU.SelectedValue);
            var cpuObj = OdbConnectHelper.rspcdb.CPU.Where(x=> x.Id==idCPU).FirstOrDefault();
            
            
            
           
            CmbMth.ItemsSource = OdbConnectHelper.rspcdb.Motherboard.Where(x => x.IdSocket == cpuObj.IdSocket).ToList();
            //cpu price
            var cpuPrice = cpuObj.price;
            pricepc.Text = cpuPrice.ToString();
           
    
            
            

        }

        private void btncreatepc_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                PC pcaddobj = new PC()
                {
                    Name = Namepc.Text,
                    CPU = CmbCPU.SelectedItem as CPU,
                    Motherboard = CmbMth.SelectedItem as Motherboard,
                    Videocard = CmbGPU.SelectedItem as Videocard,
                    RAM = CmbOP.SelectedItem as RAM,
                    pcpowersupply = Cmbbp.SelectedItem as pcpowersupply,
                    HDD = CmbHDD.SelectedItem as HDD,
                    SSD = CmbSSD.SelectedItem as SSD,
                    Cooling = CmbCPUCooler.SelectedItem as Cooling,
                    Case = CmbCase.SelectedItem as Case
                   

                 };

                OdbConnectHelper.rspcdb.PC.Add(pcaddobj);
                OdbConnectHelper.rspcdb.SaveChanges();

            }
            catch (Exception)
            {

                MessageBox.Show("Произошла ошибка");
            }
            MessageBox.Show("Компьютер создан!");
        }

        private void CmbMth_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
             //motherboard price

                var motherboardObj = Convert.ToInt32(CmbMth.SelectedValue);

                var motherboardPrice = OdbConnectHelper.rspcdb.Motherboard.Where(x=> x.Id == motherboardObj).FirstOrDefault();

                var cpuPrice = Convert.ToInt32(pricepc.Text);
                
                generalPrice = cpuPrice + Convert.ToInt32(motherboardPrice.Price);
                pricepc.Text = Convert.ToString(generalPrice);


        }

        private void CmbGPU_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CmbOP_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Cmbbp_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CmbHDD_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CmbSSD_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CmbCPUCooler_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CmbCase_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
