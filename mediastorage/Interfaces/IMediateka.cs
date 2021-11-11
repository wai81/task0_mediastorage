﻿using System.Collections.Generic;

namespace MediaStorage.Classes
{
    public interface IMediateka
    {
       
        void AddFile(BaseMedia file);
        void AddPlayList(IPlayList playList);
        void Paly(BaseMedia item);
        void Paly(IPlayList playList);
        void RemoveFile(BaseMedia file);
        void RemovePlayList(IPlayList playList);
        BaseMedia SeachFileByName(string name);
        IPlayList SeachPlayListByName(string name);
        void Stop();
    }
}