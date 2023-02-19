using Assignment2_Group4_SE1610.Controll;
using Assignment2_Group4_SE1610.Models;
using Assignment2_Group4_SE1610.View;
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


namespace Assignment2_Group4_SE1610
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void cartTitle_Click(object sender, RoutedEventArgs e)
        {
            //cartWindow
            CartWindow cart = new CartWindow();
            cart.Show();

        }

        private void loginMBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Settings.UserName == null)
            {
                LoginWindow login = new LoginWindow();
                login.Show();
                Window_Loaded(sender, e);
            }
            else
            {
                MessageBoxResult messageBoxResult = MessageBox.Show("Do you want to logout?", "Confirm", System.Windows.MessageBoxButton.YesNo);
                if(messageBoxResult == MessageBoxResult.Yes)
                {
                    Settings.UserName = null;
                    Window_Loaded(sender, e);

                }
            }
        }

        private void albumMenu_Click(object sender, RoutedEventArgs e)
        {
            //ablumwindow
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            ShopingWindown shoping = new ShopingWindown();
            shoping.Show();
        }
        public static int getTotalItemInCart(string cartId)
        {
            var context = new MusicStoreContext();
            return context.Carts.Count(x => x.CartId == cartId);
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (Settings.UserName == null)
            {
                loginMBtn.Header = "Login";
                cartTitle.Header = "Cart " + "(" + getTotalItemInCart(ShoppingCart.GetCart().GetCartId()) + ")";
                albumMenu.IsEnabled = false;
            }
            else
            {
                loginMBtn.Header = "Logout" + " (" + Settings.UserName + ")";
                cartTitle.Header = "Cart " + "(" + getTotalItemInCart(ShoppingCart.GetCart().GetCartId()) + ")";
                if (Settings.Role == 1)
                {
                    albumMenu.IsEnabled = true;
                }
                else
                {
                    albumMenu.IsEnabled = false;
                }
            }
        }
    }
}
