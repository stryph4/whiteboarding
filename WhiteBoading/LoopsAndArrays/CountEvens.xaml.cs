﻿using System;
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
    /// Interaction logic for CountEvens.xaml
    /// </summary>
    public partial class CountEvens : Window
    {
        public CountEvens()
        {
            InitializeComponent();
            WindowPositioner.CenterWindowOnScreen(this);
        }

        private void ShowAnswerButton_Click(object sender, RoutedEventArgs e)
        {
            CountEvensAnswer answer = new CountEvensAnswer();
            answer.ShowDialog();
        }

        private void NextProblemButton_Click(object sender, RoutedEventArgs e)
        {
            FirstAndLast firstAndLast = new FirstAndLast();
            Close();
            firstAndLast.ShowDialog();

        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
