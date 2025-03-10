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

namespace ch21_statusbar
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

        private void sl_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (sl.Value == 100)
            {
                sb.Content = "완료";
            }
            else
            {
            pb.Value = sl.Value;
                sb.Content = "로딩중..";
            }
        }
    }
}
