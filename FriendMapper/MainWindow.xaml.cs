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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void friendMapMarker_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var friend = (FriendViewModel)((ImageAwesome)sender).DataContext;
            friendMap.SetView(new Microsoft.Maps.MapControl.WPF.Location(friend.Latitude, friend.Longitude), friendMap.ZoomLevel);
        }
    }
}