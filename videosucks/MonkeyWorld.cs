using System;
using System.Collections.Generic;
using System.Text;

namespace videosucks
{
    public class MonkeyWorld
    {
        public string Name { get; set; }
        public string Info { get; set; }
        public string GoTo { get; set; }
        public string ImageUrl { get; set; }


        public override string ToString()
        {
            return Name;
        }
    }
}
