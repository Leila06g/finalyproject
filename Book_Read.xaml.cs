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

public partial class Book_Read : Window
{
    public Book_Read()
    {
        InitializeComponent();
    }

    private void Petter_Pan_Click(object sender, RoutedEventArgs e)
    {
        this.Hide();
        Petter_Pan petter = new Petter_Pan();
        petter.Show();

    }

    private void Harry_Potter_Click(object sender, RoutedEventArgs e)
    {
        this.Hide();
        Harry_Potter potter = new Harry_Potter();
        potter.Show();
    }

    private void Back_Petterbtn_Click(object sender, RoutedEventArgs e)
    {
        this.Hide();
        Panel panel = new Panel();
        panel.Show();
    }
}
