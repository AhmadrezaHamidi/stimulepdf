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
        protected TbBook _shelve;
        public Book(string Username)
        {
            _myDb = new MyDbContext();
            _myDb.users.Where(x => x.UserName == Username).FirstOrDefault();
            InitializeComponent();
            txtid.Text = _shelve.ID.ToString();
            txtittel.Text = _shelve.Title;
            txtName.Text = _shelve.Name;
            txtPublisher.Text = _shelve.Publisher;
            txtseroyal.Text = _shelve.seriyal.ToString();
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
            var Ourbook = _myDb.Bookes.Where(x => x.ID == _shelve.ID).FirstOrDefault();
            Ourbook.Name = txtName.Text;
            Ourbook.Publisher = txtPublisher.Text;
            Ourbook.seriyal = long.Parse(txtseroyal.Text);
            Ourbook.Title = txtittel.Text;
            _myDb.Bookes.Update(Ourbook);
            _myDb.SaveChanges();
            MyLabel.Content = "Updated !";

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _shelve = e.AddedItems[0] as TbBook;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var Ourbook = _myDb.Bookes.Where(x => x.ID == _shelve.ID).FirstOrDefault();
            _myDb.Bookes.Remove(Ourbook);
            _myDb.SaveChanges();
            MyLabel.Content = "the book is deleted   ";

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var OurBook = _myDb.Bookes.Where(z => z.ID == _shelve.ID).FirstOrDefault();
            TbBook book = new TbBook
            {
                ID = OurBook.ID,
                Name = OurBook.Name,
                Title = OurBook.Title,
                Publisher = OurBook.Publisher
            };
            datagrid.ItemsSource = (System.Collections.IEnumerable)book;
        }
    }
}
