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
    /// Interaction logic for Absolutes.xaml
    /// </summary>
    public partial class Absolutes : Window
    {
        public Absolutes()
        {
            InitializeComponent();
            WindowPositioner.CenterWindowOnScreen(this);
        }

        private void ShowAnswerButton_Click(object sender, RoutedEventArgs e)
        {
            AbsolutesAnswer answer = new AbsolutesAnswer();
            answer.ShowDialog();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
