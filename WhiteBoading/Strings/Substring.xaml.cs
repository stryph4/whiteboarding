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

namespace WhiteBoading.Strings
{
    /// <summary>
    /// Interaction logic for Substring.xaml
    /// </summary>
    public partial class Substring : Window
    {

        public Substring()
        {
            InitializeComponent();
            WindowPositioner.CenterWindowOnScreen(this);
        }

        private void ShowAnswerButton_Click(object sender, RoutedEventArgs e)
        {
            SubstringAnswer answer = new SubstringAnswer();
            answer.ShowDialog();
        }

        private void NextProblemButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
