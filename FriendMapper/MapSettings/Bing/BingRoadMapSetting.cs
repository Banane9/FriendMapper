using Microsoft.Maps.MapControl.WPF;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FriendMapper.MapSettings.Bing
{
    /// <summary>
    /// Represents a map setting for the Bing road map.
    /// </summary>
    public sealed class BingRoadMapSetting : MapSetting
    {
        public override bool IsBing
        {
            get { return true; }
        }

        public override MapMode MapMode
        {
            get { return new RoadMode(); }
        }
    }
}