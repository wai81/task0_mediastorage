using MediaStorage.Classes;
using System;

namespace MediaStorage
{
    class Program
    {
        static void Main(string[] args)
        {
            MediaFile music = new MediaFile(nameFile: "Song.mp3");
            MediaFile image = new MediaFile(nameFile: "Image.jpeg");
            MediaFile video = new MediaFile(nameFile: "Film.avi");

            Console.WriteLine(music.Category);
            Console.WriteLine(image.Category);
            Console.WriteLine(video.Category);

            PlayList pl = new PlayList(name: "My play list");

            Console.WriteLine(pl.Name);

            Console.ReadLine();
        }
    }
}
