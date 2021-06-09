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
    /// Interaction logic for AllEventsView.xaml
    /// </summary>
    /// 

    public partial class AllEventsView : UserControl
    {
        List<Event> clientEvents;

        List<Suggestion> clientSuggestions;

        public AllEventsView()
        {
            InitializeComponent();

            clientEvents = AppManager.getEventOfClient(AppManager.SelectedAccount.Email);

            List<eventDTO> s = new List<eventDTO>();

            foreach (Event item in clientEvents)
            {
                s.Add(new eventDTO { Event = item.Name });
            }

            dataGrid.DataContext = s;

            panel1.Visibility = Visibility.Hidden;
            panel2.Visibility = Visibility.Hidden;
        }

        private void datagrid_CurrentCellChanged(object sender, EventArgs e)
        {
            Console.WriteLine(dataGrid.SelectedIndex);
            if (dataGrid.SelectedIndex > -1)
            {
                clientSuggestions = AppManager.getEventSuggestionsPending(clientEvents[dataGrid.SelectedIndex].Name);

                if (clientSuggestions.Count > 0)
                {
                    panel1.Visibility = Visibility.Visible;
                    panel2.Visibility = Visibility.Visible;
                    suggestionLabel.Content = "Suggestion - " + clientSuggestions[0].organizerEmail;
                    MessageTextBox.Text = clientSuggestions[0].message;
                }
                else
                {
                    panel1.Visibility = Visibility.Hidden;
                    panel2.Visibility = Visibility.Hidden;
                }
            }
        }

        private void AllowButton_Click(object sender, RoutedEventArgs e)
        {
            clientSuggestions[0].status = Status.Accepted;
            clientSuggestions[0].back_message = responce.Text;
            AppManager.saveSuggestion(clientSuggestions[0]);
            clientSuggestions.RemoveAt(0);

            if (clientSuggestions.Count > 0)
            {
                panel1.Visibility = Visibility.Visible;
                panel2.Visibility = Visibility.Visible;
                suggestionLabel.Content = "Suggestion - " + clientSuggestions[0].organizerEmail;
                MessageTextBox.Text = clientSuggestions[0].message;
            }
            else
            {
                panel1.Visibility = Visibility.Hidden;
                panel2.Visibility = Visibility.Hidden;
            }
        }

        private void DenyButton_Click(object sender, RoutedEventArgs e)
        {
            clientSuggestions[0].status = Status.Denied;
            clientSuggestions[0].back_message = responce.Text;
            AppManager.saveSuggestion(clientSuggestions[0]);
            clientSuggestions.RemoveAt(0);

            if (clientSuggestions.Count > 0)
            {
                panel1.Visibility = Visibility.Visible;
                panel2.Visibility = Visibility.Visible;
                suggestionLabel.Content = "Suggestion - " + clientSuggestions[0].organizerEmail;
                MessageTextBox.Text = clientSuggestions[0].message;
            }
            else
            {
                panel1.Visibility = Visibility.Hidden;
                panel2.Visibility = Visibility.Hidden;
            }
        }
    }
}
