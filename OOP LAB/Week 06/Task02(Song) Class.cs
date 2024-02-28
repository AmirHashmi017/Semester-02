using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02_Lab_06_
{
    internal class Song
    {
        private string SongName;
        private string SongType;

        public Song(string songName, string songType)
        {
            this.SongName = songName;
            this.SongType = songType;
        }
        public void SetSongName(string songName)
        {
            this.SongName = songName;
        }
        public void SetSongType(string songtype)
        {
            this.SongType = songtype;
        }
        public string GetSongName()
        {
            return this.SongName;
        }
        public string GetSongType()
        {
            return this.SongType;
        }
    }
}
