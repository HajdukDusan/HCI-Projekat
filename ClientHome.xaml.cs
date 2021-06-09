using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class ClientHome : Window
    {
        Account client;

        public ClientHome(Account c)
        {
            InitializeComponent();
            client = c;
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            this.Hide();
            login form3 = new login();
            form3.Left = this.Left + (this.Width - form3.Width) / 2;
            form3.Top = this.Top + (this.Height - form3.Height) / 2;
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            process.StartInfo = startInfo;
            startInfo.FileName = @"C:\Users\Hajduk\Desktop\HCI-Projekat\bin\doc.pdf";
            process.Start();
        }
    }
}
