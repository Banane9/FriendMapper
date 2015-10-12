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
                new FriendViewModel { Name = "Cake", Latitude = 53.4, Longitude = 9.7 }
            };
        }
    }
}