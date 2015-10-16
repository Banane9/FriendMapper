using BingGeocoder;
using Microsoft.Maps.MapControl.WPF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Media;

namespace FriendMapper.ViewModels
{
    /// <summary>
    /// Represents the ViewModel for a <see cref="FriendViewModel"/>'s Location.
    /// </summary>
    public class LocationViewModel : ViewModel
    {
        private readonly static GeoCoder geocoder = new GeoCoder(
            apiKey: "As0m7iHT5ho1S3B9FjPmqDbeDE5vtatOxL3DzX-eWR-rSntGsLPM8kc3LT2fSAiB",
            user_agent: "FriendMapper",
            culture: System.Globalization.CultureInfo.CurrentUICulture.Name);

        private Color color = Color.FromRgb(0, 0, 0);
        private string country;
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
                onPropertyChanged();
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

                country = value; ;
                onPropertyChanged();
                onPropertyChanged("Searchable");
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
                onPropertyChanged();
                onPropertyChanged("Location");
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
                onPropertyChanged();
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
                onPropertyChanged();
                onPropertyChanged("Searchable");
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
                onPropertyChanged();
                onPropertyChanged("Searchable");
            }
        }

        /// <summary>
        /// Gets or sets whether the location has enough information for getting searched for.
        /// </summary>
        public bool Searchable
        {
            get
            {
                return getAddressParts().Any(part => !string.IsNullOrWhiteSpace(part));
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
                onPropertyChanged();
                onPropertyChanged("Searchable");
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
                onPropertyChanged();
                onPropertyChanged("Searchable");
            }
        }

        internal async void searchAddress()
        {
            if (!Searchable)
                return;

            var queryResult = await geocoder.GetCoordinate(
                addressLine: Street,
                locality: Town,
                adminDistrict: Region,
                postalCode: Postcode,
                countryRegion: Country);

            Latitude = queryResult.Item1;
            Longitude = queryResult.Item2;
        }

        private IEnumerable<string> getAddressParts()
        {
            yield return street;
            yield return postcode;
            yield return town;
            yield return region;
            yield return country;
        }
    }
}