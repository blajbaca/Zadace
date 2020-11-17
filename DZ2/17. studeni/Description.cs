using System;

namespace _17._studeni
{
    class Description
    {
        public int episodeNumber;
        public TimeSpan length;
        public string name;

        public Description() { }
        public Description(int episodeNumber, TimeSpan length, string name)
        {
            this.episodeNumber = episodeNumber;
            this.length = length;
            this.name = name;
        }
    }
}
