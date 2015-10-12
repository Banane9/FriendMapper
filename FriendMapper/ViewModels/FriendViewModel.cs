using System;
using System.Collections.Generic;
using System.Linq;

namespace FriendMapper.ViewModels
{
    /// <summary>
    /// Represents the ViewModel for a friend.
    /// </summary>
    public class FriendViewModel : ViewModel
    {
        private string address;
        private string group;
        private double latitude;
        private double longitude;
        private string name;

        /// <summary>
        /// Gets or sets the address of the friend.
        /// </summary>
        public string Address
        {
            get { return address; }
            set
            {
                if (address == value)
                    return;

                address = value;
                onPropertyChanged();
            }
        }

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
        /// Gets or sets the latitude of the friend's address.
        /// </summary>
        public double Latitude
        {
            get { return latitude; }
            set
            {
                if (latitude == value)
                    return;

                latitude = value;
                onPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the longitude of the friend's address.
        /// </summary>
        public double Longitude
        {
            get { return longitude; }
            set
            {
                if (longitude == value)
                    return;

                longitude = value;
                onPropertyChanged();
            }
        }

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
    }
}