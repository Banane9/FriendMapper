using Microsoft.Maps.MapControl.WPF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace FriendMapper.MapSettings
{
    /// <summary>
    /// Represents a <see cref="MapTileLayer"/> that supports bindings for the TileSource.
    /// </summary>
    public sealed class CustomMapTileLayer : MapTileLayer
    {
        public static readonly DependencyProperty TileSourceProperty =
                    DependencyProperty.Register("TileSource", typeof(TileSource), typeof(CustomMapTileLayer), new FrameworkPropertyMetadata(new TileSource(), onTileSourceChanged));

        /// <summary>
        /// Gets or sets the tile source of the tile layer.
        /// </summary>
        public new TileSource TileSource
        {
            get { return (TileSource)GetValue(TileSourceProperty); }
            set { SetValue(TileSourceProperty, value); }
        }

        /// <summary>
        /// Gets or sets the base's TileSource.
        /// </summary>
        private TileSource baseTileSource
        {
            get { return base.TileSource; }
            set { base.TileSource = value; }
        }

        public CustomMapTileLayer()
        {
            baseTileSource = new TileSource();
        }

        /// <summary>
        /// Updates the base's TileSource.
        /// </summary>
        private static void onTileSourceChanged(DependencyObject source, DependencyPropertyChangedEventArgs e)
        {
            var @this = (CustomMapTileLayer)source;
            @this.baseTileSource = (TileSource)e.NewValue;
        }
    }
}