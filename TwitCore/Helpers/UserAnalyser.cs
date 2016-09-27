using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TwitCore.Interfaces;
using TwitCore.Models;

namespace TwitCore.Helpers {
    /// <summary>
    /// Helper used to help analyse the user.txt file
    /// </summary>
    public static class UserAnalyser {
        /// <summary>
        /// This method is used to initialise all the users from the initial text file.
        /// </summary>
        /// <param name="file">Text File.</param>
        /// <returns>List of all the users.</returns>
        public static List<IPerson> UsersInit(this TextFile file) {
            var result = new List<IPerson>();
            file.ReadFileToList().ForEach(line => {
                var fStartEnd = GetStartEnd(line, "follows");
                if (fStartEnd.Item1 != 0 && fStartEnd.Item2 != 0) {
                    var handle = line.Substring(0, fStartEnd.Item1).Trim(' ');
                    var userFollowers = line.Substring(fStartEnd.Item2).Split(',').ToList();
                    AddUser(result, handle, userFollowers);
                }
            });
            return result;
        }

        /// <summary>
        /// Adds a new user to the list of users.
        /// </summary>
        /// <param name="users">A list of all the users.</param>
        /// <param name="userHandle">Handle of the user you would like to add.</param>
        /// <param name="userFollowers">A list of string from the text file with potential followers.</param>
        public static void AddUser(List<IPerson> users, string userHandle, List<String> userFollowers) {
            if(CheckIfUserExists(users, userHandle) == true) {
                var currentUser = users.Cast<User>().GetExistingUser(userHandle);
                currentUser.Following.AddFollowers(userFollowers);
            }
            else {
                var followers = new List<IPerson>();
                followers.AddFollowers(userFollowers);
                users.Add(new User(userHandle, followers));
            }
        }

        /// <summary>
        /// Adds followers to an existing list of followers.
        /// </summary>
        /// <param name="followers">A list of all the current followers.</param>
        /// <param name="newFollowers">A list of new followers.</param>
        public static void AddFollowers(this List<IPerson> followers, List<String> newFollowers) {
            newFollowers.ForEach(uf => {
                uf = uf.Trim(' ');
                followers.AddFollower(uf);
            });
        }

        /// <summary>
        /// This used to get the existing user from a list of users.
        /// </summary>
        /// <param name="users">IEnumerable of user.</param>
        /// <param name="userHandle">The user handle that should be used to extract the user from the collection.</param>
        /// <returns></returns>
        public static User GetExistingUser(this IEnumerable<User> users, String userHandle) {
            var result = new User();
            foreach(var user in users) {
                if (user.Handle == userHandle)
                    result = user;
            }
            return result;
        }

        /// <summary>
        /// Can be used for followers or users - checks if a string handle already exists in a list.
        /// </summary>
        /// <param name="users">List of the users/followers.</param>
        /// <param name="handle">The handle to be checked against.</param>
        /// <returns></returns>
        public static bool CheckIfUserExists(this List<IPerson> users, string handle) {
            var result = false;
            users.ForEach(user => {
                if (user.Handle == handle) 
                    result = true;
            });
            return result;
        }

        /// <summary>
        /// Checks if a follower exists in an existing list of followers - if not then the follower is added.
        /// </summary>
        /// <param name="followers">List of all the followers for a user.</param>
        /// <param name="followerHandle">Handle of the follower to be added.</param>
        public static void AddFollower(this List<IPerson> followers, string followerHandle) {
            if (followers.CheckIfUserExists(followerHandle) == false)
                followers.Add(new User(followerHandle, null));
        }

        /// <summary>
        /// This is used to determine the start and end index of a word in a string.
        /// </summary>
        /// <param name="Text">String to find the word in.</param>
        /// <param name="Keyword">Keyword to look for in the string.</param>
        /// <returns>Returns a tuple with the start and end index of the keyword.</returns>
        public static Tuple<int, int> GetStartEnd(string Text, string Keyword) {
            var start = Text.IndexOf(Keyword);
            if (start > -1)
                return new Tuple<int, int>(start, Keyword.Length + start);
            else
                return new Tuple<int, int>(0, 0);
        }
    }
}
