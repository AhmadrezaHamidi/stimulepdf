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
using VstaabnerWpf.Model;

namespace VstaabnerWpf.XmlFolder
{
    /// <summary>
    /// Interaction logic for Book.xaml
    /// </summary>
    public partial class Book : Window
    {
        private readonly MyDbContext _myDb;
        protected string _Username;
        public Book(string Username)
        {
            _myDb = new MyDbContext();
            _myDb.users.Where(x => x.UserName == Username).FirstOrDefault();
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
             TbBook book = new TbBook
             {
                Name = txtName.Text,
                Publisher=txtPublisher.Text,
                seriyal=long.Parse(txtseroyal.Text),
                Title=txtittel.Text,
            };
            var res = _myDb.Bookes.Any(c => c.ID == book.ID);
            if (res)
            {
                MyLabel.Content = "this book is exist";
            }
            else
            {
                _myDb.Bookes.Add(book);
                _myDb.SaveChanges();
                MyLabel.Content = "this book is Add ";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
          //  var FoundBook=_myDb.Bookes.Where(x=>x.ID ==txtid)
        }
    }
}
