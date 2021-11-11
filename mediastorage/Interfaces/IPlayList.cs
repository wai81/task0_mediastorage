using System.Collections.Generic;

namespace MediaStorage.Classes
{
    public interface IPlayList
    {
        void AddItem(BaseMedia item);
        List<BaseMedia> GetMediaItems();
        void RemoveItem(BaseMedia item);
        BaseMedia SeachItemByName(string name);
        PlayList SeachPlayListByName(string name);
    }
}