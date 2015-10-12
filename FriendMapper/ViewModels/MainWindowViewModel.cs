using Microsoft.Maps.MapControl.WPF;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace FriendMapper.ViewModels
{
    public sealed class MainWindowViewModel : ViewModel
    {
        public ObservableCollection<FriendsGroupViewModel> FriendsGroups { get; private set; }

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