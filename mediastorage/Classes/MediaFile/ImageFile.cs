using System;
using System.Collections.Generic;
using System.Text;

namespace MediaStorage.Classes.MediaFile
{
    public class ImageFile : BaseMedia
    {
        public ImageFile(Guid id, string nameFile) : base(id, nameFile)
        {

        }

        public override void Play()
        {
            Console.WriteLine($"Viewe image file: {NameFile}");
        }
    }
}
