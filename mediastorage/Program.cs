using mediastorage.Classes;
using System;

namespace mediastorage
{
    class Program
    {
        static void Main(string[] args)
        {
            MediaFile music = new MediaFile(nameFile:"Song.mp3");
            MediaFile image = new MediaFile(nameFile: "Image.jpeg");
            MediaFile video = new MediaFile(nameFile: "Film.avi");

            Console.WriteLine(music.TypeFile);
            Console.WriteLine(image.TypeFile);
            Console.WriteLine(video.TypeFile);

            PlayList pl = new PlayList(name: "My play list");

            Console.WriteLine(pl.Name);

            Console.ReadLine();

            
        }
    }
}
