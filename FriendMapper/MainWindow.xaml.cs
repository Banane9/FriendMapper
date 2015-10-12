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

        private void ImageAwesome_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.AddedItems.Count < 1)
                return;

            var friend = (FriendViewModel)e.AddedItems[0];
            friendMap.SetView(new Microsoft.Maps.MapControl.WPF.Location(friend.Latitude, friend.Longitude), 7);
        }
    }
}