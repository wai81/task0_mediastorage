using System;
using System.Collections.Generic;
using System.Text;

namespace MediaStorage.Classes.MediaFile
{
    public class ImageFile : BaseMedia
    {
        public ImageFile(string nameFile) : base(nameFile)
        {

        }

        public override void Play()
        {
            Console.WriteLine($"Viewe image file: {NameFile}");
        }
    }
}
