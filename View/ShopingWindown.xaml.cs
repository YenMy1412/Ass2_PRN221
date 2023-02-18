using Assignment01.Models;
using Assignment2_Group4_SE1610.Controll;
using Assignment2_Group4_SE1610.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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
    /// Interaction logic for ShopingWindown.xaml
    /// </summary>
    /// 
    public partial class ShopingWindown : Window
    {
        MusicStoreContext context;
        PaginatedList<Album> pages;
        String a;
        public ShopingWindown()
        {
            InitializeComponent();
            context = new MusicStoreContext();
            cbgenre.ItemsSource = context.Genres.ToList();
            cbgenre.SelectedIndex = 0;
            bindGrid(1);
        }
        private void ShoppingWindown_CLick(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            Album album = b.CommandParameter as Album;

            ShoppingCart cart = ShoppingCart.GetCart();
            cart.AddToCart(album);
            e.Handled = true;

            CartWindow cartWindown = new CartWindow();
            cartWindown.Show();
        }
        private void bindGrid(int pageIndex)
        {
            var albumsIQ = context.Albums.Where(a => a.GenreId == (int)cbgenre.SelectedValue);
            int i = 0;
            foreach (var sp in listview.Children)
            {
                foreach (var obj in ((StackPanel)sp).Children)
                {
                    if (obj is Image)
                    {
                        ((Image)obj).Source = null;
                    }
                    if (obj is Label)
                    {
                        ((Label)obj).Content = "";
                    }
                    if (obj is Button)
                    {
                        ((Button)obj).Visibility = Visibility.Hidden;
                    }
                }
                i++;
            }
            i = 0;

            pages = PaginatedList<Album>.Create(albumsIQ, pageIndex, 4);
            foreach (var sp in listview.Children)
            {
                if (i < pages.Count)
                
                    foreach (var obj in ((StackPanel)sp).Children)
                    {
                        if (obj is Image)
                        
                          try  
                            {
                                string path = pages[i].AlbumUrl.Replace('/', '\\');
                                ((Image)obj).Source = new BitmapImage(new Uri($"file://{Directory.GetCurrentDirectory()}{path}")); 

                               

                            }
                            catch
                            { 
                            }
                            
                        
                        if (obj is Label)
                          
                        ((Label)obj).Content = $"{pages[i].Title}: {pages[i].Price} USD";
                        
                        if (obj is Button)
                        {
                            Button btnAdd = ((Button)obj);
                            btnAdd.Visibility = Visibility.Visible;
                            btnAdd.CommandParameter = pages[i];
                            btnAdd.Click += ShoppingWindown_CLick;
                        }

                    }
                    i++;
                

            }
            btnNext.IsEnabled = pages.HasNextPage;
            btnPre.IsEnabled = pages.HasPreviousPage;

        }



        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            bindGrid(1);
        }

        private void btnPre_Click(object sender, RoutedEventArgs e)
        {
            bindGrid(pages.PageIndex - 1);
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            bindGrid(pages.PageIndex + 1);
        }
    }
}
