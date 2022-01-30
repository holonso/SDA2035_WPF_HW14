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

namespace SDA2035_WPF_HW14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                NameProduct = "Хлеб",
                CostProduct = 55,
                TypeProduct = IEnumTypeProduct.Food,
            });
            products.Add(new Product()
            {
                NameProduct = "Микроволновая печь",
                CostProduct = 4760,
                TypeProduct = IEnumTypeProduct.Tech,
            });
            products.Add(new Product()
            {
                NameProduct = "Молоко",
                CostProduct = 82,
                TypeProduct = IEnumTypeProduct.Food,
            });
            lst.ItemsSource = products;
        }
    }
}
