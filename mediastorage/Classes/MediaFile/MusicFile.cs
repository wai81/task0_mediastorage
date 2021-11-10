using MediaStorage.Enums;
using System;
using System.IO;

namespace MediaStorage.Classes.MediaFile
{
    public class MusicFile : BaseMedia
    {
        public MusicFile(Guid id, string nameFile) : base(id, nameFile)
        {
        }

        public override void Play()
        {
            Console.WriteLine($"Play music file: {NameFile}");
        }
    }
}