using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TwitCore.Models;

namespace TwitCore.Helpers {
    /// <summary>
    /// Helper used to help analyse the user.txt file
    /// </summary>
    public static class UserAnalyser {
        public static string UserInit(this TextFile file) {
            return file.ReadFileAsBase64();
        }
    }
}
