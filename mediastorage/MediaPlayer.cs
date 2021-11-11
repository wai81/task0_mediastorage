using MediaStorage.Classes;
using MediaStorage.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediaStorage
{
    public class MediaPlayer : IMediaPlayer
    {
        
        public void Plаy(IPlayList playList)
        {
            foreach (var item in playList.GetMediaItems())
            {
                item.Play();
            }
        }

        public void Plаy(BaseMedia item)
        {
            item.Play();
        }

        
        public void Stop(BaseMedia item)
        {
            item.Stop();
        }
    }
}
