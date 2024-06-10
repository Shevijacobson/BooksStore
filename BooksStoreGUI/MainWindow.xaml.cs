using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BooksStoreGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BooksStoreBL.BookStoreBL booksStoreBL;
        public MainWindow()
        {
            booksStoreBL = new BooksStoreBL.BookStoreBL();

            InitializeComponent();

            var res = booksStoreBL.GetAllBooks();
            //1
            //var res = booksStoreBL.GetAllBooks().Where(book=>book.Price>30);

            //2
            // var res = booksStoreBL.GetAllBooks().OrderBy(book => book.Id);

            //3
            //var res = from book in booksStoreBL.GetAllBooks()
            //          where book.IsComics
            //        select book.Price;

            //4
           // var res = booksStoreBL.GetAllBooks().Where(book => book.MinAge <= 9 && book.MaxAge>=9).Select(book=>book.Name);

            BooksDataGrid.ItemsSource = res;

        }
    }
}
