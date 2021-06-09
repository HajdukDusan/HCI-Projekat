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

            if (AppManager.Accounts.Count == 0)
                AppManager.LoadData();

            Account tmp = AppManager.findAccount(email);

            if (tmp == null)
            {
                // acc ne postoji
            }

            else if (tmp.Password == sifra)
            {
                switch (tmp.Role)
                {
                    case Role.CLIENT:
                        AppManager.SelectedAccount = tmp;
                        this.Hide();
                        ClientHome form = new ClientHome(tmp);
                        form.Left = this.Left + (this.Width - form.Width) / 2;
                        form.Top = this.Top + (this.Height - form.Height) / 2;
                        form.Closed += (s, args) => this.Close();
                        form.Show();
                        break;
                    case Role.ORGANIZER:
                        AppManager.SelectedAccount = tmp;
                        this.Hide();
                        OrganizerHome form2 = new OrganizerHome();
                        form2.Left = this.Left + (this.Width - form2.Width) / 2;
                        form2.Top = this.Top + (this.Height - form2.Height) / 2;
                        form2.Closed += (s, args) => this.Close();
                        form2.Show();
                        break;
                    case Role.ADMIN:
                        this.Hide();
                        AdminHome form3 = new AdminHome();
                        form3.Left = this.Left + (this.Width - form3.Width) / 2;
                        form3.Top = this.Top + (this.Height - form3.Height) / 2;
                        form3.Closed += (s, args) => this.Close();
                        form3.Show();
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

        private void login_button_Click_1(object sender, RoutedEventArgs e)
        {
            Login();
        }
    }
}
