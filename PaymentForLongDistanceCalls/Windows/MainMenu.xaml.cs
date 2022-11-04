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
using System.Windows.Shapes;

namespace PaymentForLongDistanceCalls.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void GoAllClients_Click(object sender, RoutedEventArgs e)
        {
            AllClients allClients = new AllClients();
            allClients.Show();
            this.Close();
        }

        private void GoAllServices_Click(object sender, RoutedEventArgs e)
        {
            AllServices allServices = new AllServices();
            allServices.Show();
            this.Close();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
           Environment.Exit(0);
        }

        private void AddClientButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow addClient = new MainWindow();
            addClient.Show();
            this.Close();
        }  
    }
}
