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

namespace HCI_Projekat
{
    public partial class login : Window
    {
        public login()
        {
            InitializeComponent();
        }

        private void Login()
        {
            String email = textBox_ime.Text;
            String sifra = textBox_sifra.Text;

            AppManager.loadAccounts();

            Account tmp = AppManager.findAccount(email);

            if (tmp == null)
            {
                // acc ne postoji
            }

            else if (tmp.password == sifra)
            {
                switch (tmp.role)
                {
                    case Role.CLIENT:
                        this.Hide();
                        client_main form = new client_main();
                        form.Closed += (s, args) => this.Close();
                        form.Show();
                        break;
                    case Role.ORGANIZER:
                        break;
                    case Role.ADMIN:
                        break;
                }
            }
            else
            {
                // pogresna sifra
            }
        }

        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Login();
            }
        }

        private void login_button_Click(object sender, RoutedEventArgs e)
        {
            Login();
        }

        private void textBox_ime_GotFocus(object sender, RoutedEventArgs e)
        {
            if (textBox_ime.Text == "GMAIL")
            {
                textBox_ime.Text = "";
            } 
        }

        private void textBox_ime_LostFocus(object sender, RoutedEventArgs e)
        {
            if (textBox_ime.Text == "")
            {
                textBox_ime.Text = "GMAIL";
            }
        }

        private void textBox_sifra_GotFocus(object sender, RoutedEventArgs e)
        {
            if (textBox_sifra.Text == "PASSWORD")
            {
                textBox_sifra.Text = "";
            }
        }

        private void textBox_sifra_LostFocus(object sender, RoutedEventArgs e)
        {
            if (textBox_sifra.Text == "")
            {
                textBox_sifra.Text = "PASSWORD";
            }
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
    }
}
