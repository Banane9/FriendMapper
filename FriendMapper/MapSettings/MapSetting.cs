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
        protected static MapMode mercatorMode = new MercatorMode();
        protected static TileSource standardTileSource = new TileSource();

        /// <summary>
        /// Gets the <see cref="MapMode"/> for the map.
        /// <para/>
        /// Returns <see cref="MercatorMode"/> by default.
        /// </summary>
        public virtual MapMode MapMode
        {
            get { return mercatorMode; }
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