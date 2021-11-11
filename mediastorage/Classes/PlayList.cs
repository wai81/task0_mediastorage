using System;
using System.Collections.Generic;

namespace MediaStorage.Classes
{
    public class PlayList : IPlayList
    {
        public Guid Id { get; private set; }
        public string Name { get; set; }
        public List<BaseMedia> Items { get; private set; }

        public PlayList(string name)
        {
            Name = name;
            Items = new List<BaseMedia>();
        }

        public void AddItem(BaseMedia item)
        {
            Items.Add(item);
        }

        public void RemoveItem(BaseMedia item)
        {
            Items.Remove(item);
        }

        public List<BaseMedia> GetMediaItems()
        {
            return Items;
        }

        public PlayList SeachPlayListByName(string name)
        {
            throw new NotImplementedException();
        }

        public BaseMedia SeachItemByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}