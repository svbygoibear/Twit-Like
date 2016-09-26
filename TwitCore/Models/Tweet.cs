using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwitCore.Models{
    /// <summary>
    /// 
    /// </summary>
    public class Tweet {
        private long dateTServer;
        private long dateTUser;
        private string message;

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
    }
}
