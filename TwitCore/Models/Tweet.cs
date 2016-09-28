using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwitCore.Models{
    /// <summary>
    /// Represents an actual tweet from a user
    /// </summary>
    public class Tweet {
        #region fields
        private long dateTServer;
        private long dateTUser;
        private string message;
        private string userHandle;
        #endregion fields

        #region properties
        public string UserHandle {
            get { return userHandle; }
            set { userHandle = value; }
        }

        public string Message {
            get { return message; }
            set { message = value; }
        }

        public long DateTUser {
            get { return dateTUser; }
            set { dateTUser = value; }
        } 

        public long DateTServer {
            get { return dateTServer; }
            set { dateTServer = value; }
        }
        #endregion properties

        #region constructor
        public Tweet(long dateTServer, long dateTUser, string message, string userHandle) {
            this.DateTServer = dateTServer;
            this.DateTUser = dateTUser;
            this.Message = message;
            this.UserHandle = userHandle;
        }
        #endregion constructor

        #region public methods
        public override string ToString() {
            return string.Format("@{0}: {1}", userHandle, message);
        }
        #endregion public methods
    }
}
