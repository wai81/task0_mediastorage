using MediaStorage.Classes;
using MediaStorage.Classes.MediaFile;
using MediaStorage.Interfaces;
using System;

namespace MediaStorage
{
    class Program
    {
        static void Main(string[] args)
        {
            IMediateka mediateka = new Mediateka();
            
            BaseMedia file1 = new ImageFile(nameFile: "image_01.jpg", subject: "Nature", height: 1200, width: 720);
            BaseMedia file2 = new MusicFile(nameFile: "01_Rammstein_Muter.mp3", artist: "Rammstein",genre: "Industrial - metal");
            BaseMedia file3 = new MusicFile(nameFile: "03_Rammstein_Duhastmish.mp3", artist: "Rammstein", genre: "Industrial - metal");
            BaseMedia file4 = new MusicFile(nameFile: "04_Rammstein_Ich_Will.mp3", artist: "Rammstein", genre: "Industrial - metal");
            BaseMedia file5 = new VideoFile(nameFile: "House_s1_01.avi", year:"2010", country: "USA",  genre: "TV series");
            
            IPlayList playList1 = new PlayList(name: "New playlist");

            mediateka.AddPlayList(playList1);
            mediateka.AddFile(file1);

            playList1.AddItem(file4);
            playList1.AddItem(file3);
            playList1.AddItem(file2);

            IMediaPlayer player = new MediaPlayer();

            player.Plаy(playList1);
            player.Plаy(file5);

            Console.WriteLine("---Paly from Mediateka-------------");

            mediateka.Plаy(playList1);

            mediateka.Plаy(file1);
        }
    }
}
