using System;
using System.Collections.Generic;
using System.Linq;

namespace FriendMapper.ViewModels
{
    /// <summary>
    /// Represents the ViewModel for a <see cref="FriendViewModel"/>'s Address.
    /// </summary>
    public class AddressViewModel : ViewModel
    {
        private string country;
        private string postcode;
        private string region;
        private string street;
        private string town;

        /// <summary>
        /// Gets or sets the country of the address.
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
        /// Gets or sets the postcode of the address.
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
        /// Gets or sets the region of the address.
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
        /// Gets or sets whether the address has enough information for getting searched for.
        /// </summary>
        public bool Searchable
        {
            get
            {
                return getAddressParts().Any(part => !string.IsNullOrWhiteSpace(part));
            }
        }

        /// <summary>
        /// Gets or sets the street of the address.
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
        /// Gets or sets the town of the address.
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