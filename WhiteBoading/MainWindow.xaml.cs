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
using WhiteBoading.LoopsAndArrays;
using WhiteBoading.Strings;

namespace WhiteBoading
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowPositioner.CenterWindowOnScreen(this);
        }

        private void LoopsAndArraysButton_Click(object sender, RoutedEventArgs e)
        {
            CountEvens countEvens = new CountEvens();
            countEvens.ShowDialog();
        }

        private void Strings_Click(object sender, RoutedEventArgs e)
        {
            Substring substring = new Substring();
            substring.ShowDialog();
        }
    }
}
