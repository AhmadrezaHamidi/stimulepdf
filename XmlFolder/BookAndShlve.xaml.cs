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

namespace VstaabnerWpf.XmlFolder
{
    /// <summary>
    /// Interaction logic for BookAndShelve.xaml
    /// </summary>
    public partial class BookAndShlve : Window
    {
        private readonly MyDbContext _myDb;
        protected string _username;
        public BookAndShlve(string username)
        {
            _myDb = new MyDbContext();
            _username = username;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var userProfile = new UserProfile(_username);
            userProfile.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var showSheve = new ShelvesContoller(_username);
            showSheve.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var ShowBook = new Book(_username);
            ShowBook.Show();
        }
    }
}
