using Microsoft.Maps.MapControl.WPF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Media;

namespace FriendMapper.ViewModels
{
    /// <summary>
    /// Represents the ViewModel for a friend.
    /// </summary>
    public class FriendViewModel : ViewModel
    {
        private string address;
        private Color color = Color.FromRgb(0, 0, 0);
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
        /// Gets or sets the color of the friend's marker.
        /// </summary>
        public Color Color
        {
            get { return color; }
            set
            {
                if (color == value)
                    return;

                color = value;
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
                onPropertyChanged("Location");
            }
        }

        /// <summary>
        /// Gets the map location.
        /// </summary>
        public Location Location
        {
            get
            {
                return new Location(latitude, longitude);
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
                onPropertyChanged("Location");
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