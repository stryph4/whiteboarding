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

namespace WhiteBoading.LoopsAndArrays
{
    /// <summary>
    /// Interaction logic for ReverseArray.xaml
    /// </summary>
    public partial class ReverseArray : Window
    {
        public ReverseArray()
        {
            InitializeComponent();
            WindowPositioner.CenterWindowOnScreen(this);
        }

        private void ShowAnswerButton_Click(object sender, RoutedEventArgs e)
        {
            ReverseArrayAnswer answer = new ReverseArrayAnswer();
            answer.ShowDialog();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
