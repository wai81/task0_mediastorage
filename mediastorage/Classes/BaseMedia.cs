using System;

namespace MediaStorage.Classes
{
    public abstract class BaseMedia

    {
        public Guid Id { get; private set; }

        public string NameFile { get; set; }

        public BaseMedia(Guid id, string nameFile)
        {
            Id = id;
            NameFile = nameFile;
        }

        public abstract void Play();        
    }
   
}