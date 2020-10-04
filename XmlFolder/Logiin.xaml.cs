using System;
using System.Collections.Generic;
using System.Security.Cryptography.Xml;
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
using System.Linq;

namespace VstaabnerWpf.XmlFolder
{
    /// <summary>
    /// Interaction logic for Logiin.xaml
    /// </summary>
    public partial class Logiin : Window
    {
        private readonly MyDbContext _myDb;
        protected string _Username;
        protected string _Password;
        public Logiin()
        {
            _myDb = new MyDbContext();
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string UserName = ((TextBox)sender).Text;
            _Username = UserName;
        }

        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            string paswordtexrt = ((TextBox)sender).Text;
            _Password = Convert.ToBase64String(Encoding.UTF8.GetBytes(paswordtexrt));
        ////    var UserFound = _myDb.Users.Where(x => x.UserName == _Username).FirstOrDefault();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var FoundUser = _myDb.Users.Where(x => x.UserName == _Username).FirstOrDefault();
            if (FoundUser.UserName==null)
            {
                Passwordcontoller.Content = "this user is not exist";
            }
            else
            {
                if (FoundUser.PasswordHash==_Password)
                {
                    var PaygeOfical = new BookAndShlve(_Username);
                    PaygeOfical.Show();
                }
                else
                {
                   Passwordcontoller.Content = "the pasword is not correct";
                }
            }
            
        }
    }
}
