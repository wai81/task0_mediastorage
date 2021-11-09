using MediaStorage.Classes;
using System;
using System.Collections.Generic;

namespace MediaStorage.Interfaces
{
    public interface IPlayList
    {
        PlayList AddItem(PlayListItem item);

        List<PlayList> GetAllPlayLists();

        PlayList RemoveItem(PlayListItem item);

        List<PlayList> SeachPlayListByName(string name);
    }
}