using System;

using System.Windows;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace HCI_Projekat
{

    /// <summary>
    /// Interaction logic for AdminHome.xaml
    /// </summary>
    public partial class AdminOrginizerAdd : Window
    {

        public AdminOrginizerAdd()
        {

            InitializeComponent();

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
                AppManager.addAccount(new Account(Role.ORGANIZER, textBox_name.Text, textBox_email.Text, textBox_phone.Text, textBox_password.Text));
                this.Close();
            }
        }
    }
}
