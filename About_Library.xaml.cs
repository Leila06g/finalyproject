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
public partial class About_Library : Window
{
    public About_Library()
    {
        InitializeComponent();
    }

    private void Back_Aboutbtn_Click(object sender, RoutedEventArgs e)
    {
        this.Hide();
        Panel p1 = new Panel();
        p1.Show();
    }

    private void TexBoxAbout_TextChanged(object sender, TextChangedEventArgs e)
    {
        StreamReader ab = new StreamReader("About_Library.txt");
        this.TexBoxAbout.Text = ab.ReadToEnd();
        ab.Close();
    }
}
