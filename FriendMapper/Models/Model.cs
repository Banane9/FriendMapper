using Mono.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FriendMapper.Models
{
    public abstract class Model
    {
        protected static readonly SqliteConnection Database = new SqliteConnection("Data Source=Friends.db3;Version=3;");

        protected bool dirty;
    }
}