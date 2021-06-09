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
    public class Track
    {
        private String _t;
        private String _a;
        private int _n;
        public String title
        {
            get { return _t; }
            set { _t = value; }
        }
        public String artist
        {
            get { return _a; }
            set { _a = value; }
        }
        public int number
        {
            get { return _n; }
            set { _n = value; }
        }
    }
    /// <summary>
    /// Interaction logic for AdminHome.xaml
    /// </summary>
    public partial class OrganizerManageSuggestions : Window
    {
        public Collection<Track> data = new Collection<Track>();
        public OrganizerManageSuggestions()
        {
            InitializeComponent();

            dataGrid.DataContext = AppManager.getEventSuggestions(AppManager.SelectedEvent.Name);
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
            this.Hide();
            OrganizerEventOpen form2 = new OrganizerEventOpen();
            form2.Left = this.Left + (this.Width - form2.Width) / 2;
            form2.Top = this.Top + (this.Height - form2.Height) / 2;
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            if(textBox_Suggestion.Text != "")
            {
                AppManager.addSuggestion(new Suggestion(
                    AppManager.SelectedEvent.Name,
                    AppManager.SelectedEvent._client.Name,
                    AppManager.SelectedAccount.Name,
                    textBox_Suggestion.Text,
                    "",
                    Status.Pending));
                dataGrid.DataContext = AppManager.getEventSuggestions(AppManager.SelectedEvent.Name);
            }
        }

        private void Row_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            textBlock_YourSuggestion.Text = AppManager.getEventSuggestions(AppManager.SelectedEvent.Name)[dataGrid.SelectedIndex].message;

            textBlock_Replay.Text = AppManager.getEventSuggestions(AppManager.SelectedEvent.Name)[dataGrid.SelectedIndex].back_message;
            if(textBlock_Replay.Text == "")
            {
                textBlock_Replay.Text = "Pending...";
            }
            statusLabel.Content = textBlock_YourSuggestion.Text = AppManager.getEventSuggestions(AppManager.SelectedEvent.Name)[dataGrid.SelectedIndex].status.ToString();
        }
    }
}
