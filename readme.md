#Twit-Like
##Synopsis
So originally this comes from an assignment where I received two text files and I had to make a console application that simulates a twitter feed. I'll be extending on this as I get the time to and maybe use it to try out some micro services/ APIs in .NET. Exciting times!

##Code Example
###Assignment
Please write a program to simulate a twitter-like feed. Your program will receive two seven-bit ASCII files. The first file contains a list of users and their followers. The second file contains tweets. Given the users, followers and tweets, the objective is to display a simulated twitter feed for each user to the console.

The program should be well designed, handle errors and should be of sufficient quality to run on a production system. Indicate all assumptions made in completing the assignment.

Each line of a well-formed user file contains a user, followed by the word 'follows' and then a comma separated list of users they follow.  Where there is more than one entry for a user,  consider the union of all these entries to determine the users they follow.

Lines of the tweet file contain a user, followed by greater than, space and then a tweet that may be at most 140 characters in length. The tweets are considered to be posted by the each user in the order they are found in this file.

Your program needs to write console output as follows. For each user / follower (in alphabetical order) output their name on a line. Then for each tweet, emit a line with the following format: <tab>@user: <space>message.

Here is an example. Given user file named user.txt:

```
Ward follows Alan
Alan follows Martin
Ward follows Martin, Alan
```

And given tweet file named tweet.txt:

```
Alan> If you have a procedure with 10 parameters, you probably missed some.
Ward> There are only two hard things in Computer Science: cache invalidation, naming things and off-by-1 errors.
Alan> Random numbers should not be generated with a method chosen at random.
```

So invoking your program with user.txt and tweet.txt as arguments should produce the following console output:

```
Alan
@Alan: If you have a procedure with 10 parameters, you probably missed some.
@Alan: Random numbers should not be generated with a method chosen at random.
 
Martin
 
Ward
@Alan: If you have a procedure with 10 parameters, you probably missed some.
@Ward: There are only two hard things in Computer Science: cache invalidation, naming things and off-by-1 errors.
@Alan: Random numbers should not be generated with a method chosen at random.
```

###Deductions
From the instructions given, the following assumptions can be deducted from it:
- **users.txt**: The set of words - up until the keyword **follows** indicates a user. This collection of words/phrases/names are unique and if duplicates are found the data they contain should be added to the original.
- **users.txt**: Everything that follows after the **follows** keyword, is a comma seperated list of all the people that particular user follows.
- **users.txt**: For styling purposes, these user names can be left and right trimmed.
- **users.txt**: Following the above logic, a username will not contain a comma or be empty, but it can contain or exist of the word follows.
- **tweet.txt**: Here the person who is tweeting the the string character before the **>** sign - thus no username will contain a **>** sign or else it would be considered invalid.
- **tweet.txt**: Everything after the **>** forms part of a tweet, until it is escaped with a new line.
- Tweets will only be 140 characters and any tweets longer than that in the file will be cut off at the 140 character limit.
- You can only see your own tweets and the tweets of those you follow - as inidcated by the users.txt file.
- Lastly, invalid lines in either one of the text files can be ignored and should not be considered by the system.

###Code Snippet
There is two main parts to using the library (as seen in the example as per the console application), the first one is retrieving all the users and their followers:
```javascript
var userFile = new TextFile("user", @"C:\Users\UserName\Desktop\TestFiles\user.txt", ".txt");
var uf = userFile.UsersInit();
```

The other part being the tweet files, which can be accessed using:
```javascript
var tweetFile = new TextFile("tweet", @"C:\Users\UserName\Desktop\TestFiles\tweet.txt", ".txt");
var tf = tweetFile.TweetsInit();
```

##Installation
To run this app, you'll need .NET 4.5 or higher installed on your machine, and to open up the project file you'll need Visual Studio. Other than that, no installation required. Microsoft .NET Framework 4.5 can be installed by downloading it from the microsoft website.

##Contributors
Feel free to pop me a message or flag an issue if you come across it - I'll see what I can do about it.

##License

Copyright © `2016` `Simone van Buuren`

Permission is hereby granted, free of charge, to any person
obtaining a copy of this software and associated documentation
files (the “Software”), to deal in the Software without
restriction, including without limitation the rights to use,
copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the
Software is furnished to do so, subject to the following
conditions:

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
OTHER DEALINGS IN THE SOFTWARE.