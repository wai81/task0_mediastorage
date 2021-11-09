using MediaStorage.Classes;
using MediaStorage.Enums;
using System.Collections.Generic;

namespace MediaStorage.Interfaces
{
    public interface IMediaFile
    {
        VideoFile AddFile(string nameFile);

        List<VideoFile> GetAllFiles();

        List<VideoFile> GetListByTypeFile(MediaCategory category);

        void PlayFile(VideoFile file);

        void RemoveFile(VideoFile file);

        List<PlayList> SeachFile(string name);
    }
}