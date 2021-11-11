using System;

namespace MediaStorage.Classes
{
    public abstract class BaseMedia

    {
        public Guid Id { get; private set; }

        public string NameFile { get; set; }

        public BaseMedia(string nameFile)
        {
            Id = new Guid();
            NameFile = nameFile;
        }

        public abstract void Play();
        public abstract void Stop();

    }
   
}