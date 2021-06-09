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
    public partial class OrganizerHome : Window
    {
        public OrganizerHome()
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

        private void button_Copy2_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            OrganizerInfo form3 = new OrganizerInfo();
            form3.Left = this.Left + (this.Width - form3.Width) / 2;
            form3.Top = this.Top + (this.Height - form3.Height) / 2;
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void button_Copy3_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            OrganizerEvents form3 = new OrganizerEvents();
            form3.Left = this.Left + (this.Width - form3.Width) / 2;
            form3.Top = this.Top + (this.Height - form3.Height) / 2;
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }
    }
}
