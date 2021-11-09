using MediaStorage.Classes;
using System;

namespace MediaStorage
{
    class Program
    {
        static void Main(string[] args)
        {
            VideoFile music = new MediaFile(nameFile: "Song.mp3");
            VideoFile image = new MediaFile(nameFile: "Image.jpeg");
            VideoFile video = new MediaFile(nameFile: "Film.avi");

            Console.WriteLine(music.Category);
            Console.WriteLine(image.Category);
            Console.WriteLine(video.Category);

            PlayList pl = new PlayList(name: "My play list");



            Console.WriteLine(pl.Name);

            Console.ReadLine();
        }
    }
}
