using HomeDepotWebApp.Models;
using System.Windows;
using System.Windows.Controls;
using HomeDepotWebApp.Storage;

namespace HomeDepotDesktopApp {
    /// <summary>
    /// Interaction logic for RentOverview.xaml
    /// </summary>
    public partial class RentOverview : Page {
        private HomeDepotContext _context;

        public RentOverview(Rent rent) {
            _context = new HomeDepotContext();
            InitializeComponent();
            id.Text = rent.Id.ToString();
            tool.Text = rent.RentTool.Name;
            pickup.Text = rent.PickUp;
            days.Text = rent.Days.ToString();

        }
        private void mExit_Click(object sender, RoutedEventArgs e) {
            Application.Current.Shutdown();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e) {
            this.NavigationService.Content = new CreateCustomerSite();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e) {
            this.NavigationService.Content = new HomePage();
        }
    }
}
