using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02_Lab_06_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Song s1 = new Song("Tajdar-e-Haram", "Naat");
            Song s2 = new Song("Tu kuja man kuja", "Qawali");
            Song s3 = new Song("SabzGunbad", "Naat");
            PlayList List1 = new PlayList(" NaatCollection");
            List1.AddSong(s1);
            List1.AddSong(s2);
            List1.AddSong(s3);
            Console.WriteLine($" The Name of PlayList is: {List1.GetName()}");
            List<Song> PlaySongs = new List<Song>();
            PlaySongs = List1.GetSongs();
            Console.Write(" Songs in PlayList are: ");
            foreach (Song s in PlaySongs)
            {
                Console.Write($"{s.GetSongName()} , ");
            }
            Console.Write("\n");
            List1.SetName("Naat Supreme Collection");
            PlaySongs[1].SetSongName("Ae Raahe Haq ke Shaheedo");
            PlaySongs[1].SetSongType("Milli Naghma");
            Console.WriteLine($" The Name of PlayList is: {List1.GetName()}");
            Console.Write(" Songs in PlayList are: ");
            foreach (Song s in PlaySongs)
            {
                Console.Write($"{s.GetSongName()} , ");
            }
            Console.ReadKey();
        }
    }
}
