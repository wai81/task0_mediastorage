using System;
using System.Collections.Generic;
using System.Text;

namespace MediaStorage.Classes
{
    public class PlayList 
    {
        public Guid Id { get; private set; }

        public string Name { get; set; }

        public List<PlayListItem> Items { get; private set; }

        public PlayList(string name)
        {
            Name = name;
            Items = new List<PlayListItem>();
        }

        public List<PlayList> GetAllPlayLists()
        {
            throw new NotImplementedException();
        }

        public List<PlayList> SeachPlayListByName(string name)
        {
            throw new NotImplementedException();
        }

        public PlayList AddItem(PlayListItem item)
        {
            throw new NotImplementedException();
        }

        public PlayList RemoveItem(PlayListItem item)
        {
            throw new NotImplementedException();
        }

        public void RunPlayList(PlayList playList)
        {
            throw new NotImplementedException();
        }
    }
}