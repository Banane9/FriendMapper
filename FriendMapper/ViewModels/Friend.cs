using System;
using System.Collections.Generic;
using System.Linq;

namespace FriendMapper.ViewModels
{
    public class Friend : ViewModel
    {
        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public string Name { get; set; }
    }
}