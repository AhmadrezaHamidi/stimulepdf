using Microsoft.EntityFrameworkCore.Diagnostics;
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
using VstaabnerWpf.Model;

namespace VstaabnerWpf.XmlFolder
{
    /// <summary>
    /// Interaction logic for Registr.xaml
    /// </summary>
    public partial class Registr : Window
    {
        private readonly MyDbContext _myDb;
        protected string _Username;
        protected string _EmalAddress;
        protected string _phoneNumber;
        protected DateTime _DateOfBirthday;
        protected string _Password;
        protected bool _ResultBool;
        public Registr()
        {
            _myDb = new MyDbContext();
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
       {
            string UserName = ((TextBox)sender).Text;
            if (UserName == null)
            {
                UsernameCotoller.Content = "This empty";
            }
            else
            {
                _Username = UserName;
            }
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            string Sencder = ((TextBox)sender).Text;
            if (Sencder.Contains('@'))
            {
                _EmalAddress = Sencder; _phoneNumber = "";
            }
            else if (_ResultBool)
            {
                _phoneNumber = Sencder;
                _EmalAddress = "";
            }
            else
            {
                if (emailcontoller != null)
                {
                    emailcontoller.Content= "This is not email or Phone Number";
                }
            }
        }
        public bool FucTionNUmber(string input)
        {
            int Num = 0;
            bool resultr;
            foreach (var item in input)
            {
                if (char.IsDigit(item))
                {
                    Num++;
                }
            }
            if (Num > 0)
            {
                resultr = true;
            }
            else
            {
                resultr = false;
            }
            _ResultBool = resultr;
            return resultr;
        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {
            string Sencder = ((TextBox)sender).Text;


            if (Sencder == null)
            {
                if (dateBirContoller != null)
                    dateBirContoller.Content = "dataTime is emty";
            }
            else if (!_ResultBool)
            {
                if (dateBirContoller != null)
                    dateBirContoller.Content = "This is not date time ";
            }
            else
            {
                _DateOfBirthday = Convert.ToDateTime(Sencder);
            }
            /////  Convert.FromBase64String
        }

        private void TextBox_TextChanged_3(object sender, TextChangedEventArgs e)
        {
            string Sencder = ((TextBox)sender).Text;
            if (Sencder.Length < 8)
            {
                if (everythingContoller != null)
                    everythingContoller.Content = "the lenght of password is not enough";
            }
            else
            {
                _Password = Sencder;
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            TbUser user = new TbUser()
            {
                UserName = _Username,
                PhoneNumber = _phoneNumber,
                Email = _EmalAddress,
                Birthday = _DateOfBirthday,
                PasswordHash =Convert.ToBase64String(Encoding.UTF8.GetBytes(_Password))
                ///Convert.ToBase64String(Encoding.UTF8.GetBytes(_Password))

            };
            var resultName = _myDb.users.Find(_Username);
            if (resultName == null)
            {
                _myDb.users.Add(user);
                _myDb.SaveChanges();
                if (everythingContoller != null)
                    everythingContoller.Content = "Register is Okey!";
                var Login = new Logiin();
                Login.Show();
                Close();
            }
            else
            {
                if (everythingContoller != null)
                    everythingContoller.Content = "This user is exist later chang youre UserName";
            }
        }
    }
}
