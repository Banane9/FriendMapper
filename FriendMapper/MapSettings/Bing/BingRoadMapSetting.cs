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
        private static MapMode roadMapMode = new RoadMode();

        public override MapMode MapMode
        {
            get { return roadMapMode; }
        }
    }
}