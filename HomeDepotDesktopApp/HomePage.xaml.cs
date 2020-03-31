﻿using HomeDepotWebApp.Models;
using HomeDepotWebApp.Storage;
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

namespace HomeDepotDesktopApp {
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    /// 


    public partial class HomePage : Page {
        private HomeDepotContext _context;
        private List<Customer> customers;

        public HomePage() {
            InitializeComponent();
            _context = new HomeDepotContext();
            List<Tool> tools = _context.Tools.ToList<Tool>();
            customers = _context.Customers.ToList<Customer>();
            filterCostumers();

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            Customer c = (Customer)ListBoxKunder.SelectedItem;

            this.NavigationService.Content = new CustomerOverview(c);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e) {
            filterCostumers();
        }

        private void mExit_Click(object sender, RoutedEventArgs e) {
            System.Windows.Application.Current.Shutdown();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e) {
            this.NavigationService.Content = new CreateCustomerSite();
        }
        private void filterCostumers() {
            if (searchfield.Text.Length < 1) {
                this.DataContext = customers;
            } else {
                List<Customer> cust = new List<Customer>();
                foreach (Customer c in customers) {

                    if (c.Name.ToLower().Contains(searchfield.Text.ToLower())) {
                        cust.Add(c);
                    } else if (c.CustomerId.ToString().Contains(searchfield.Text.ToLower())) {
                        cust.Add(c);
                    } else if (c.Email.ToLower().Contains(searchfield.Text.ToLower())) {
                        cust.Add(c);
                    } else if (c.Username.ToLower().Contains(searchfield.Text.ToLower())) {
                        cust.Add(c);
                    }

                }
                this.DataContext = cust;
            }
        }
    }
}
