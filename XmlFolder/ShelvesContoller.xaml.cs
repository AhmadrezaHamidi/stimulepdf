using System;
using System.Collections.Generic;
using System.Linq;
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
using VstaabnerWpf.Model;

namespace VstaabnerWpf.XmlFolder
{
    /// <summary>
    /// Interaction logic for ShelvesContoller.xaml
    /// </summary>
    public partial class ShelvesContoller : Window
    {
        private readonly MyDbContext _myDb;
        protected string _username;
        protected TbUser user1;

        public ShelvesContoller(string username)
        {
            _myDb = new MyDbContext();
            _username = username;
            InitializeComponent();
            var user = _myDb.users.Where(x => x.UserName == _username).FirstOrDefault();
            user1 = user;
            var shelvs = _myDb.Shelves.Where(x => x.UserId == user.Id).ToList();
            /// var selectuser=shelvs.Where(x=>x.id == )
            showEvery.ItemsSource = shelvs;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Idtxt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            var item = e.AddedItems[0] as TbShelve;

            /// Idtxt.Text= 
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var shelve = new TbShelve()
            {

                Name = Nametxt.Text,
                Titele = Titletxt.Text,
                UserId = user1.Id,
                User = user1
            };

            if (_myDb.Shelves.Any(x => x.id == shelve.id))
            {
                labelshow.Content = "this shelve is exist later";
            }
            else
            {
                _myDb.Shelves.Add(shelve);
                _myDb.SaveChanges();

                labelshow.Content = "youre shelve is created !";
                var shelvs = _myDb.Shelves.Where(x => x.UserId == user1.Id).ToList();

                showEvery.ItemsSource = shelvs;
            }


        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var foundShelv = _myDb.Shelves.Where(x => x.Name == Nametxt.Text).FirstOrDefault();

            var Ourshele = new TbBookAndShelve
            {
                BookID = Convert.ToInt32(Idbook.Text),
                ShelveId = Convert.ToInt32(foundShelv.id)
            };
            var result = _myDb.BookAndShelvecs.Where(x => x.ShelveId == foundShelv.id && x.BookID == Convert.ToInt32(Idbook.Text)).FirstOrDefault();
            if (result == null)
            {
                _myDb.BookAndShelvecs.Add(Ourshele);
                _myDb.SaveChanges();
                labelshow.Content = "the book add in shelve  !";
            }
            else
            {
                labelshow.Content = "the book IS EXIST  in  THIS shelve  !";
            }

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var idbook = Convert.ToInt32(Idbook.Text);
            var idshlve = Convert.ToInt32(Idtxt.Text);
            /// var foundShelve = _myDb.BookAndShelvecs.Where(x => x.ShelveId == idshlve).FirstOrDefault();
            ///var FoudBookInshelve = foundShelve.Booke.ID.Equals(idlbook);
            var foundShelv = _myDb.Shelves.Where(x => x.id == idshlve).FirstOrDefault();
            var result = _myDb.BookAndShelvecs.Where(x => x.ShelveId == foundShelv.id && x.BookID == Convert.ToInt32(Idbook.Text)).FirstOrDefault();

            if (result == null)
            {
                labelshow.Content = "the book IS EXIST  in  THIS shelve  !";
            }
            else
            {

                _myDb.BookAndShelvecs.Remove(result);
                _myDb.SaveChanges();
                labelshow.Content = "the book removed  from  shelve  !";

            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            var idshlve = Convert.ToInt32(Idtxt.Text);

            var ExistShelve = _myDb.Shelves.Where(z => z.id == idshlve).FirstOrDefault();
            ///remove book from shelve 
            if (ExistShelve == null)
            {
                labelshow.Content = "This shelve is not exis ";
                //  return ;
            }

            else
            {


                _myDb.Remove(ExistShelve);
                _myDb.SaveChanges();
                labelshow.Content = "This shelve is rimoved ";
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            var allShelves = _myDb.Shelves.Select(x => new TbShelve
            {
                id = x.id,
                Name = x.Name,
                UserId = x.UserId,
                Titele = x.Titele


            }).ToList();
            _myDb.SaveChanges();
            labelshow.Content = "all shelve is deleted!";
        }
    }
}
