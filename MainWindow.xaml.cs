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

namespace U5Printing
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
        public void Pricefinder(object Sender, RoutedEventArgs e)
        {
            double a;

            double.TryParse(copies.Text, out a);

            if (a <= 99)
            {
                MessageBox.Show("The total price is $" + a * 0.30);
            }
            else if (100 <= a && a <= 499)
            {
                MessageBox.Show("The total price is $" + a * 0.28);
            }
            else if (500 <= a && a <= 749)
            {
                MessageBox.Show("The total price is $" + a * 0.27);
            }
            else if (750 <= a && a <= 1000)
            {
                MessageBox.Show("The total price is $" + a * 0.26);
            }
            else
            {
                MessageBox.Show("The Total Price is $" + a * 0.25);
            }
        }
    }
}

