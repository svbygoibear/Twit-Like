using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using TwitCore.Interfaces;
using TwitCore.Helpers;

namespace TwitCore.Models {
    /// <summary>
    /// File type which will be used for reading in tweets for the console application
    /// </summary>
    public class TextFile : IFile {
        #region fields
        private string extension;
        private string fileName;
        private string path;
        #endregion fields

        #region properties
        public string Extension {
            get { return extension; }
            set { extension = value; }
        }

        public string FileName {
            get { return fileName; }
            set { fileName = value; }
        }

        public string Path {
            get { return path; }
            set { path = value; }
        }
        #endregion properties

        #region constructor
        public TextFile() { }

        public TextFile(string fileName, string path, string extension) {
            this.Extension = extension;
            this.FileName = fileName;
            this.Path = path;
        }
        #endregion constructor

        #region public methods
        /// <summary>
        /// Reads from a text file and returns a base64 string
        /// </summary>
        /// <returns>Base64 string</returns>
        public string ReadFileAsBase64() {
            if (this.path == null || this.path.Length == 0)
                throw new ArgumentNullException("TextFile.path");
            return System.Text.Encoding.UTF8.EncodeBase64(ReadFile());
        }
        #endregion public methods

        #region private methods
        /// <summary>
        /// Reads a file using a stream reader
        /// </summary>
        /// <returns>File as a string</returns>
        private string ReadFile() {
            string result = String.Empty;
            using (StreamReader sr = new StreamReader(this.path))
                result = sr.ReadToEnd();
            return result;
        }
        #endregion private methods
    }
}
