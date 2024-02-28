using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02_Lab_06_
{
    internal class PlayList
    {
        private string PlayListName;
        private List<Song> Songs = new List<Song>();

        public PlayList(string name)
        {
            this.PlayListName = name;
        }
        public void AddSong(Song song)
        {
            Songs.Add(song);
        }
        public void SetName(string playlistname)
        {
            this.PlayListName = playlistname;
        }
        public string GetName()
        {
            return this.PlayListName;
        }
        public List<Song> GetSongs()
        {
            return this.Songs;
        }
    }
}
