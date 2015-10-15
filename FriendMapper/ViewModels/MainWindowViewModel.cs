using Microsoft.Maps.MapControl.WPF;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace FriendMapper.ViewModels
{
    /// <summary>
    /// Represents the ViewModel for the main window.
    /// </summary>
    public sealed class MainWindowViewModel : ViewModel
    {
        /// <summary>
        /// Gets the grouped friends.
        /// </summary>
        public ObservableCollection<FriendViewModel> Friends { get; private set; }

        /// <summary>
        /// Gets the map mode.
        /// </summary>
        public MapMode MapMode
        {
            get { return new RoadMode(); }
        }

        public MainWindowViewModel()
        {
            Friends = new ObservableCollection<FriendViewModel>
            {
                new FriendViewModel { Name = "Banane9", Latitude = 52, Longitude = 9, Group = "Me" },
                new FriendViewModel { Name = "The", Latitude = 54, Longitude = 10, Group = "Joke" },
                new FriendViewModel { Name = "Cake", Latitude = 53.4, Longitude = 9.7, Group = "Joke" },
                new FriendViewModel { Name = "is", Latitude = 53, Longitude = 9, Group = "Joke" },
                new FriendViewModel { Name = "a", Latitude = 53.5, Longitude = 9.5, Group = "Joke" },
                new FriendViewModel { Name = "lie!", Latitude = 54, Longitude = 9, Group = "Joke" }
            };
        }
    }
}