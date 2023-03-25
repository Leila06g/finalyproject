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

public partial class Register : Window
{
  public  List<User> Users = new List<User>();
    public Register()
    {
        InitializeComponent();
       
    }
    private void btnclear_Click(object sender, RoutedEventArgs e)
    {
        TextBoxUsername.Text = " ";
        TextBoxPassword.Text = " ";
        TextBoxUsername.Focus();
    }

    private void btncBackTOLogin_Click(object sender, RoutedEventArgs e)
    {
        this.Hide();
        MainWindow main = new MainWindow();
        main.Show();
    }

    private void btnRegister_Click(object sender, RoutedEventArgs e)
    {

        if (TextBoxUsername.Text == "" && TextBoxPassword.Text == "")
        {
            MessageBox.Show("Username and Password fields are empty!", "Faild Register", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        else
        {

            var user = new List<User>
            {
                new User(){
                Username = this.TextBoxUsername.Text,
                Password = this.TextBoxPassword.Text,
                }
            };

           
            
            var json = JsonSerializer.Serialize(user);
            File.WriteAllText("user.txt", json);

            MessageBox.Show("Succsses Register!", "Succsses", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            
          

        }
    }


