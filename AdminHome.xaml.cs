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

namespace HCI_Projekat
{
    /// <summary>
    /// Interaction logic for AdminHome.xaml
    /// </summary>
    public partial class AdminHome : Window
    {
        public AdminHome()
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

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            login form3 = new login();
            form3.Left = this.Left + (this.Width - form3.Width) / 2;
            form3.Top = this.Top + (this.Height - form3.Height) / 2;
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void Users_MouseDown(object sender, MouseEventArgs e)
        {
            this.Hide();
            AdminUsers form = new AdminUsers();
            form.Left = this.Left + (this.Width - form.Width) / 2;
            form.Top = this.Top + (this.Height - form.Height) / 2;
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void Events_MouseDown(object sender, MouseEventArgs e)
        {
            this.Hide();
            AdminEvents form = new AdminEvents();
            form.Left = this.Left + (this.Width - form.Width) / 2;
            form.Top = this.Top + (this.Height - form.Height) / 2;
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
        private void Associates_MouseDown(object sender, MouseEventArgs e)
        {
            this.Hide();
            AdminAssociate form = new AdminAssociate();
            form.Left = this.Left + (this.Width - form.Width) / 2;
            form.Top = this.Top + (this.Height - form.Height) / 2;
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
        private void Organizers_MouseDown(object sender, MouseEventArgs e)
        {
            this.Hide();
            AdminOrganizers form = new AdminOrganizers();
            form.Left = this.Left + (this.Width - form.Width) / 2;
            form.Top = this.Top + (this.Height - form.Height) / 2;
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
