using System;

using System.Windows;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace HCI_Projekat
{
    /// <summary>
    /// Interaction logic for AdminHome.xaml
    /// </summary>
    public partial class AdminEvents : Window
    {
        public AdminEvents()
        {

            InitializeComponent();

            dataGrid.DataContext = AppManager.getEvents();
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
            AdminHome form = new AdminHome();
            form.Left = this.Left + (this.Width - form.Width) / 2;
            form.Top = this.Top + (this.Height - form.Height) / 2;
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void button_Copy3_Click(object sender, RoutedEventArgs e)
        {
            this.IsEnabled = false;
            AdminEventAdd form = new AdminEventAdd();
            form.Left = this.Left + (this.Width - form.Width) / 2;
            form.Top = this.Top + (this.Height - form.Height) / 2;
            form.Closed += new EventHandler(ChildClosed);
            form.Show();
        }

        void ChildClosed(object sender, EventArgs e)
        {
            dataGrid.DataContext = AppManager.getEvents();
            this.IsEnabled = true;
        }

        private void button_Copy2_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid.SelectedIndex > -1 && dataGrid.SelectedIndex < AppManager.getEvents().Count)
            {

                AppManager.deleteEvent(AppManager.getEvents()[dataGrid.SelectedIndex].Name);
                dataGrid.DataContext = AppManager.getEvents();
            }
        }

        private void Row_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            this.IsEnabled = false;
            AdminEventEdit form = new AdminEventEdit(AppManager.getEvents()[dataGrid.SelectedIndex], dataGrid.SelectedIndex);
            form.Left = this.Left + (this.Width - form.Width) / 2;
            form.Top = this.Top + (this.Height - form.Height) / 2;
            form.Closed += new EventHandler(ChildClosed);
            form.Show();
        }
    }
}
