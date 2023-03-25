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

namespace Finaly_project
{
    /// <summary>
    /// Логика взаимодействия для Harry_Potter.xaml
    /// </summary>
    public partial class Harry_Potter : Window
    {
        public Harry_Potter()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            StreamReader pt = new StreamReader("Harry_Potter.txt");
            this.TexBoxPotter.Text = pt.ReadToEnd();
            pt.Close();
        }

        private void Back_Petterbtn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Book_Read Read = new Book_Read();  
            Read.Show();   
        
        }
    }
}
