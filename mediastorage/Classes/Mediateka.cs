using MediaStorage.Interfaces;
using System;
using System.Collections.Generic;

namespace MediaStorage.Classes
{
    public class Mediateka : IMediateka
    {
        public List<BaseMedia> MediaFiles { get; private set; } = new List<BaseMedia>();
        public List<IPlayList> PlayLists { get; private set; } = new List<IPlayList>();

        public Mediateka()
        {
            
        }

        public Mediateka(List<BaseMedia> mediaFiles)
        {
            MediaFiles = mediaFiles;
        }

        public Mediateka(List<IPlayList> playLists)
        {
            PlayLists = playLists;
        }

        public void AddFile(BaseMedia file)
        {
            MediaFiles.Add(file);
        }

        public void AddPlayList(IPlayList playList)
        {
            PlayLists.Add(playList);
        }

        public void RemoveFile(BaseMedia file)
        {
            MediaFiles.Remove(file);
        }

        public void RemovePlayList(IPlayList playList)
        {
            PlayLists.Remove(playList);
        }

        public BaseMedia SeachFileByName(string name)
        {
            throw new NotImplementedException();
        }

        public IPlayList SeachPlayListByName(string name)
        {
            throw new NotImplementedException();
        }

        public void Stop(BaseMedia item)
        {
            IMediaPlayer player = new MediaPlayer();
            player.Stop(item);
        }

        public void Plаy(BaseMedia item)
        {
            IMediaPlayer player = new MediaPlayer();
            player.Plаy(item);
        }

        public void Plаy(IPlayList playList)
        {
            IMediaPlayer player = new MediaPlayer();
            player.Plаy(playList);
        }
    }
}

