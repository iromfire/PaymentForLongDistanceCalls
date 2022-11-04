using iTextSharp.text.pdf;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PaymentForLongDistanceCalls.Windows
{
    /// <summary>
    /// Логика взаимодействия для AllServices.xaml
    /// </summary>
    public partial class AllServices : Window
    {
        CallsEntities db = new CallsEntities();

        public AllServices()
        {
            InitializeComponent();
            Get();
        }

        private void Get()
        {
            var query =
            from service in db.Service
            orderby service.ServiceId
            select new { service.Date, service.City, service.OneMinuteCost, service.SaleCost };
            dataGrid.ItemsSource = query.ToList();
        }

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            Get();
        }

        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Close();
        }

        private void SaveToPDF_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
