using System;

namespace MediaStorage.Classes.MediaFile
{
    public class MusicFile : BaseMedia
    {
        public MusicFile(string nameFile) : base(nameFile)
        {
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