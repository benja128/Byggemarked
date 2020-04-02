using HomeDepotWebApp.Models;
using System.Windows;
using System.Windows.Controls;
using HomeDepotWebApp.Storage;
using System;

namespace HomeDepotDesktopApp {
    /// <summary>
    /// Interaction logic for RentOverview.xaml
    /// </summary>
    public partial class RentOverview : Page {
        private HomeDepotContext _context;
        private Rent thisRent;
        public RentOverview(Rent rent) {
            _context = new HomeDepotContext();
            InitializeComponent();
            thisRent = rent;
            id.Text = rent.Id.ToString();
            tool.Text = rent.RentTool.Name;
            pickup.Text = rent.PickUp;
            days.Text = rent.Days.ToString();
            combo.ItemsSource = Enum.GetValues(typeof(Status));
            combo.SelectedItem = rent.Status;
        }
        private void mExit_Click(object sender, RoutedEventArgs e) {
            Application.Current.Shutdown();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e) {
            this.NavigationService.Content = new CreateCustomerSite();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e) {
            this.NavigationService.Content = new CustomerOverview(thisRent.Customer);
        }
        private void Button_Click(object sender, RoutedEventArgs e) {
            if (combo.Text.Equals("Reserveret")) {
                _context.Rents.Find(thisRent.Id).Status = Status.Reserveret;
            } else if (combo.Text.Equals("Udleveret")) {
                _context.Rents.Find(thisRent.Id).Status = Status.Udleveret;
            } else if (combo.Text.Equals("Tilbageleveret")) {
                _context.Rents.Find(thisRent.Id).Status = Status.TilbageLeveret;
            }
            _context.SaveChanges();
            this.NavigationService.Content = new CustomerOverview(thisRent.Customer);
        }
    }
}
