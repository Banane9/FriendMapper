using FontAwesome.WPF;
using FriendMapper.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows;
using System.Windows.Input;

namespace FriendMapper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Window> openedWindows = new List<Window>();

        public MainWindow()
        {
            InitializeComponent();

            Closing += (sender, e) =>
                {
                    foreach (var window in openedWindows.ToArray())
                        window.Close();
                };
        }

        private void addFriendPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var newFriend = new FriendViewModel();

            var friendSettingsWindow = showFriendSettingsWindow(newFriend);

            friendSettingsWindow.Closed += (_, __) => ((MainWindowViewModel)DataContext).Friends.Add(newFriend);
        }

        private void friendMapMarker_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var friend = (FriendViewModel)((ImageAwesome)sender).DataContext;
            friendMap.SetView(new Microsoft.Maps.MapControl.WPF.Location(friend.Latitude, friend.Longitude), friendMap.ZoomLevel);
        }

        private void friendSettings_MouseDown(object sender, MouseButtonEventArgs e)
        {
            showFriendSettingsWindow((FriendViewModel)((ImageAwesome)sender).DataContext);
        }

        private Window showFriendSettingsWindow(FriendViewModel friend)
        {
            var friendSettingsWindow = new FriendSettingsWindow();
            friendSettingsWindow.Closed += (window, _) => openedWindows.Remove((Window)window);
            openedWindows.Add(friendSettingsWindow);

            friendSettingsWindow.DataContext = friend;
            friendSettingsWindow.Show();

            Thread.Sleep(10);

            friendSettingsWindow.Activate();
            friendSettingsWindow.Focus();

            return friendSettingsWindow;
        }
    }
}