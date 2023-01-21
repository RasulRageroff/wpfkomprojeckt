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



        public PageCreatepc()
        {
            InitializeComponent();

            CmbGPU.SelectedValuePath = "Id";
            CmbGPU.DisplayMemberPath = "Name";
            CmbGPU.ItemsSource = OdbConnectHelper.rspcdb.Videocard.ToList();

            CmbCPU.SelectedValuePath = "Id";
            CmbCPU.DisplayMemberPath = "Name";
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
        pricekomp prcobsh = new pricekomp();
        int pribavlenie = 0;



        private void BtnGoback_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmobj.GoBack();
        }



        public void CmbCPU_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //умные мысли преследовали тебя, но ты оказался быстрее!

            var idCPU = Convert.ToInt32(CmbCPU.SelectedValue);
            var cpuObj = OdbConnectHelper.rspcdb.CPU.Where(x => x.Id == idCPU).FirstOrDefault();




            CmbMth.ItemsSource = OdbConnectHelper.rspcdb.Motherboard.Where(x => x.IdSocket == cpuObj.IdSocket).ToList();
            //cpu price



            prcobsh.priceobsh += (int)cpuObj.Price;

            pricepc.Text = prcobsh.priceobsh.ToString();


        }



        

        public void CmbMth_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            //motherboard price

            var motherboardObj = Convert.ToInt32(CmbMth.SelectedValue);

            var motherboardPrice = OdbConnectHelper.rspcdb.Motherboard.Where(x => x.Id == motherboardObj).FirstOrDefault();







            prcobsh.priceobsh += (int)motherboardPrice.Price;

            pricepc.Text = prcobsh.priceobsh.ToString();


        }

        private void CmbGPU_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            var videocarddObj = Convert.ToInt32(CmbGPU.SelectedValue);

            var videocarPrice = OdbConnectHelper.rspcdb.Videocard.Where(x => x.Id == videocarddObj).FirstOrDefault();

            prcobsh.priceobsh += (int)videocarPrice.Price;

            pricepc.Text = prcobsh.priceobsh.ToString();


        }

        private void CmbOP_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var RAMObj = Convert.ToInt32(CmbOP.SelectedValue);

            var RAMPrice = OdbConnectHelper.rspcdb.RAM.Where(x => x.Id == RAMObj).FirstOrDefault();

            prcobsh.priceobsh += (int)RAMPrice.Price;

            pricepc.Text = prcobsh.priceobsh.ToString();



        }

        private void Cmbbp_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var pcpowersupplyObj = Convert.ToInt32(Cmbbp.SelectedValue);

            var pcpowersupplyPrice = OdbConnectHelper.rspcdb.pcpowersupply.Where(x => x.Id == pcpowersupplyObj).FirstOrDefault();

            prcobsh.priceobsh += (int)pcpowersupplyPrice.Price;

            pricepc.Text = prcobsh.priceobsh.ToString();
        }

        private void CmbHDD_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var HDDObj = Convert.ToInt32(CmbHDD.SelectedValue);

            var HDDPrice = OdbConnectHelper.rspcdb.HDD.Where(x => x.Id == HDDObj).FirstOrDefault();

            prcobsh.priceobsh += (int)HDDPrice.Price;

            pricepc.Text = prcobsh.priceobsh.ToString();
        }

        private void CmbSSD_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var SSDObj = Convert.ToInt32(CmbSSD.SelectedValue);

            var SSDPrice = OdbConnectHelper.rspcdb.SSD.Where(x => x.Id == SSDObj).FirstOrDefault();

            prcobsh.priceobsh += (int)SSDPrice.Price;

            pricepc.Text = prcobsh.priceobsh.ToString();
        }

        private void CmbCPUCooler_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var CoolingObj = Convert.ToInt32(CmbCPUCooler.SelectedValue);

            var CoolingPrice = OdbConnectHelper.rspcdb.Cooling.Where(x => x.Id == CoolingObj).FirstOrDefault();

            prcobsh.priceobsh += (int)CoolingPrice.Price;

            pricepc.Text = prcobsh.priceobsh.ToString();
        }

        private void CmbCase_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var CaseObj = Convert.ToInt32(CmbCase.SelectedValue);

            var CasePrice = OdbConnectHelper.rspcdb.Case.Where(x => x.Id == CaseObj).FirstOrDefault();

            prcobsh.priceobsh += (int)CasePrice.Price;

            pricepc.Text = prcobsh.priceobsh.ToString();
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
                    Case = CmbCase.SelectedItem as Case,
                    price = prcobsh.priceobsh

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




    }
}
