using MediaStorage.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MediaStorage.Classes.MediaFile
{
    public class VideoFile : BaseMedia
    {
        public VideoFile(Guid id, string nameFile) : base(id, nameFile)
        {
        }

        public override void Play()
        {
            Console.WriteLine($"Viewe video file: {NameFile}");
        }
    }
}