using MediaStorage.Classes;
using MediaStorage.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediaStorage
{
    public class MediaPlayer : IMediaPlayer
    {
        public void Paly(IPlayList playList)
        {
            foreach (var item in playList.GetMediaItems())
            {
                item.Play();
            }
        }

        public void Play(BaseMedia item)
        {
            item.Play();
        }

        public void Stop()
        {

        }
    }
}
