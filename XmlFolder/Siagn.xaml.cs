using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
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
using VstaabnerWpf.Model;
using Microsoft.AspNet.Identity.EntityFramework;

namespace VstaabnerWpf.XmlFolder
{
    /// <summary>
    /// Interaction logic for singln.xaml
    /// </summary>
    public partial class Siagn : Window
    {
        private readonly MyDbContext _myDb;
        protected string _Username;
        protected string _EmalAddress ;
        protected string _phoneNumber ;
        protected DateTime _DateOfBirthday ;
        protected string _Password;
        protected bool _ResultBool;



        public Siagn()
        {
             _myDb = new MyDbContext();
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string UserName= ((TextBox)sender).Text;
            if (UserName == null)
            {
               var UserNameContoller = new Label();
               if(UserNameContoller != null)
                    UserNameContoller.Content = "userName is empty";
            }
            else
            {
                _Username = UserName;
            }
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
           
            string Sencder = ((TextBox)sender).Text;
            var fuc =FucTionNUmber(Sencder);

            if (Sencder.Contains('@'))
            {
                _EmalAddress = Sencder;
                _phoneNumber = "";
                
            }
            else if (_ResultBool)
            {
                _phoneNumber= Sencder;
                _EmalAddress = "";
            }
            else
            {
               if(PhoneOrEmailContoller != null)
                 PhoneOrEmailContoller.Content = "This is not email or Phone Number";
            }
            
        }

       

        private void TextBox_TnextChanged_2(object sender, TextChangedEventArgs e)
        {
            string Sencder = ((TextBox)sender).Text;
            if (Sencder.Length<8)
            {
               if(passwordcontoroller != null)
                    passwordcontoroller.Content="the lenght of password is not enough";
            }
            else
            {
                _Password = Sencder;
            }
        }

        private void TextBox_TextChanged_3(object sender, TextChangedEventArgs e)
        {
            string  Sencder = ((TextBox)sender).Text;
            

            if (Sencder == null)
            {
               if(dateOfBirthadcontoroller != null)
                    dateOfBirthadcontoroller.Content = "dataTime is emty";
            }
            else if (!_ResultBool)
            {
               if(dateOfBirthadcontoroller != null)
                    dateOfBirthadcontoroller.Content = "This is not date time ";
            }
            else
            {
                _DateOfBirthday =Convert.ToDateTime(Sencder);
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
                PasswordHash = Convert.ToBase64String( Encoding.UTF8.GetBytes(_Password) )

            };
          /////  Convert.FromBase64String
            var resultName = _myDb.Users.Where(x=>x.UserName ==_Username).FirstOrDefault();
            if (resultName == null)
            {
                _myDb.users.Add(user);
                _myDb.SaveChanges();
               if(AllContller != null)
                    AllContller.Content = "Register is Okey!";
                var Login = new Logiin();
                Login.Show();
                Close();
            }
            else
            {
               if(AllContller != null)
                    AllContller.Content = "This user is exist later chang youre UserName";
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
            if (Num>0)
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
            if (Sencder.Length < 8)
            {
               if(passwordcontoroller != null)
                    passwordcontoroller.Content = "the lenght of password is not enough";
            }
            else
            {
                _Password = Sencder;
            }
        }
    }
  
}
