using FriendMapper.MapSettings;
using FriendMapper.MapSettings.Bing;
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
        private MapSetting mapSetting;

        /// <summary>
        /// Gets the friends.
        /// </summary>
        public ObservableCollection<FriendViewModel> Friends { get; private set; }

        /// <summary>
        /// Gets the <see cref="MapSetting"/> used.
        /// </summary>
        public MapSetting MapSetting
        {
            get { return mapSetting; }
            set
            {
                if (mapSetting == value)
                    return;

                mapSetting = value;
                onPropertyChanged();
            }
        }

        public MainWindowViewModel()
        {
            MapSetting = new BingRoadMapSetting();

            Friends = new ObservableCollection<FriendViewModel>
            {
                new FriendViewModel { Name = "Banane9", Group = "Me" },
                new FriendViewModel { Name = "The", Group = "Joke" },
                new FriendViewModel { Name = "Cake", Group = "Joke" },
                new FriendViewModel { Name = "is", Group = "Joke" },
                new FriendViewModel { Name = "a", Group = "Joke" },
                new FriendViewModel { Name = "lie!", Group = "Joke" }
            };
        }
    }
}