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

namespace HCI_Projekat
{
    /// <summary>
    /// Interaction logic for AdminHome.xaml
    /// </summary>
    public partial class OrganizerInfo : Window
    {
        public OrganizerInfo()
        {
            InitializeComponent();

            textBox_name.Text = AppManager.SelectedAccount.Name;
            textBox_email.Text = AppManager.SelectedAccount.Email;
            textBox_phone.Text = AppManager.SelectedAccount.Phone;

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

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            if (textBox_name.Text == "" || textBox_email.Text == "" || textBox_phone.Text == "")
            {
                // los unos
            }
            else
            {
                if (passwordBox.Password == passwordBoxConfirm.Password && passwordBox.Password != "")
                {
                    AppManager.SelectedAccount.Password = passwordBox.Password;
                    AppManager.editAccount(new Account(Role.ORGANIZER, textBox_name.Text, textBox_email.Text, textBox_phone.Text, passwordBox.Password));
                }
                else
                {
                    AppManager.editAccount(new Account(Role.ORGANIZER, textBox_name.Text, textBox_email.Text, textBox_phone.Text, AppManager.SelectedAccount.Password));
                }

                AppManager.SelectedAccount.Name = textBox_name.Text;
                AppManager.SelectedAccount.Phone = textBox_phone.Text;

                this.Hide();
                OrganizerHome form2 = new OrganizerHome();
                form2.Left = this.Left + (this.Width - form2.Width) / 2;
                form2.Top = this.Top + (this.Height - form2.Height) / 2;
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
        }
    }
}
