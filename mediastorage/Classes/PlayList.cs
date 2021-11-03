using mediastorage.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace mediastorage.Classes
{
    public class PlayList : IPlayList
    {
        public Guid Id { get; private set; }

        public string Name { get; set; }

        public ICollection<MediaFile> ItemsList { get; set; }

        public PlayList(string name)
        {
            Name = name;
            ItemsList = new List<MediaFile>();
        }

        public List<PlayList> GetAllPlayLists()
        {
            throw new NotImplementedException();
        }

        public List<PlayList> SeachPlayListByName(string name)
        {
            throw new NotImplementedException();
        }

        public PlayList AddItem(MediaFile item, PlayList playList)
        {
            throw new NotImplementedException();
        }

        public PlayList RemoveItem(MediaFile item, PlayList playList)
        {
            throw new NotImplementedException();
        }

        public void RunPlayList(PlayList playList)
        {
            throw new NotImplementedException();
        }


    }
}