using System.Collections.Generic;
using System;
using System.ComponentModel.Design;

namespace Lab2
{
    public class Query
    {
        private int flag = 0;

        public void searchRock(Collection c, string gen)
        {
            foreach (Artist x in c.CollectionArray)
            {
                List<Album> copyArtistArray = new List<Album>(x.getArtist());
                foreach (Album y in copyArtistArray)
                {
                    if (gen == y.t6[0].Item1 || gen == y.t6[0].Item2 || gen == "all")
                    {
                        y.displayAlbum();
                    }
                }
            }
        }
        public void search(Collection c, string searchArtist = "all", string albumName = "all", string gen = "all", int? year = null,  string track = "all")
        {
            foreach (Artist x in c.CollectionArray)
            {
                if (x.artist == searchArtist || searchArtist == "all")
                {
                    List<Album> copyArtistArray1 = new List<Album>(x.getArtist());
                    foreach (Album y in copyArtistArray1)
                    {
                        if ((y.name == albumName || albumName == "all") &&  (y.year == year || year == null) && (gen == y.t6[0].Item1 || gen == y.t6[0].Item2 || gen == "all"))
                        {
                            List<Track> copyTrackArray1 = new List<Track>(y.getAlbulm());
                            foreach (Track z in copyTrackArray1)
                            {
                                if (z.song == track || track == "all")
                                {
                                    z.displayTrack();
                                    flag = 1;
                                }
                            }
                        }
                    }
                }
            }
            if(flag == 0)
                Console.WriteLine("no such query");
        }
    }
}