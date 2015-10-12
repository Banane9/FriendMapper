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
        public ObservableCollection<FriendsGroupViewModel> FriendsGroups { get; private set; }

        /// <summary>
        /// Gets the map mode.
        /// </summary>
        public MapMode MapMode
        {
            get { return new AerialMode(true); }
        }

        public MainWindowViewModel()
        {
            FriendsGroups = new ObservableCollection<FriendsGroupViewModel>
            {
                new FriendsGroupViewModel { Name = "Best" }
            };
        }
    }
}