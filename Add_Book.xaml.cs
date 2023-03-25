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
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Finaly_project;

public partial class Add_Book : Window
{ 
    List<Book> Books = new List<Book>();
    public Add_Book(List<Book> Books)
    {
        InitializeComponent();
        this.Books = Books;
       
    }

    private void btnclear_all_Click(object sender, RoutedEventArgs e)
    {
        book_name.Text = " ";
        book_author.Text = " ";
        book_genre.Text = " ";
        book_language.Text = " ";
        book_count.Text = " ";
        book_name.Focus();
    }

    private void btncBackTOLibrary_Click(object sender, RoutedEventArgs e)
    {
        this.Hide();
        Panel panel = new Panel();
        panel.Show();
    }

    private void Add_book_Click(object sender, RoutedEventArgs e)
    {
       

        if(book_name.Text == "" && book_author.Text == "" && book_genre.Text == "" && book_language.Text == "" && book_count.Text == "")
        {
            MessageBox.Show("Book name,book author,book genre,book language,and book count fields are empty!", "Faild Added Book", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        else
        {
            var book1 = new Book()
            {
              
                   Name_book = book_name.Text,
                   Name_Author_Book = book_author.Text,
                   Book_Genre = book_genre.Text,
                   Book_Language = book_language.Text,
                   Book_Count = book_count.Text,
                
            };
            Books.Add(book1);
            var json_book = JsonSerializer.Serialize(Books);
            File.WriteAllText("book.txt", json_book);
            MessageBox.Show("Succsses Added Book!", "Succsses", MessageBoxButton.OK, MessageBoxImage.Information);

        }


    }
}

