using HomeDepotWebApp.Models;
using HomeDepotWebApp.Storage;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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

namespace HomeDepotDesktopApp {
    /// <summary>
    /// Interaction logic for CustomerOverview.xaml
    /// </summary>
    public partial class CustomerOverview : Page {
        private HomeDepotContext _context;
        public CustomerOverview(Customer customer) {
            _context = new HomeDepotContext();
            InitializeComponent();
            navn.Text = customer.Name;
            email.Text = customer.Email;
            brugerid.Text = customer.CustomerId.ToString();
            brugernavn.Text = customer.Username;
            password.Text = customer.Password;
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            _context.Customers.AddOrUpdate(t => t.CustomerId, new Customer { CustomerId = Int32.Parse(brugerid.Text), Name = navn.Text, Email = email.Text, Password = password.Text, Username = brugernavn.Text });
            _context.SaveChanges();
            this.NavigationService.Content = new HomePage();
        }

        private void mExit_Click(object sender, RoutedEventArgs e) {
            System.Windows.Application.Current.Shutdown();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e) {
            this.NavigationService.Content = new CreateCustomerSite();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e) {
            this.NavigationService.Content = new HomePage();
        }

        public void GoBack() {
            this.NavigationService.Content = new HomePage();
        }
    }
}
