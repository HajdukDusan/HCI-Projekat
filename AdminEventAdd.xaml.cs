using System;

using System.Windows;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace HCI_Projekat
{

    /// <summary>
    /// Interaction logic for AdminHome.xaml
    /// </summary>
    public partial class AdminEventAdd : Window
    {

        public AdminEventAdd()
        {

            InitializeComponent();

            foreach(Account a in AppManager.getOrganizers())
            {
                comboBox_organizer.Items.Add(a.Name);
            }

            foreach (Account a in AppManager.getClients())
            {
                comboBox_user.Items.Add(a.Name);
            }

            foreach (var item in Enum.GetValues(typeof(EventType)))
            {
                comboBox_type.Items.Add(item);
            }

            foreach (var item in Enum.GetValues(typeof(Color)))
            {
                comboBox_color.Items.Add(item);
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
                foreach (Account item in AppManager.Accounts)
                {
                    if (item.Name == comboBox_organizer.SelectedItem)
                    {
                        o = item;
                    }
                    if (item.Name == comboBox_user.SelectedItem)
                    {
                        c = item;
                    }
                }

                AppManager.addEvent(new Event(textBox_name.Text, o, (EventType)Enum.Parse(typeof(EventType), comboBox_type.SelectedItem.ToString()),
                                              textBox_budget.Text, textBox_location.Text, textBox_theme.Text, DatePicker.SelectedDate.ToString(), (Color)Enum.Parse(typeof(Color), comboBox_color.SelectedItem.ToString()),
                                              Int32.Parse(textBox_guestCnt.Text), Int32.Parse(textBox_avgAge.Text), c));
                this.Close();

            }
        }
    }
}
