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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ch24_컨텍스트메뉴
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            tb.FontWeight = FontWeights.Bold;
        }

        private void MenuItem_Checked(object sender, RoutedEventArgs e)
        {
            tb.FontStyle = FontStyles.Italic;
        }

        private void MenuItem_Unchecked(object sender, RoutedEventArgs e)
        {
            tb.FontStyle = FontStyles.Normal;
        }
    }
}
