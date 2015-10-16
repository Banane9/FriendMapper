using FontAwesome.WPF;
using FriendMapper.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace FriendMapper
{
    /// <summary>
    /// Interactionlogic for FriendSettingsWindow.xaml
    /// </summary>
    public partial class FriendSettingsWindow : Window
    {
        public FriendSettingsWindow()
        {
            InitializeComponent();
        }

        private void addLocationPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ((FriendViewModel)DataContext).Locations.Insert(0, new LocationViewModel { Name = "New Location" });
        }

        private async void addressSearchButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ((LocationViewModel)((ImageAwesome)sender).DataContext).searchAddress();
        }
    }
}