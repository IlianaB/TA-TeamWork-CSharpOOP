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
using Library;

namespace UserInterface
{
    /// <summary>
    /// Interaction logic for UserPanel.xaml
    /// </summary>
    public partial class UserPanel : Window
    {
        private ICollectionView books = CollectionViewSource.GetDefaultView(Library.Library.Instance.ReadableItems);
        private ICollectionView users = CollectionViewSource.GetDefaultView(Library.Library.Instance.Users);

        public UserPanel()
        {
            InitializeComponent();
            DataContext = books;
        }

        private void OnNext_Click(object sender, RoutedEventArgs e)
        {
            books.MoveCurrentToNext();
            if (books.IsCurrentAfterLast)
            {
                books.MoveCurrentToFirst();
            }
        }

        private void OnPrevious_Click(object sender, RoutedEventArgs e)
        {
            books.MoveCurrentToPrevious();
            if (books.IsCurrentBeforeFirst)
            {
                books.MoveCurrentToLast();
            }
        }

        private void OnLibraryTab_GotFocus(object sender, RoutedEventArgs e)
        {
            DataContext = books;
        }

        private void OnFriendsTab_GotFocus(object sender, RoutedEventArgs e)
        {
            DataContext = users;
        }

        private void OnSearch_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var collectionResult = Library.Library.Instance.search.SearchReadableItem(this.Search_Input.Text);

                DataContext = collectionResult;
            }
            catch (LibraryCommonException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
