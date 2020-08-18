using System.Collections.Generic;
using System;
namespace Lab2
{
    public class Track
    {
        public string artistName;
        public string albumName;
        public string song;
       
        public Track(string artistName, string albumName, string song)
        {
            this.artistName = artistName;
            this.albumName = albumName;
            this.song = song;
        }

        public void displayTrack()
        {
            Console.WriteLine(artistName + " " + albumName +  " " + song);
    }
            
        public override string ToString()
        {
            return $"{artistName}-{albumName}-{song}";
        }
    }
}