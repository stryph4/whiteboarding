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

namespace WhiteBoading.Classes
{
    /// <summary>
    /// Interaction logic for HappyBirthday.xaml
    /// </summary>
    public partial class HappyBirthday : Window
    {
        public HappyBirthday()
        {
            InitializeComponent();
            WindowPositioner.CenterWindowOnScreen(this);
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ShowAnswerButton_Click(object sender, RoutedEventArgs e)
        {
            HappyBirthdayAnswer answer = new HappyBirthdayAnswer();
            answer.ShowDialog();
        }
    }
}
