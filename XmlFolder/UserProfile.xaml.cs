using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Interaction logic for UserProfile.xaml
    /// </summary>
    public partial class UserProfile : Window
    {
        private readonly MyDbContext _myDb;
        protected string _userName;
        public UserProfile(string username)
        {
            _myDb = new MyDbContext();
             _userName = username ;
            InitializeComponent();
            var founduser = _myDb.Users.Where(x => x.UserName == _userName).FirstOrDefault();
            userametxt.Text = founduser.UserName;
            emailtxt.Text = founduser.Email;
            datetxt.Text = founduser.Birthday.ToString();
            var pass = Convert.FromBase64String(founduser.PasswordHash);
            var passText = System.Text.Encoding.UTF8.GetString(pass);
            paswordtxt.Text = passText;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var founduser = _myDb.Users.Where(x => x.UserName == _userName).FirstOrDefault();
            founduser.UserName = userametxt.Text;
            founduser.Email = emailtxt.Text;
            founduser.Birthday =Convert.ToDateTime(datetxt.Text);
            founduser.PasswordHash = Convert.ToBase64String(Encoding.UTF8.GetBytes(paswordtxt.Text));
            _myDb.Update(founduser);
            _myDb.SaveChanges();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var founduser = _myDb.Users.Where(x => x.UserName == _userName).FirstOrDefault();
            _myDb.Remove(founduser);
            _myDb.SaveChanges();
        }
    }
}
