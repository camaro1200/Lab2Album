using System.Collections.Generic;
using System;
using System.ComponentModel;

namespace Lab2

{
    public class Album
    {
        public string name;
        public int year;

        public List<Tuple<string, string>> t6 =new List<Tuple<string, string>>();

        public Album(string name, int year, string gen, string subgen)
        {
            this.name = name;
            this.year = year;

            add(gen,subgen);
        }
        
        public void add(string a, string b)
        {
            t6.Add(Tuple.Create(a,b));
        } 

        public List<Track> AlbumArray = new List<Track>();

        public void addTrack(Track x)
        {
            AlbumArray.Add(x);
        }

        public List<Track> getAlbulm()
        {
            return AlbumArray;
        }

        public void displayAlbum()
        {
            foreach (Track x in AlbumArray)
            {
                Console.WriteLine(x.ToString());
            }
        }

    }
}