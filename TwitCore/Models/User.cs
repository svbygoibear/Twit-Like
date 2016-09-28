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
        private string handle;
        private TimeZone timeZone;
        private List<Tweet> tweets;
        private List<IPerson> following;
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

        public List<IPerson> Following {
            get { return following; }
            set { following = value; }
        }

        public string Handle {
            get { return handle; }
            set { handle = value; }
        }
        #endregion properties

        #region constructor
        public User() { }

        public User(string handle, List<IPerson> following) {
            this.Handle = handle;
            this.Following = following;
        }
        #endregion constructor

        #region public methods
        public override string ToString() {
            return string.Format("{0}", this.Handle);
        }
        #endregion public methods
    }
}
