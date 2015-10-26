using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Media;

namespace FriendMapper.Models
{
    /// <summary>
    /// Represents the model for a location.
    /// </summary>
    public class LocationModel : Model
    {
        private Color color = Color.FromRgb(0, 0, 0);
        private string country;
        private uint id;
        private double latitude;
        private double longitude;
        private string name;
        private string postcode;
        private string region;
        private string street;
        private string town;

        /// <summary>
        /// Gets or sets the color of the location's marker.
        /// </summary>
        public Color Color
        {
            get { return color; }
            set
            {
                if (color == value)
                    return;

                color = value;
                dirty = true;
            }
        }

        /// <summary>
        /// Gets or sets the country of the location.
        /// </summary>
        public string Country
        {
            get { return country; }
            set
            {
                if (country == value)
                    return;

                country = value;
                dirty = true;
            }
        }

        /// <summary>
        /// Gets or sets the latitude of the location.
        /// </summary>
        public double Latitude
        {
            get { return latitude; }
            set
            {
                if (latitude == value)
                    return;

                latitude = value;
                dirty = true;
            }
        }

        /// <summary>
        /// Gets or sets the longitude of the location.
        /// </summary>
        public double Longitude
        {
            get { return longitude; }
            set
            {
                if (longitude == value)
                    return;

                longitude = value;
                dirty = true;
            }
        }

        /// <summary>
        /// Gets or sets the name of the location.
        /// </summary>
        public string Name
        {
            get { return name; }
            set
            {
                if (name == value)
                    return;

                name = value;
                dirty = true;
            }
        }

        /// <summary>
        /// Gets or sets the postcode of the location.
        /// </summary>
        public string Postcode
        {
            get { return postcode; }
            set
            {
                if (postcode == value)
                    return;

                postcode = value;
                dirty = true;
            }
        }

        /// <summary>
        /// Gets or sets the region of the location.
        /// </summary>
        public string Region
        {
            get { return region; }
            set
            {
                if (region == value)
                    return;

                region = value;
                dirty = true;
            }
        }

        /// <summary>
        /// Gets or sets the street of the location.
        /// </summary>
        public string Street
        {
            get { return street; }
            set
            {
                if (street == value)
                    return;

                street = value;
                dirty = true;
            }
        }

        /// <summary>
        /// Gets or sets the town of the location.
        /// </summary>
        public string Town
        {
            get { return town; }
            set
            {
                if (town == value)
                    return;

                town = value;
                dirty = true;
            }
        }
    }
}