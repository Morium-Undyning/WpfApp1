using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string hi = "Hi!";
        }

        private void b_Click(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToDouble(t1.Text);
            double b = Convert.ToDouble(t2.Text);
            double c = a* b;
            l3.Content = c;
            double A = Convert.ToDouble(t1.Text);
            double B = Convert.ToDouble(t2.Text);
            double C = A + B;
            l1.Content = C;
            double F = Convert.ToDouble(t1.Text);
            double G = Convert.ToDouble(t2.Text);
            double H = F - G;
            l2.Content = H;
        }
    }
}
