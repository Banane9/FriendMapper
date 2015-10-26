using System;
using System.Collections.Generic;
using System.Linq;

namespace FriendMapper.Models
{
    /// <summary>
    /// Represents the model for a friend.
    /// </summary>
    public class FriendModel : Model
    {
        private string group;
        private uint id;
        private string name;

        /// <summary>
        /// Gets or sets the group of the friend.
        /// </summary>
        public string Group
        {
            get { return group; }
            set
            {
                if (group == value)
                    return;

                group = value;
                dirty = true;
            }
        }

        /// <summary>
        /// Gets the locations associated with the friend.
        /// </summary>
        public List<LocationModel> Locations { get; private set; }

        /// <summary>
        /// Gets or sets the name of the friend.
        /// </summary>
        public string Name
        {
            get { return name; }
            set
            {
                if (name == value)
                    return;

                name = value;
                dirty = true;
            }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="FriendModel"/> class, populating it with the data from the database for that id.
        /// </summary>
        /// <param name="id">The database id of the friend.</param>
        public FriendModel(uint id)
        {
            this.id = id;
        }
    }
}