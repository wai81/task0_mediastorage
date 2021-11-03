using mediastorage.Classes;
using mediastorage.Enums;
using System.Collections.Generic;

namespace mediastorage.Interfaces
{
    public interface IMediaFile
    {
        MediaFile AddFile(string nameFile);
        
        List<MediaFile> GetAllFiles();
        
        List<MediaFile> GetListByTypeFile(Category category);
        
        void PlayFile(MediaFile file);
        
        void RemoveFile(MediaFile file);
        
        List<PlayList> SeachFile(string name);
    }
}