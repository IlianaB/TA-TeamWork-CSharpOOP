using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for UserPanel.xaml
    /// </summary>
    public partial class UserPanel : Window
    {
        public UserPanel()
        {
            InitializeComponent();
        }
        private void OnUserPanel_Loaded(object sender, RoutedEventArgs e)
        {
            ICollectionView books = CollectionViewSource.GetDefaultView(new myView().Books);
            ICollectionView users = CollectionViewSource.GetDefaultView(new myView().Users);
            //ICollectionView books = CollectionViewSource.GetDefaultView(new myView().Users);
            DataContext = books;
        }



    }

    //Delta testing stuff below this line
    public class User
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public string Phone { get; set; }
        public User(string n, string a, string phone)
        {
            this.Name = n;
            this.Phone = phone;
            this.Age = a;
        }
    }
    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Phone { get; set; }
        public Book(string n, string a, string phone)
        {
            this.Name = n;
            this.Phone = phone;
            this.Author = a;
        }
    }
    public class myView : List<Object>
    {
        public List<User> Users
        {
            get
            {
                return new List<User>
                {
                    new User("Ivan","15","0878"),
                    new User("petyr","23","08748"),
                    new User("ilia","36","0826878"),
                    new User("ahmed","12","35223")
                };
            }
        }
        public List<Book> Books
        {
            get
            {
                return new List<Book>
                {
                    new Book("Book1","Author6781","wtfis that aaaa"),
                    new Book("Book21","Author111","wtfis that aaaa"),
                    new Book("Book231","Author51","wtfis that aaaa"),
                    new Book("Book11","Author21","wtfis that aaaa"),
                };
            }
        }
    }
}
