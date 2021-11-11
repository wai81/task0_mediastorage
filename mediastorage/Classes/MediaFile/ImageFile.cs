using System;

namespace MediaStorage.Classes.MediaFile
{
    public class ImageFile : BaseMedia
    {
        public string Subject { get; protected set; }
        public int Width { get; protected set; }
        public int Height { get; protected set; }

        public ImageFile(string nameFile, string subject, int width, int height ) : base(nameFile)
        {
            Subject = subject;
            Width = width;
            Height = height;
        }

        public override void Play()
        {
            Console.WriteLine($"Viewe image file: {NameFile}");
        }

        public override void Stop()
        {
            Console.WriteLine($"Close image file: {NameFile}");
        }
    }
}
