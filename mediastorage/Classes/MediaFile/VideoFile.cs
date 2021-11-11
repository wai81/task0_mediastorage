using System;

namespace MediaStorage.Classes.MediaFile
{
    public class VideoFile : BaseMedia
    {
        public string YearProduction { get; private set; }
        public string Country { get; private set; }
        public string Genre { get; private set; }

        public VideoFile(string nameFile, string year, string country, string genre) : base(nameFile)
        {
            YearProduction = year;
            Country = country;
            Genre = genre;
        }

        public override void Play()
        {
            Console.WriteLine($"Watch video file: {NameFile}");
        }

        public override void Stop()
        {
            Console.WriteLine($"Stop play video file: {NameFile}");
        }
    }
}