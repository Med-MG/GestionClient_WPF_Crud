using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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

namespace GestionClient
{
    /// <summary>
    /// Interaction logic for InsertPage.xaml
    /// </summary>
    public partial class InsertPage : Window
    {
        GestionClientdbEntitiesL _db = new GestionClientdbEntitiesL();
        public InsertPage()
        {
            InitializeComponent();
        }

        private void insertBtn_Click(object sender, RoutedEventArgs e)
        {
            Client newClient = new Client()
            {
                FirstName = firstNametbox.Text,
                LastName = lastNametbox.Text,
                Address = Address.Text,
                City = CityBox.Text

            };

            _db.Clients.Add(newClient);
            _db.SaveChanges();
            MainWindow.datagrid.ItemsSource = _db.Clients.ToList();
            this.Hide();
             


        }
    }
}
