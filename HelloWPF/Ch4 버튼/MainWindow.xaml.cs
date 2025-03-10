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

namespace Ch4_버튼
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

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            txtb.Text = "버튼을 클릭했습니다.";
        }

        private void btn_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            txtb.Background = Brushes.Salmon;
            txtb.Foreground = Brushes.White;
        }

        private void btn_MouseEnter(object sender, MouseEventArgs e)
        {
            btn.Foreground = Brushes.Red;
        }

        private void btn_MouseLeave(object sender, MouseEventArgs e)
        {
            btn.Foreground = Brushes.Black;
        }
    }
}
