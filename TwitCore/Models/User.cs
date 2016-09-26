using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TwitCore.Interfaces;

namespace TwitCore.Models {
    /// <summary>
    /// User denotes a user in the system
    /// </summary>
    public class User : IPerson {
        #region fields
        private string name;
        private string surname;
        private TimeZone timeZone;
        private List<Tweet> tweets;
        #endregion fields

        #region properties
        public List<Tweet> Tweets {
            get { return tweets; }
            set { tweets = value; }
        }

        public TimeZone TimeZone {
            get { return timeZone; }
            set { timeZone = value; }
        }

        public string Name {
            get { return name; }
            set { name = value; }
        }

        public string Surname {
            get { return surname; }
            set { surname = value; }
        }
        #endregion properties

        #region constructor
        public User() { }
        #endregion constructor
    }
}
