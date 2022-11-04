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
    public partial class AllClients : Window
    {

        CallsEntities db = new CallsEntities();
        private int index = 0;

        public AllClients()
        {
            InitializeComponent();
            Get();
            GetComboBox();
        }
      
        private void Get()
        {
           var query =
           from client in db.Client
           orderby client.ClientID
           select new { client.PhoneNumber, client.FullName, client.Adress, client.RegistrationDate };
           dataGrid.ItemsSource = query.ToList();
        }

        private void GetComboBox()
        {
            foreach (Client c in db.Client)
            {
                comboBox.Items.Insert(index, c.FullName);
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow addClient = new MainWindow();
            addClient.Show();           
        }

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            Get();
            GetComboBox();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            {
                System.Windows.Forms.DialogResult dialogResult = (System.Windows.Forms.DialogResult)MessageBox.Show("Действительно хотите удалить?", "Удаление", MessageBoxButton.OKCancel);
                if (dialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    try
                    {
                        var clients = db.Client.ToList();
                        var selected = comboBox.SelectedItem.ToString();
                        foreach (Client c in clients)
                        {
                            if (selected == c.FullName)
                            {
                                db.Client.Remove(c);
                                db.SaveChanges();
                                MessageBox.Show("Удалено!");
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Пользователь из выпадающего списка не выбран");
                    }
                }
            }          
        }

        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Close();
        }
    }
}
