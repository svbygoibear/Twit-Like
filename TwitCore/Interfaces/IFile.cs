using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwitCore.Interfaces {
    public interface IFile { //used for any type of file such as .txt, .pdf, etc.
        String FileName { get; set; }
        String Path { get; set; }
        String Extension { get; set; }

        String ReadFileAsBase64();
    }
}
