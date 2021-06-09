using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public partial class OrganizerEventOpen : Window
    {

        public OrganizerEventOpen()
        {
            InitializeComponent();

            name.Content = AppManager.SelectedEvent.Name;
            type.Content = AppManager.SelectedEvent.Type.ToString();
            date.Content = AppManager.SelectedEvent.Date;
            budget.Content = AppManager.SelectedEvent.Budget;
            location.Content = AppManager.SelectedEvent.Location;
            theme.Content = AppManager.SelectedEvent.Theme;
            color.Content = AppManager.SelectedEvent.Color.ToString();
            numberOfGuests.Content = AppManager.SelectedEvent.GuestCount.ToString();
            avgAge.Content = AppManager.SelectedEvent.AverageAge.ToString();
            clientName.Content = AppManager.SelectedEvent._client.Name;
            additionalInfo.Text = AppManager.SelectedEvent.Theme;
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
            OrganizerManageAssociate form2 = new OrganizerManageAssociate();
            form2.Left = this.Left + (this.Width - form2.Width) / 2;
            form2.Top = this.Top + (this.Height - form2.Height) / 2;
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            OrganizerEvents form2 = new OrganizerEvents();
            form2.Left = this.Left + (this.Width - form2.Width) / 2;
            form2.Top = this.Top + (this.Height - form2.Height) / 2;
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void button_Copy2_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            OrganizerManageSuggestions form2 = new OrganizerManageSuggestions();
            form2.Left = this.Left + (this.Width - form2.Width) / 2;
            form2.Top = this.Top + (this.Height - form2.Height) / 2;
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
