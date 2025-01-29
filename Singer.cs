using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikafyMusicPlatform
{
    internal class Singer
    {
        public string Name { get; set; }
        public string MusicGenre { get; set; }
        public int DebutYear { get; set; }
        public int AlbumSales { get; set; }

        public Singer(string name, string musicGenre, int debutYear, int albumSales)
        {
            Name = name;
            MusicGenre = musicGenre;
            DebutYear = debutYear;
            AlbumSales = albumSales;
        }
        override public string ToString()
        {
            return $"Name: {Name}\nMusic Genre: {MusicGenre}\nDebut Year: {DebutYear}\nAlbum Sales: {AlbumSales}";
        }

    }
}
