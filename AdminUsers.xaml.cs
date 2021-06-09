using System;

using System.Windows;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Collections.Generic;

namespace HCI_Projekat
{
    /// <summary>
    /// Interaction logic for AdminHome.xaml
    /// </summary>
    public partial class AdminUsers : Window
    {
        public AdminUsers()
        {

            InitializeComponent();

            dataGrid.DataContext = AppManager.getClients();
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
            AdminUserAdd form = new AdminUserAdd();
            form.Left = this.Left + (this.Width - form.Width) / 2;
            form.Top = this.Top + (this.Height - form.Height) / 2;
            form.Closed += new EventHandler(ChildClosed);
            form.Show();
        }

        void ChildClosed(object sender, EventArgs e)
        {
            dataGrid.DataContext = AppManager.getClients();
            this.IsEnabled = true;
        }

        private void button_Copy2_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid.SelectedIndex > -1 && dataGrid.SelectedIndex < AppManager.getClients().Count)
            {
                
                AppManager.deleteAccount(AppManager.getClients()[dataGrid.SelectedIndex].Email);
                dataGrid.DataContext = AppManager.getClients();
            }
        }

        private void Row_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            this.IsEnabled = false;
            AdminUserEdit form = new AdminUserEdit(AppManager.getClients()[dataGrid.SelectedIndex]);
            form.Left = this.Left + (this.Width - form.Width) / 2;
            form.Top = this.Top + (this.Height - form.Height) / 2;
            form.Closed += new EventHandler(ChildClosed);
            form.Show();
        }

        private void dataGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
    }
}
