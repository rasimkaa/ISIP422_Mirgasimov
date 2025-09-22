using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace prakt1
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> Products { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Products = new ObservableCollection<Product>
            {
                new Product("Хлеб", 30, 20, ProductCategory.Food),
                new Product("Телефон", 20000, 5, ProductCategory.Electronics),
                new Product("Футболка", 1200, 10, ProductCategory.Clothes),
                new Product("Сыр", 400, 8, ProductCategory.Food),
                new Product("Наушники", 3000, 3, ProductCategory.Electronics)
            };
            ProductsGrid.ItemsSource = Products;
        }
        private void AddProduct_Click(object sender, RoutedEventArgs e)
        {
            Products.Add(new Product("Новый товар", 100, 1, ProductCategory.Clothes));
        }

        private void DeleteProduct_Click(object sender, RoutedEventArgs e)
        {
            if (ProductsGrid.SelectedItem is Product product)
                Products.Remove(product);
        }
        private void SellProduct_Click(object sender, RoutedEventArgs e)
        {
            if (ProductsGrid.SelectedItem is Product product)
            {
                try
                {
                    product.Sell(1);
                    ProductsGrid.Items.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

    }
}
