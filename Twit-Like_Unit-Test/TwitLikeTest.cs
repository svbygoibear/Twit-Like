using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TwitCore.Models;
using System.IO;
using TwitCore.Helpers;

namespace Twit_Like_Unit_Test {
    [TestClass]
    public class TwitLikeTest {
        [TestMethod]
        public void TestUserFileRead() {
            var userFile = new TextFile("user", @"C:\Users\Simone\Desktop\TestFiles\user.txt", ".txt");
            var actualResult = userFile.ReadFileAsBase64();
            var expectedResult = "V2FyZCBmb2xsb3dzIEFsYW4NCkFsYW4gZm9sbG93cyBNYXJ0aW4NCldhcmQgZm9sbG93cyBNYXJ0aW4sIEFsYW4NCg==";
            Assert.AreEqual<string>(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestTweetFileRead() {
            var userFile = new TextFile("tweet", @"C:\Users\Simone\Desktop\TestFiles\tweet.txt", ".txt");
            var actualResult = userFile.ReadFileAsBase64();
            var expectedResult = "QWxhbj4gSWYgeW91IGhhdmUgYSBwcm9jZWR1cmUgd2l0aCAxMCBwYXJhbWV0ZXJzLCB5b3UgcHJvYmFibHkgbWlzc2VkIHNvbWUuDQpXYXJkPiBUaGVyZSBhcmUgb25seSB0d28gaGFyZCB0aGluZ3MgaW4gQ29tcHV0ZXIgU2NpZW5jZTogY2FjaGUgaW52YWxpZGF0aW9uLCBuYW1pbmcgdGhpbmdzIGFuZCBvZmYtYnktMSBlcnJvcnMuDQpBbGFuPiBSYW5kb20gbnVtYmVycyBzaG91bGQgbm90IGJlIGdlbmVyYXRlZCB3aXRoIGEgbWV0aG9kIGNob3NlbiBhdCByYW5kb20uDQo=";
            Assert.AreEqual<string>(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestListRead() {
            var userFile = new TextFile("tweet", @"C:\Users\Simone\Desktop\TestFiles\tweet.txt", ".txt");
            var actualResult = userFile.ReadFileToList();
        }

        [TestMethod]
        public void TestUsersInit() {
            var userFile = new TextFile("user", @"C:\Users\Simone\Desktop\TestFiles\user.txt", ".txt");
            var actualResult = userFile.UsersInit();
        }

        [TestMethod]
        public void TestTweetsInit() {
            var tweetFile = new TextFile("tweet", @"C:\Users\Simone\Desktop\TestFiles\tweet.txt", ".txt");
            var actualResult = tweetFile.TweetsInit();
        }
    }
}
