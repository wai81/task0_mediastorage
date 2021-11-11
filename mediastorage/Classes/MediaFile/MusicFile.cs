using System;

namespace MediaStorage.Classes.MediaFile
{
    public class MusicFile : BaseMedia
    {
        public string Artist { get; protected set; }
        public string Genre { get; protected set; }

        public MusicFile(string nameFile, string artist, string genre) : base(nameFile)
        {
            Artist = artist;
            Genre = genre;
        }

        public override void Play()
        {
            Console.WriteLine($"Play music file: {NameFile}");
        }

        public override void Stop()
        {
            Console.WriteLine($"Stop play music file: {NameFile}");
        }
    }
}