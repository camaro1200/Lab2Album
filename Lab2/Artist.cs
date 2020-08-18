using System.Collections.Generic;
using System;
namespace Lab2
{
    public class Artist
    {
        public string artist;
        public Artist(string artist)   
        {
            this.artist = artist;
        }
            
        public List<Album> ArtistArray = new List<Album>();
            
        public void AddAlbum(Album x)
        {
            ArtistArray.Add(x);
        }

        public List<Album> getArtist()
        {
            return ArtistArray;
        }

        public void displayArtist()
        {
            foreach (Album x in ArtistArray)
            {
                x.displayAlbum();
            }
        }
    }
}