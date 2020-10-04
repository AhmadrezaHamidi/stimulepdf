using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using VstaabnerWpf.Infra;
using VstaabnerWpf.XmlFolder;

namespace VstaabnerWpf
{
    /// <summary>
    /// Interaction logic for Test.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly MyDbContext myDb;

        public MainWindow()
        {
            InitializeComponent();
             myDb = new MyDbContext();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var Logn = new Logiin();
            Logn.Show();
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var uri = new Registr();
            uri.Show();
            Close();
        }
    }
}
