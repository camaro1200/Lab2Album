using System;
using System.Collections.Generic;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Artist ImagineDragons = new Artist("ImagineDragons");
            Album origins = new Album("origins", 2018, "Rock", "Aternative Rock");
            Album nightVision = new Album("nightVisions", 2012, "Rock", "Indie Rock");

            Track t1 = new Track("ImagineDragons", "origins", "Natural" );
            Track t2 = new Track("ImagineDragons", "origins", "Boomerang");
            Track t3 = new Track("ImagineDragons", "origins", "Machine");
            Track t4 = new Track("ImagineDragons", "origins", "Machine");

            origins.addTrack(t1);
            origins.addTrack(t2);
            origins.addTrack(t3);
            origins.addTrack(t4);
            
            ImagineDragons.AddAlbum(origins);
            
            Track t5 = new Track("ImagineDragons", "nightVisions", "Radioactive");
            Track t6 = new Track("ImagineDragons", "nightVisions", "Tiptoe");
            Track t7 = new Track("ImagineDragons", "nightVisions", "Demons");
            Track t8 = new Track("ImagineDragons", "nightVisions", "Amsterdam");

            nightVision.addTrack(t5);
            nightVision.addTrack(t6);
            nightVision.addTrack(t7);
            nightVision.addTrack(t8);
            
            ImagineDragons.AddAlbum(nightVision);
            
            Artist PostMelone = new Artist("Post Melone");
            Album stoney = new Album("Stoney", 2012, "Rock", "PopRock");

            Track t9 = new Track("Post Melone", "Stoney", "White Iverson");
            Track t10 = new Track("Post Melone", "Stoney", "I Fall Apart");
            Track t11 = new Track("Post Melone", "Stoney", "Go Flex");
            Track t12 = new Track("Post Melone", "Stoney", "Congratulations");

            stoney.addTrack(t9);
            stoney.addTrack(t10);
            stoney.addTrack(t11);
            stoney.addTrack(t12);
            
            PostMelone.AddAlbum(stoney);

            Collection playlist = new Collection("MyPlaylist");
            playlist.addArtist(ImagineDragons);
            playlist.addArtist(PostMelone);

            Query q = new Query();
            q.search(c: playlist, gen: "");
            //q.searchRock(playlist, "PopRock");

        }
    }
}