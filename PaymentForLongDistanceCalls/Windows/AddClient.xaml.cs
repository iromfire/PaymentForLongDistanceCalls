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
using PaymentForLongDistanceCalls.Windows;

namespace PaymentForLongDistanceCalls
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CallsEntities db = new CallsEntities();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Client client = new Client
                {
                    PhoneNumber = Int64.Parse(PhoneNumberTB.Text),
                    FullName = FullNameTB.Text,
                    Adress = AdressTB.Text,
                    RegistrationDate = DateTime.Parse(RegistrationDateTB.Text)
                };
                db.Client.Add(client);
                db.SaveChanges();
                MessageBox.Show("Пользователь добавлен");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка:" + ex);
                this.Close();
            }
           
        }
    }
}
