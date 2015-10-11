using FriendMapper.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
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

        private void friend_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show(sender.ToString());
        }

        private void friendList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //MessageBox.Show(((Friend)e.AddedItems[0]).Name);
            if (e.AddedItems.Count < 1)
                return;

            var friend = (Friend)e.AddedItems[0];
            friendMap.SetView(new Microsoft.Maps.MapControl.WPF.Location(friend.Latitude, friend.Longitude), 7);
        }
    }
}