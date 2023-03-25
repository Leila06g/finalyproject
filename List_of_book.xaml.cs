using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
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

namespace Finaly_project;
public partial class Search_Book : Window
{
    public Search_Book()
    {
        InitializeComponent();
    }

    private void Back_Searchbtn_Click(object sender, RoutedEventArgs e)
    {
        this.Hide();
        Panel p = new Panel();
        p.Show();
    }

    private void TexBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
    {
        var jso = File.ReadAllText("book.txt");
        var book3 = JsonSerializer.Deserialize<List<Book>>(jso);

        TexBoxSearch.Text = jso;

    }


}

