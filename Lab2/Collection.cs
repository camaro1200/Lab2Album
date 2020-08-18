using System.Collections.Generic;
using System;
namespace Lab2
{
    public class Collection
    {
        public string collectionName;

        public Collection(string collectionName)
        {
            this.collectionName = collectionName;
        }

            
        public List<Artist> CollectionArray = new List<Artist>();

        public void addArtist(Artist x)
        {
            CollectionArray.Add(x);
        }

        public List<Artist> getCollection()
        {
            return CollectionArray;
        }

        public void DisplayCollection()
        {
            foreach (Artist x in CollectionArray)
            {
                x.displayArtist();
            }
        }
    }
}