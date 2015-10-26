using BingGeocoder;
using FriendMapper.Models;
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

        private readonly LocationModel model = new LocationModel();

        /// <summary>
        /// Gets or sets the color of the location's marker.
        /// </summary>
        public Color Color
        {
            get { return model.Color; }
            set
            {
                if (model.Color == value)
                    return;

                model.Color = value;
                onPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the country of the location.
        /// </summary>
        public string Country
        {
            get { return model.Country; }
            set
            {
                if (model.Country == value)
                    return;

                model.Country = value; ;
                onPropertyChanged();
                onPropertyChanged("Searchable");
            }
        }

        /// <summary>
        /// Gets or sets the latitude of the location.
        /// </summary>
        public double Latitude
        {
            get { return model.Latitude; }
            set
            {
                if (model.Latitude == value)
                    return;

                model.Latitude = value;
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
                return new Location(Latitude, Longitude);
            }
        }

        /// <summary>
        /// Gets or sets the longitude of the location.
        /// </summary>
        public double Longitude
        {
            get { return model.Longitude; }
            set
            {
                if (model.Longitude == value)
                    return;

                model.Longitude = value;
                onPropertyChanged();
                onPropertyChanged("Location");
            }
        }

        /// <summary>
        /// Gets or sets the name of the location.
        /// </summary>
        public string Name
        {
            get { return model.Name; }
            set
            {
                if (model.Name == value)
                    return;

                model.Name = value;
                onPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the postcode of the location.
        /// </summary>
        public string Postcode
        {
            get { return model.Postcode; }
            set
            {
                if (model.Postcode == value)
                    return;

                model.Postcode = value;
                onPropertyChanged();
                onPropertyChanged("Searchable");
            }
        }

        /// <summary>
        /// Gets or sets the region of the location.
        /// </summary>
        public string Region
        {
            get { return model.Region; }
            set
            {
                if (model.Region == value)
                    return;

                model.Region = value;
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
            get { return model.Street; }
            set
            {
                if (model.Street == value)
                    return;

                model.Street = value;
                onPropertyChanged();
                onPropertyChanged("Searchable");
            }
        }

        /// <summary>
        /// Gets or sets the town of the location.
        /// </summary>
        public string Town
        {
            get { return model.Town; }
            set
            {
                if (model.Town == value)
                    return;

                model.Town = value;
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
            yield return model.Street;
            yield return model.Postcode;
            yield return model.Town;
            yield return model.Region;
            yield return model.Country;
        }
    }
}