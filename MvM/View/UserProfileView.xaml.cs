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
    /// Interaction logic for UserProfileView.xaml
    /// </summary>
    public partial class UserProfileView : UserControl
    {

        private Image draggedItem;
        private Point itemRelativePosition;
        public UserProfileView()
        {
            InitializeComponent();

            UsernameTextField.Text = AppManager.SelectedAccount.Name;
            EmailTextField.Text = AppManager.SelectedAccount.Email;
            PhoneTextBox.Text = AppManager.SelectedAccount.Phone;
            PasswordTextBox.Text = AppManager.SelectedAccount.Password;
        }

        private void SaveEmail_Click(object sender, RoutedEventArgs e)
        {
            if (PhoneTextBox.Text == "")
            {
                // los unos
            }
            else
            {
                AppManager.SelectedAccount.Phone = PhoneTextBox.Text;
                AppManager.editAccount(AppManager.SelectedAccount);
            }
        }

        private void SavePassword_Click(object sender, RoutedEventArgs e)
        {
            if (PasswordTextBox.Text == "")
            {
                // los unos
            }
            else
            {
                AppManager.SelectedAccount.Password = PasswordTextBox.Text;
                AppManager.editAccount(AppManager.SelectedAccount);
            }
        }

        private void AddButtonClick(object sender, RoutedEventArgs e)
        {
            var dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.Filter =
                "Image Files (*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";

            if ((bool)dialog.ShowDialog())
            {
                var bitmap = new BitmapImage(new Uri(dialog.FileName));
                var image = new Image { Source = bitmap };
                Canvas.SetLeft(image, 0);
                Canvas.SetTop(image, 0);
                image.MouseLeftButtonDown += Img_MouseLeftButtonDown;
                canvasImages.Children.Add(image);
            }

        }

        private void Img_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.draggedItem = (Image)sender;
            itemRelativePosition = e.GetPosition(this.draggedItem);
            e.Handled = true;
        }

        private void CanvasImages_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            if (this.draggedItem == null)
                return;
            var newPos = e.GetPosition(canvasImages) - itemRelativePosition;
            Canvas.SetTop(this.draggedItem, newPos.Y);
            Canvas.SetLeft(this.draggedItem, newPos.X);
            canvasImages.CaptureMouse();
            e.Handled = true;
        }

        private void CanvasImages_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (this.draggedItem != null)
            {
                this.draggedItem = null;
                canvasImages.ReleaseMouseCapture();
                e.Handled = true;
            }
        }
    }
}
