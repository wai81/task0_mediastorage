using mediastorage.Classes;
using System;
using System.Collections.Generic;

namespace mediastorage.Interfaces
{
    public interface IPlayList
    {

        PlayList AddItem(MediaFile item, PlayList playList);
        
        List<PlayList> GetAllPlayLists();
        
        PlayList RemoveItem(MediaFile item, PlayList playList);
        
        void RunPlayList(PlayList playList);
        
        List<PlayList> SeachPlayListByName(string name);

    }
}