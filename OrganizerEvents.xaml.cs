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
    public class TrackEvent
    {
        private String _t;
        public String Events
        {
            get { return _t; }
            set { _t = value; }
        }
    }
    /// <summary>
    /// Interaction logic for AdminHome.xaml
    /// </summary>
    public partial class OrganizerEvents : Window
    {
        public Collection<TrackEvent> data = new Collection<TrackEvent>();
        public OrganizerEvents()
        {
            InitializeComponent();

            dataGrid.DataContext = data;

            List<eventDTO> s = new List<eventDTO>();

            foreach (Event item in AppManager.getEventOfOrganizer(AppManager.SelectedAccount.Email))
            {
                s.Add(new eventDTO { Event = item.Name });
            }

            dataGrid.DataContext = s;
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
            OrganizerHome form2 = new OrganizerHome();
            form2.Left = this.Left + (this.Width - form2.Width) / 2;
            form2.Top = this.Top + (this.Height - form2.Height) / 2;
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void Row_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            this.IsEnabled = false;
            AppManager.SelectedEvent = AppManager.getEventByName(AppManager.getEventOfOrganizer(AppManager.SelectedAccount.Email)[dataGrid.SelectedIndex].Name);
            OrganizerEventOpen form = new OrganizerEventOpen();
            form.Left = this.Left + (this.Width - form.Width) / 2;
            form.Top = this.Top + (this.Height - form.Height) / 2;
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
    }
}
