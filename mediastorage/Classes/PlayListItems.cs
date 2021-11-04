using System;
using System.Collections.Generic;
using System.Text;

namespace MediaStorage.Classes
{
    public class PlayListItems : BaseMediaStorage
    {
        public MediaFile MediaFile { get; private set; }

        public PlayListItems(string nameFile, MediaFile file)
        {
            NameFile = nameFile;
            MediaFile = file;
        }


    }
}
