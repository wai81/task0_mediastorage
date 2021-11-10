using MediaStorage.Enums;
using System.IO;

namespace MediaStorage.Classes.MediaFile
{
    public class MusicFile : BaseMedia
    {
        public MusicFile(string nameFile)
        {
            NameFile = nameFile;
        }
    }
}