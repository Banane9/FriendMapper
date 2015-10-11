using Microsoft.Maps.MapControl.WPF;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace FriendMapper.ViewModels
{
    public sealed class MainWindowViewModel : ViewModel
    {
        public ObservableCollection<FriendsProvider> FriendsProviders { get; private set; }

        public MapMode MapMode
        {
            get { return new AerialMode(true); }
        }

        public MainWindowViewModel()
        {
            FriendsProviders = new ObservableCollection<FriendsProvider>
            {
                new FriendsProvider { Name = "Facebook" }
            };
        }
    }
}