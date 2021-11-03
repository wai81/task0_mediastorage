using System;
using System.Collections.Generic;
using System.Text;

namespace mediastorage
{
    public class PlayList 
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
            throw new System.NotImplementedException();
        }

        public List<PlayList> SeachPlayList(string name )
        {
            throw new System.NotImplementedException();
        }



    }
}