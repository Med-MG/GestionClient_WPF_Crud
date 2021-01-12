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

namespace GestionClient
{
    /// <summary>
    /// Interaction logic for UpdatePage.xaml
    /// </summary>
    public partial class UpdatePage : Window
    {
        GestionClientdbEntitiesL _db = new GestionClientdbEntitiesL();
        int Id;
        public UpdatePage(int ClientId)
        {
            InitializeComponent();
            Id = ClientId;
        }

        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            Client updateClient = (from c in _db.Clients where c.id == Id select c).Single();
            updateClient.FirstName = firstNameTbox.Text;
            updateClient.LastName = lastNameTbox.Text;
            updateClient.Address = AddressTbox.Text;
            updateClient.City = CityBox.Text;
            _db.SaveChanges();
            MainWindow.datagrid.ItemsSource = _db.Clients.ToList();
            this.Hide();
        }
    }
}
