using System;

using System.Windows;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace HCI_Projekat
{

    /// <summary>
    /// Interaction logic for AdminHome.xaml
    /// </summary>
    public partial class AdminOrginizerEdit : Window
    {
        Account selected;

        public AdminOrginizerEdit(Account selected)
        {

            InitializeComponent();

            this.selected = selected;

            textBox_name.Text = selected.Name;
            textBox_email.Text = selected.Email;
            textBox_password.Text = selected.Password;
            textBox_phone.Text = selected.Phone;

        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            if (textBox_name.Text == "" || textBox_email.Text == "" || textBox_phone.Text == "" || textBox_password.Text == "")
            {
                // los unos
            }
            else
            {
                AppManager.editAccount(new Account(Role.ORGANIZER, textBox_name.Text, textBox_email.Text, textBox_phone.Text, textBox_password.Text));
                this.Close();
            }
        }
    }
}
