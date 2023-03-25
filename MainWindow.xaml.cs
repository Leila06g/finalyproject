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
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using System.Runtime.InteropServices;

namespace Finaly_project;

public partial class MainWindow : Window
{
    
    public MainWindow()
    {
        InitializeComponent();
    }

    private void btnprv_Click(object sender, RoutedEventArgs e)
    {
        WindowState = WindowState.Minimized;
    }

    private void btn_close_Click(object sender, RoutedEventArgs e)
    {
        Application.Current.Shutdown();
    }

    private void btnRegister_Click(object sender, RoutedEventArgs e)
    {
        this.Hide();
        Register register = new Register();
        register.Show();
    }

    private void btnLogin_Click(object sender, RoutedEventArgs e)
    {
        var json2 = File.ReadAllText("user.txt");
        var user2 = JsonSerializer.Deserialize<List<User>>(json2);

        foreach (User item in user2)
        {

            if (this.TextBoxUsername.Text == item.Username && this.password_box.Password== item.Password)
            {
                this.Hide();
                Panel panel = new Panel();
                panel.Show();

            }
            else
            {  
                MessageBox.Show("Error this Username and Password don't have please Registration!", "Error",
                MessageBoxButton.OK, MessageBoxImage.Error);

            }
        }
          
        }


    } 
            
           
       


