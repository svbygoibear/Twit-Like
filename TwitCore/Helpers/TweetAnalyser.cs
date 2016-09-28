using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TwitCore.Models;

namespace TwitCore.Helpers {
    /// <summary>
    /// A helper used to analyse the tweet.txt file
    /// </summary>
    public static class TweetAnalyser {
        public static List<Tweet> TweetsInit(this TextFile file) {
            file.ReadFileToList().ForEach(line => {
                var tStartEnd = line.GetStartEnd(">");
                if (tStartEnd.Item1 != 0 && tStartEnd.Item2 != 0) {
                    var userHandle = line.Substring(0, tStartEnd.Item1).Trim(' ');
                    var userFollowers = line.Substring(tStartEnd.Item2).Split(',');

                }
            });

            return new List<Tweet>();
        }
    }
}
