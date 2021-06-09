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

namespace HCI_Projekat.MvM.View
{
    /// <summary>
    /// Interaction logic for HomePageView.xaml
    /// </summary>
    public partial class HomePageView : UserControl
    {
        public HomePageView()
        {
            InitializeComponent();


            foreach (Account a in AppManager.getOrganizers())
            {
                comboBox_organizer.Items.Add(a.Name);
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
        private void EventInfoInputClick(object sender, RoutedEventArgs e)
        {
            
            if (textBox_name.Text == "" || comboBox_organizer.SelectedItem == null || comboBox_type.SelectedItem == null || textBox_budget.Text == ""
                || textBox_location.Text == "" || DatePicker.SelectedDate == null || comboBox_color.SelectedItem == null
                || textBox_guestCnt.Text == "" || textBox_avgAge.Text == "")
            {
                // los unos
            }
            else
            {

                //this.IsEnabled = false;
                bool c = false;
                ConfirmationWindow form = new ConfirmationWindow(ref c);
                form.Left = 800;
                form.Top = 400;
                form.Closed += new EventHandler(ChildClosed);
                form.Show();

            }
            
        }
        void ChildClosed(object sender, EventArgs e)
        {
            if (AppManager.confirm)
            {
                Account o = null;
                foreach (Account item in AppManager.Accounts)
                {
                    if (item.Name == comboBox_organizer.SelectedItem.ToString())
                    {
                        o = item;
                    }
                }

                AppManager.addEvent(new Event(textBox_name.Text, o, (EventType)Enum.Parse(typeof(EventType), comboBox_type.SelectedItem.ToString()),
                              textBox_budget.Text, textBox_location.Text, textBox_theme.Text, DatePicker.SelectedDate.ToString(), (Color)Enum.Parse(typeof(Color), comboBox_color.SelectedItem.ToString()),
                              Int32.Parse(textBox_guestCnt.Text), Int32.Parse(textBox_avgAge.Text), AppManager.SelectedAccount));

                textBox_name.Text = "";
                comboBox_organizer.SelectedItem = null;
                comboBox_type.SelectedItem = null;
                comboBox_color.SelectedItem = null;
                textBox_budget.Text = "";
                textBox_guestCnt.Text = "";
                textBox_avgAge.Text = "";
                textBox_location.Text = "";
                textBox_theme.Text = "";
                DatePicker.SelectedDate = null;
            }
        }
    }
}
