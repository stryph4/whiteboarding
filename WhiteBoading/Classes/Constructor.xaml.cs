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
    /// Interaction logic for Constructor.xaml
    /// </summary>
    public partial class Constructor : Window
    {
        public Constructor()
        {
            InitializeComponent();
            WindowPositioner.CenterWindowOnScreen(this);
        }

        private void NextProblemButton_Click(object sender, RoutedEventArgs e)
        {
            ChangeName changeName = new ChangeName();
            Close();
            changeName.ShowDialog();
        }

        private void ShowAnswerButton_Click(object sender, RoutedEventArgs e)
        {
            ConstructorAnswer answer = new ConstructorAnswer();
            answer.ShowDialog();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
