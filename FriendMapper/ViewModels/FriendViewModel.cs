﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace FriendMapper.ViewModels
{
    /// <summary>
    /// Represents the ViewModel for a friend.
    /// </summary>
    public class FriendViewModel : ViewModel
    {
        private static readonly Random random = new Random();

        private string group;
        private string name;

        /// <summary>
        /// Gets or sets the group of the friend.
        /// </summary>
        public string Group
        {
            get { return group; }
            set
            {
                if (group == value)
                    return;

                group = value;
                onPropertyChanged();
            }
        }

        /// <summary>
        /// Gets the locations associated with the friend.
        /// </summary>
        public ObservableCollection<LocationViewModel> Locations { get; private set; }

        /// <summary>
        /// Gets or sets the name of the friend.
        /// </summary>
        public string Name
        {
            get { return name; }
            set
            {
                if (name == value)
                    return;

                name = value;
                onPropertyChanged();
            }
        }

        public FriendViewModel()
        {
            Locations = new ObservableCollection<LocationViewModel>
                {
                    new LocationViewModel { Name = "Germany", Latitude= random.Next(48, 55), Longitude = random.Next(8, 14), Country = "Germany" }
                };
        }
    }
}