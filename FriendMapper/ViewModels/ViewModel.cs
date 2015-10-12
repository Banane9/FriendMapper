using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace FriendMapper.ViewModels
{
    /// <summary>
    /// Represents the base for all the ViewModels.
    /// </summary>
    public abstract class ViewModel : INotifyPropertyChanged
    {
        protected void onPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null && propertyName != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}