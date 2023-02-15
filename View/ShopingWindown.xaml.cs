using Assignment2_Group4_SE1610.Models;
using System;
using System.Collections.Generic;
using System.Data;
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
        public ShopingWindown()
        {
            InitializeComponent();
            context=new MusicStoreContext();
            loadData();

        }
        public void loadData()
        {
            var genre = from c in context.Genres select c.Name;
            DataSet dataset = new DataSet();
            cbgenre.Items.Clear();
            cbgenre.ItemsSource = genre.ToList();

        }
    }
}
