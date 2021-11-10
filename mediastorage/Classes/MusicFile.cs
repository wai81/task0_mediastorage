using MediaStorage.Enums;
using System.IO;

namespace MediaStorage.Classes
{
    public class MusicFile : BaseMedia
    {
        public MusicFile(string nameFile)
        {
            NameFile = nameFile;
        }
    }
}