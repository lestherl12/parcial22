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

namespace calculadoraparcial
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

        private void suma_Click(object sender, RoutedEventArgs e)
        {
            resultado.Text = (Convert.ToInt64(num1.Text) + Convert.ToInt64(num2.Text)).ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            resultado.Text = (Convert.ToInt64(num1.Text) - Convert.ToInt64(num2.Text)).ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            resultado.Text = (Convert.ToInt64(num1.Text) * Convert.ToInt64(num2.Text)).ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            resultado.Text = (Convert.ToInt64(num1.Text) / Convert.ToInt64(num2.Text)).ToString();
        }
    }
}
