using System;
using System.Collections.Generic;
using System.IO;
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

public partial class Petter_Pan : Window
{
    public Petter_Pan()
    {
        InitializeComponent();
    }

    private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
    {
        StreamReader sr = new StreamReader("Petter_Pan.txt");
        this.TexBoxPetter.Text = sr.ReadToEnd();
        sr.Close();
    }

    private void Back_Petterbtn_Click(object sender, RoutedEventArgs e)
    {
        this.Hide();
        Book_Read book_Read = new Book_Read();
        book_Read.Show();
    }
}
