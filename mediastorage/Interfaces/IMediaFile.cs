using MediaStorage.Classes;
using MediaStorage.Enums;
using System.Collections.Generic;

namespace MediaStorage.Interfaces
{
    public interface IMediaFile
    {
        MediaFile AddFile(string nameFile);

        List<MediaFile> GetAllFiles();

        List<MediaFile> GetListByTypeFile(MediaCategory category);

        void PlayFile(MediaFile file);

        void RemoveFile(MediaFile file);

        List<PlayList> SeachFile(string name);
    }
}