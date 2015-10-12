using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace FriendMapper.ViewModels
{
    public class FriendsGroupViewModel : ViewModel
    {
        public ObservableCollection<FriendViewModel> Friends { get; private set; }

        public string Name { get; set; }

        public FriendsGroupViewModel()
        {
            Friends = new ObservableCollection<FriendViewModel>
            {
                new FriendViewModel { Name = "Banane9", Latitude = 52, Longitude = 9 },
                new FriendViewModel { Name = "The", Latitude = 54, Longitude = 10 },
                new FriendViewModel { Name = "Cake", Latitude = 53.4, Longitude = 9.7 },
                new FriendViewModel { Name = "is", Latitude = 53, Longitude = 9 },
                new FriendViewModel { Name = "a", Latitude = 53.5, Longitude = 9.5 },
                new FriendViewModel { Name = "lie!", Latitude = 54, Longitude = 9 }
            };
        }
    }
}