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

namespace WhiteBoading.Collections
{
    /// <summary>
    /// Interaction logic for Fibonacci.xaml
    /// </summary>
    public partial class Fibonacci : Window
    {
        public Fibonacci()
        {
            InitializeComponent();
            WindowPositioner.CenterWindowOnScreen(this);
        }

        private void ShowAnswerButton_Click(object sender, RoutedEventArgs e)
        {
            FibonacciAnswer answer = new FibonacciAnswer();
            answer.ShowDialog();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void NextProblemButton_Click(object sender, RoutedEventArgs e)
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            Close();
            fizzBuzz.ShowDialog();
        }
    }
}
