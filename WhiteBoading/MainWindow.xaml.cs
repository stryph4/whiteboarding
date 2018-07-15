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
using WhiteBoading.Classes;
using WhiteBoading.Collections;
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

        private void Collections_Click(object sender, RoutedEventArgs e)
        {
            Fibonacci fibonacci = new Fibonacci();
            fibonacci.ShowDialog();
        }

        private void Classes_Click(object sender, RoutedEventArgs e)
        {
            Person person = new Person();
            person.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Program written by Nabiel El-Gendy \r\n \r\n" +
                "Special thanks to Tech Elevator for being awesome and giving me ideas for white boarding questions.");
        }
    }
}
