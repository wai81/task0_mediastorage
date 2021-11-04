using MediaStorage.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediaStorage.Classes
{
    public class PlayList : IPlayList
    {
        public Guid Id { get; private set; }

        public string Name { get; set; }

        public List<PlayListItems> Items { get; private set; }

        public PlayList(string name)
        {
            Name = name;
            Items = new List<PlayListItems>();
        }

        public List<PlayList> GetAllPlayLists()
        {
            throw new NotImplementedException();
        }

        public List<PlayList> SeachPlayListByName(string name)
        {
            throw new NotImplementedException();
        }

        public PlayList AddItem(PlayListItems item, PlayList playList)
        {
            throw new NotImplementedException();
        }

        public PlayList RemoveItem(PlayListItems item, PlayList playList)
        {
            throw new NotImplementedException();
        }

        public void RunPlayList(PlayList playList)
        {
            throw new NotImplementedException();
        }
    }
}