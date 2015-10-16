using BingGeocoder;
using FriendMapper.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace FriendMapper
{
    /// <summary>
    /// Interactionlogic for FriendSettingsWindow.xaml
    /// </summary>
    public partial class FriendSettingsWindow : Window
    {
        private GeoCoder geocoder = new GeoCoder("As0m7iHT5ho1S3B9FjPmqDbeDE5vtatOxL3DzX-eWR-rSntGsLPM8kc3LT2fSAiB", "FriendMapper", System.Globalization.CultureInfo.CurrentUICulture.Name);

        public FriendSettingsWindow()
        {
            InitializeComponent();
        }

        private async void addressSearchButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var friend = (FriendViewModel)DataContext;
            var address = friend.Address;

            if (!address.Searchable)
                return;

            var queryResult = await geocoder.GetCoordinate(
                addressLine: address.Street,
                locality: address.Town,
                adminDistrict: address.Region,
                postalCode: address.Postcode,
                countryRegion: address.Country);

            friend.Latitude = queryResult.Item1;
            friend.Longitude = queryResult.Item2;
        }
    }
}