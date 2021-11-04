using MediaStorage.Classes;
using System;
using System.Collections.Generic;

namespace MediaStorage.Interfaces
{
    public interface IPlayList
    {
        PlayList AddItem(PlayListItems item, PlayList playList);

        List<PlayList> GetAllPlayLists();

        PlayList RemoveItem(PlayListItems item, PlayList playList);

        void RunPlayList(PlayList playList);

        List<PlayList> SeachPlayListByName(string name);
    }
}