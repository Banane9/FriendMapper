using Microsoft.Maps.MapControl.WPF;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FriendMapper.MapSettings
{
    /// <summary>
    /// Represents the base for all the different map settings.
    /// </summary>
    public abstract class MapSetting
    {
        private static readonly Dictionary<string, MapSetting> settings = new Dictionary<string, MapSetting>
            {
                { "Bing Road", new Bing.BingRoadMapSetting() },
                { "Bing Aerial", new Bing.BingAerialMapSetting() },
                { "Bing Aerial with Labels", new Bing.BingAerialLabelsMapSetting() },
                { "Open Street Map", new OpenStreetMapSetting() }
            };

        private static TileSource standardTileSource = new TileSource();

        /// <summary>
        /// Gets the available <see cref="MapSetting"/>s.
        /// </summary>
        public static Dictionary<string, MapSetting> Settings
        {
            get { return settings; }
        }

        /// <summary>
        /// Gets the Copyright notice for the map. Ignored if IsBing is true.
        /// <para/>
        /// Returns string.Empty by default.
        /// </summary>
        public virtual string Copyright
        {
            get { return string.Empty; }
        }

        /// <summary>
        /// Gets whether the <see cref="MapSetting"/> is for a Bing map.
        /// </summary>
        public abstract bool IsBing { get; }

        /// <summary>
        /// Gets the <see cref="MapMode"/> for the map.
        /// <para/>
        /// Returns <see cref="MercatorMode"/> by default.
        /// </summary>
        public virtual MapMode MapMode
        {
            // Have to recreate the map mode every time the property is accessed because.. Bing Control.
            get { return new MercatorMode(); }
        }

        /// <summary>
        /// Gets the <see cref="TileSource"/> for the <see cref="MapTileLayer"/> of the map.
        /// <para/>
        /// Returns the standard <see cref="TileSource"/> by default.
        /// </summary>
        public virtual TileSource TileSource
        {
            get { return standardTileSource; }
        }
    }
}