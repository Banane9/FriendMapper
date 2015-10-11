using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace FriendMapper.ViewModels
{
    public class FriendsProvider : ViewModel
    {
        public ObservableCollection<Friend> Friends { get; private set; }

        public string Name { get; set; }

        public FriendsProvider()
        {
            Friends = new ObservableCollection<Friend>
            {
                new Friend { Name = "Banane9", Latitude = 52, Longitude = 9 },
                new Friend { Name = "Cake", Latitude = 53.4, Longitude = 9.7 }
            };
        }
    }
}