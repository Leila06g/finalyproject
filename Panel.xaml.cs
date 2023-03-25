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
using System.Windows.Shapes;

namespace Finaly_project;

public partial class Panel : Window
{
    public Panel()
    {
        InitializeComponent();
    }

    private void MenuItem_Click(object sender, RoutedEventArgs e)
    {
        this.Hide();
        Add_Book add_book = new Add_Book(new List<Book>());
        add_book.Show();
    }

    private void MenuItem_Click_1(object sender, RoutedEventArgs e)
    {
        this.Hide();
        Book_Read read_book = new Book_Read();
        read_book.Show();
    }

    private void MenuItem_Click_2(object sender, RoutedEventArgs e)
    {
        Application.Current.Shutdown();
    }

    private void MenuItem_Click_3(object sender, RoutedEventArgs e)
    {
        this.Hide();
        Search_Book search_Book = new Search_Book();
        search_Book.Show();
    }

    private void MenuItem_Click_4(object sender, RoutedEventArgs e)
    {
        this.Hide();
        About_Library about = new About_Library();
        about.Show();


    }
}

