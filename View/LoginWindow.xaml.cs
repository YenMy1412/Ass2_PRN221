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
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            String userName = txtUserName.Text;
            String password = txtPassword.Password;
            User user = getUser(userName, password);
            if (user != null)
            {
                Settings.UserName = user.UserName;
                
                this.Close();
                MainWindow newWindow = new MainWindow();
                Application.Current.MainWindow.Close();
                Application.Current.MainWindow = newWindow;
                newWindow.Show();
            }
            else
            {
                MessageBox.Show("Don't have that user");

            }

        }
        public User getUser(string userName, string password)
        {
            User user;
            try
            {
                var context = new MusicStoreContext();
                user = context.Users.FirstOrDefault(x => x.UserName.Equals(userName) && x.Password.Equals(password));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return user;
        }
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
