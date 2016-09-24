using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TwitCore.Interfaces;

namespace TwitCore.Models {
    //File type which will be used for reading in tweets for the console application
    public class TextFile : IFile {
        private string extension;
        private string fileName;
        private string path;

        public string Extension {
            get { return extension; }
            set { extension = value; }
        }

        public string FileName {
            get { return fileName; }
            set { fileName = value; }
        }

        public string Path  {
            get { return path; }
            set { path = value; }
        }

        public TextFile() { }

        //public TextFile(string fileName, string path, string extension)
        //{
        //    this.E
        //}

        public string ReadFile(string fileName, string path, string extension) {
            throw new NotImplementedException();
        }
    }
}
