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

namespace tuan10
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
        private void Window_loaded_event(object sender, RoutedEventArgs e)
        {
            TextBlock text = new TextBlock();
            text.Text = "Phiên bản Demo, phục vụ lớp thực hành";
            MessageBox.Show("QLSV\nVersion 1.0.0.0\nCopyright @ 2008 - Nguyễn Hà Giang\n Phiên bản Demo, phục vụ lớp thực hành", "About QLSV", MessageBoxButton.OK, MessageBoxImage.Asterisk);
        }
    }
}
