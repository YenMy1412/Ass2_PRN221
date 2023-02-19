using Assignment2_Group4_SE1610.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
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

namespace Assignment2_Group4_SE1610
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        MusicStoreContext context;
        public Window1()
        {
            InitializeComponent();
            context = new MusicStoreContext();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            User user = context.Users.Where(u => u.UserName == txtUserName.Text && u.Password == txtPassword.Password).FirstOrDefault();
            if (user == null)

                MessageBox.Show("Don't have that user");
            else
            {
                Settings.UserName = user.UserName;
                Settings.Role = user.Role;
                ShoppingCart cart = ShoppingCart.GetCart();
                cart.MigrateCart();
                Close();
            }
        }
        
       
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void txtPassword_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
