using Assignment2_Group4_SE1610.Controll;
using Assignment2_Group4_SE1610.Models;
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

namespace Assignment2_Group4_SE1610.View
{
    /// <summary>
    /// Interaction logic for CheckoutWindow.xaml
    /// </summary>
    public partial class CheckoutWindow : Window
    {
        MusicStoreContext context = new MusicStoreContext();
        ShoppingCart shopping = ShoppingCart.GetCart();
        public CheckoutWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
               
                var user = context.Users.FirstOrDefault(x => x.UserName.Equals(Settings.UserName));
                if (user != null)
                {
                    txtFirstName.Text = user.FirstName;
                    txtLastName.Text = user.LastName;
                    txtAddress.Text = user.Address;
                    txtCity.Text = user.City;
                    txtState.Text = user.State;
                    txtCountry.Text = user.Country;
                    txtPhone.Text = user.Phone;
                    txtEmail.Text = user.Email;
                   // txtTotal.Text = shopping.GetTotal().ToString();
                    if (shopping.GetTotal() == 0)
                    {
                       txtTotal.Text = "0";
                    }
                    else
                    {
                        txtTotal.Text = shopping.GetTotal().ToString();
                        Console.WriteLine(shopping.GetTotal().ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Order order = new Order();
                order.OrderDate = DateTime.Now;
                order.UserName = Settings.UserName;
                order.FirstName = txtFirstName.Text;
                order.LastName = txtLastName.Text;
                order.Address = txtAddress.Text;
                order.City = txtCity.Text;
                order.State = txtState.Text;
                order.Country = txtCountry.Text;
                order.Phone = txtPhone.Text;
                order.Email = txtEmail.Text;
                order.Total = decimal.Parse(txtTotal.Text.ToString());
                shopping.CreateOrder(order);
                MessageBox.Show("Order is saved!");
                this.Close();
                shopping.EmptyCart();
                CartWindow cartWindow = new CartWindow();
                cartWindow.Show();
                MainWindow newWindow = new MainWindow();
                Application.Current.MainWindow.Close();
                Application.Current.MainWindow = newWindow;
                newWindow.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
