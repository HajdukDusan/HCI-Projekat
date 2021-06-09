﻿using System;

using System.Windows;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace HCI_Projekat
{

    /// <summary>
    /// Interaction logic for AdminHome.xaml
    /// </summary>
    public partial class AdminAssociateAdd : Window
    {

        public AdminAssociateAdd()
        {
            InitializeComponent();

            for (int i = 0; i < AppManager.AssociateTypes.Count; i++)
            {
                comboBox_type.Items.Add(AppManager.AssociateTypes[i]);
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
            this.Close();
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            if(textBox_name.Text == "" || textBox_description.Text == "")
            {
                // nije uneo sve
                return;
            }

            if (checkBox_new_type.IsChecked == true)
            {
                if (textBox_new_type.Text == "")
                {
                    // nije def novi tip
                    return;
                }
            }
            else if (comboBox_type.SelectedItem == null)
            {
                // nije uneo tip
                return;
            }

            if (checkBox_new_type.IsChecked == true) {
                AppManager.addAssociate(new Associate(textBox_new_type.Text, textBox_name.Text, textBox_description.Text));
            }
            else
            {
                AppManager.addAssociate(new Associate(comboBox_type.SelectedItem.ToString(), textBox_name.Text, textBox_description.Text));
            }
            this.Close();

        }

        private void checkBox_new_type_Checked(object sender, RoutedEventArgs e)
        {
            if (checkBox_new_type.IsChecked == true)
            {
                textBox_new_type.IsEnabled = true;
            }
            else
            {
                textBox_new_type.Text = "";
                textBox_new_type.IsEnabled = false;
            }
        }
    }
}
