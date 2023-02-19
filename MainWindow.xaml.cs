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
            //Settings user = new Settings();
            ReLoad();
            
        }

        private void menuLogin_Click(object sender, RoutedEventArgs e)
        {
            
            if(Settings.UserName == null)
            {
                Window1 login = new Window1();
                login.Show();
                ReLoad();
            }
             if (Settings.UserName != null)
            {
                Settings.UserName = null;
            }
                }
        public void ReLoad()
        {
            if (Settings.UserName != null)
            {
                menuLogin.Header = "Logout (" + Settings.UserName + ")";
            }
        }
        

        private void menuShopping_Click(object sender, RoutedEventArgs e)
        {

        }

        private void menuCart_Click(object sender, RoutedEventArgs e)
        {

        }

        private void menuAlbum_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
