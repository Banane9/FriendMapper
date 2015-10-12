using FontAwesome.WPF;
using FriendMapper.ViewModels;
using Microsoft.Maps.MapControl.WPF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

            foreach (var friend in ((MainWindowViewModel)DataContext).Friends)
            {
                var pushpin = new Pushpin();
                pushpin.Location = new Location(friend.Latitude, friend.Longitude);

                friendMap.Children.Add(pushpin);
            }
        }

        private void friendMapMarker_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var friend = (FriendViewModel)((ImageAwesome)sender).DataContext;
            friendMap.SetView(new Microsoft.Maps.MapControl.WPF.Location(friend.Latitude, friend.Longitude), friendMap.ZoomLevel);
        }

        private async void friendSettings_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var friendSettingsWindow = new FriendSettingsWindow();
            friendSettingsWindow.Closed += (window, _) => openedWindows.Remove((Window)window);
            openedWindows.Add(friendSettingsWindow);

            friendSettingsWindow.DataContext = (FriendViewModel)((ImageAwesome)sender).DataContext;
            friendSettingsWindow.Show();

            await Task.Delay(10);

            friendSettingsWindow.Activate();
            friendSettingsWindow.Focus();
        }
    }
}