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
    public partial class OrganizerManageAssociate : Window
    {
        public Associate selectedAssociate = null;

        public OrganizerManageAssociate()
        {
            InitializeComponent();

            dataGrid.DataContext = AppManager.SelectedEvent.eventAssociates;

            foreach (Associate item in AppManager.GetAssociatesNotInSelectedEvent())
            {
                comboBox.Items.Add(item.Name);
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
            this.Hide();
            OrganizerEventOpen form2 = new OrganizerEventOpen();
            form2.Left = this.Left + (this.Width - form2.Width) / 2;
            form2.Top = this.Top + (this.Height - form2.Height) / 2;
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            if(comboBox.SelectedItem != null)
            {
                foreach (Associate item in AppManager.Associates)
                {
                    if(item.Name == comboBox.SelectedItem.ToString())
                    {
                        AppManager.SelectedEvent.eventAssociates.Add(item);
                        break;
                    }
                }
                int index = 0;
                for (int i = 0; i < AppManager.Events.Count; i++)
                {
                    if(AppManager.Events[i].Name == AppManager.SelectedEvent.Name)
                    {
                        index = i;
                        break;
                    }
                }

                AppManager.editEvent(AppManager.SelectedEvent, index);

                dataGrid.DataContext = null;
                dataGrid.DataContext = AppManager.SelectedEvent.eventAssociates;

                comboBox.Items.Clear();
                foreach (Associate item in AppManager.GetAssociatesNotInSelectedEvent())
                {
                    comboBox.Items.Add(item.Name);
                }
            }
        }

        private void button_Copy2_Click(object sender, RoutedEventArgs e)
        {
            if(selectedAssociate != null && dataGrid.SelectedIndex > -1)
            {
                AppManager.SelectedEvent.eventAssociates.RemoveAt(dataGrid.SelectedIndex);
                int index = 0;
                for (int i = 0; i < AppManager.Events.Count; i++)
                {
                    if (AppManager.Events[i].Name == AppManager.SelectedEvent.Name)
                    {
                        index = i;
                        break;
                    }
                }
                AppManager.editEvent(AppManager.SelectedEvent, index);
                selectedAssociate = null;
                textBlock.Text = "";
                dataGrid.DataContext = null;
                dataGrid.DataContext = AppManager.SelectedEvent.eventAssociates;
            }
        }

        private void Row_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            selectedAssociate = AppManager.SelectedEvent.eventAssociates[dataGrid.SelectedIndex];

            textBlock.Text = selectedAssociate.Description;
        }
    }
}
