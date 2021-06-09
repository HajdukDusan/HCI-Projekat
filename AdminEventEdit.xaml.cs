using System;

using System.Windows;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace HCI_Projekat
{

    /// <summary>
    /// Interaction logic for AdminHome.xaml
    /// </summary>
    public partial class AdminEventEdit : Window
    {
        Event selected;
        int index;
        public AdminEventEdit(Event selected, int index)
        {

            InitializeComponent();
            this.selected = selected;
            this.index = index;

            textBox_name.Text = selected.Name;
            textBox_budget.Text = selected.Budget;
            textBox_location.Text = selected.Location;
            textBox_theme.Text = selected.Theme;
            DatePicker.SelectedDate = DateTime.Parse(selected.Date);
            textBox_guestCnt.Text = selected.GuestCount.ToString();
            textBox_avgAge.Text = selected.AverageAge.ToString();

            foreach (Account a in AppManager.getOrganizers())
            {
                comboBox_organizer.Items.Add(a.Name);
                if(a.Email == selected._organizer.Email)
                {
                    comboBox_organizer.SelectedItem = a.Name;
                }
            }

            foreach (Account a in AppManager.getClients())
            {
                comboBox_user.Items.Add(a.Name);
                if (a.Email == selected._client.Email)
                {
                    comboBox_user.SelectedItem = a.Name;
                }
            }

            foreach (var item in Enum.GetValues(typeof(EventType)))
            {
                comboBox_type.Items.Add(item.ToString());
                if (item.ToString().ToUpper() == selected.Type.ToString().ToUpper())
                {
                    comboBox_type.SelectedItem = item.ToString();
                }
            }

            foreach (var item in Enum.GetValues(typeof(Color)))
            {
                comboBox_color.Items.Add(item.ToString());
                if (item.ToString().ToUpper() == selected.Color.ToString().ToUpper())
                {
                    comboBox_color.SelectedItem = item.ToString();
                }
            }
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
            if (textBox_name.Text == "" || comboBox_organizer.SelectedItem == null || comboBox_type.SelectedItem == null || textBox_budget.Text == ""
                || textBox_location.Text == "" || textBox_theme.Text == "" || DatePicker.SelectedDate == null || comboBox_color.SelectedItem == null
                || textBox_guestCnt.Text == "" || textBox_avgAge.Text == "" || comboBox_user.SelectedItem == null)
            {
                // los unos
            }
            else
            {

                Account o = null;
                Account c = null;

                foreach (Account a in AppManager.Accounts)
                {
                    if(a.Name == comboBox_organizer.SelectedItem.ToString())
                    {
                        o = a;
                    }
                    if (a.Name == comboBox_user.SelectedItem.ToString())
                    {
                        c = a;
                    }
                }

                AppManager.editEvent(new Event(textBox_name.Text, o, (EventType)Enum.Parse(typeof(EventType), comboBox_type.SelectedItem.ToString()),
                                              textBox_budget.Text, textBox_location.Text, textBox_theme.Text, DatePicker.SelectedDate.ToString(), (Color)Enum.Parse(typeof(Color), comboBox_color.SelectedItem.ToString()),
                                              Int32.Parse(textBox_guestCnt.Text), Int32.Parse(textBox_avgAge.Text), c), index);
                this.Close();
            }
        }
    }
}
