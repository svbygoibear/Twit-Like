using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwitCore.Interfaces {
    public interface IPerson { //used to define any person in the twitter-like system
        String Name { get; set; }
        String Surname { get; set; }
    }
}
