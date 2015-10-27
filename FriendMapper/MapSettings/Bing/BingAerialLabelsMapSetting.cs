﻿using Microsoft.Maps.MapControl.WPF;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FriendMapper.MapSettings.Bing
{
    /// <summary>
    /// Represents a map setting for the Bing aerial map with labels.
    /// </summary>
    public sealed class BingAerialLabelsMapSetting : MapSetting
    {
        public override bool IsBing
        {
            get { return true; }
        }

        public override MapMode MapMode
        {
            get { return new AerialMode(true); }
        }
    }
}