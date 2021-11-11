using System;

namespace MediaStorage.Classes.MediaFile
{
    public class VideoFile : BaseMedia
    {
        public VideoFile(string nameFile) : base(nameFile)
        {
        }

        public override void Play()
        {
            Console.WriteLine($"Viewe video file: {NameFile}");
        }
    }
}