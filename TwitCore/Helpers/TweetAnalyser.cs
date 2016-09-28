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
            var result = new List<Tweet>();
            file.ReadFileToList().ForEach(line => {
                var tStartEnd = line.GetStartEnd(">");
                if (tStartEnd.Item1 != 0 && tStartEnd.Item2 != 0) {
                    var userHandle = line.Substring(0, tStartEnd.Item1).Trim(' ');
                    var message = line.Length <= 140 ? line.Substring(tStartEnd.Item2).Trim(' ') 
                        : line.Substring(tStartEnd.Item2, 140).Trim(' ') + "...";
                    result.Add(new Tweet(DateTime.Now.Ticks, 0, message, userHandle));
                }
            });
            return result;
        }
    }
}
