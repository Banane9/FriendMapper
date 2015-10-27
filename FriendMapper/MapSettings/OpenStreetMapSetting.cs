using Microsoft.Maps.MapControl.WPF;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FriendMapper.MapSettings
{
    /// <summary>
    /// Represents a map setting for the Open Street Map.
    /// </summary>
    public sealed class OpenStreetMapSetting : MapSetting
    {
        private const string copyright = "© OpenStreetMap contributors";
        private static readonly TileSource osmTileSource = new OSMTileSource();

        public override string Copyright
        {
            get { return copyright; }
        }

        public override bool IsBing
        {
            get { return false; }
        }

        public override TileSource TileSource
        {
            get { return osmTileSource; }
        }

        private sealed class OSMTileSource : TileSource
        {
            private const string baseUrl = "http://tile.openstreetmap.org/";

            public override Uri GetUri(int x, int y, int zoomLevel)
            {
                return new Uri(baseUrl + zoomLevel + "/" + x + "/" + y + ".png");
            }
        }
    }
}