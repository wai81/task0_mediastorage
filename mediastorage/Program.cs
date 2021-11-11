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

            BaseMedia file1 = new ImageFile(nameFile: "image_01.jpg");
            BaseMedia file2 = new MusicFile(nameFile: "01_Rammstein_Muter.mp3");
            BaseMedia file3 = new MusicFile(nameFile: "03_Rammstein_Duhastmish.mp3");
            BaseMedia file4 = new MusicFile(nameFile: "04_Rammstein_Ich_Will.mp3");
            BaseMedia file5 = new VideoFile(nameFile: "House_s1_01.avi");

            IPlayList playList1 = new PlayList(name: "New playlist");

            playList1.AddItem(file4);
            playList1.AddItem(file3);
            playList1.AddItem(file2);

            IMediaPlayer player = new MediaPlayer();

            player.Paly(playList1);

            player.Paly(file5);

        }
    }
}
