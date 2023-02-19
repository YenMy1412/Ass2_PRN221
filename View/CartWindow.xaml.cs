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
    /// Interaction logic for CartWindow.xaml
    /// </summary>
    public partial class CartWindow : Window
    {
        MusicStoreContext context;
        public CartWindow()
        {
            InitializeComponent();
            context = new MusicStoreContext();

            ShoppingCart cart = ShoppingCart.GetCart();
            listView.ItemsSource = cart.GetCartItems();
            txtTotal.Text = cart.GetTotal().ToString(".00");

            btnCheckout.IsEnabled = !string.IsNullOrEmpty(Settings.UserName) && cart.GetTotal() > 0;
        }

        private void btnCheckout_Click(object sender, RoutedEventArgs e)
        {
            CheckoutWindow checkoutWindow = new CheckoutWindow();
            checkoutWindow.ShowDialog();
            Close();

        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            Cart c = b.CommandParameter as Cart;
            ShoppingCart cart = ShoppingCart.GetCart();
            cart.RemoveFromCart(c.RecordId);
            btnCheckout.IsEnabled = !string.IsNullOrEmpty(Settings.UserName) && cart.GetTotal() > 0;
            listView.ItemsSource = cart.GetCartItems();
            txtTotal.Text = cart.GetTotal().ToString(".00");
        }
    }
}
