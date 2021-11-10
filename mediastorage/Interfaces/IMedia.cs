using MediaStorage.Classes;
using MediaStorage.Enums;
using System.Collections.Generic;
using System.IO;

namespace MediaStorage.Interfaces
{
    public interface IMedia
    {
        List<ImageFile> ImageFile { get; }
        List<MusicFile> MusicFile { get; }
        List<PlayList> PlayList { get; }
        List<VideoFile> VideoFile { get; }

        void AddMediaFile(string item);
        List<PlayList> AddPlayList(PlayList playList);
        void DeleteMediaFile(string item);
        List<PlayList> DelitePlayList(PlayList playList);
        MediaCategory GetTypeFile(FileInfo file);
        List<Media> SearhByName(string name);
    }
}