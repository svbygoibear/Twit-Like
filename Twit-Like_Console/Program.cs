using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TwitCore.Helpers;
using TwitCore.Models;

namespace Twit_Like_Console {
    class Program {
        static void Main(string[] args) {
            var userFile = new TextFile("user", @"C:\Users\Simone\Desktop\TestFiles\user.txt", ".txt");
            var uf = userFile.UsersInit();

            var tweetFile = new TextFile("tweet", @"C:\Users\Simone\Desktop\TestFiles\tweet.txt", ".txt");
            var tf = tweetFile.TweetsInit();

            uf.ForEach(user => {
                Console.WriteLine(user);
                var test = user as User;
                tf.ForEach(tweet => {
                    if(tweet.UserHandle == user.Handle)
                        Console.WriteLine(tweet);

                    if((user as User).Following != null)
                        if((user as User).Following.Find(x => x.Handle == tweet.UserHandle) != null)
                            Console.WriteLine(tweet);
                });
                Console.WriteLine();
            });

            Console.ReadLine();
        }
    }
}
