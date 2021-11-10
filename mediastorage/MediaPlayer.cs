using MediaStorage.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediaStorage
{
    abstract class MediaPlayer 
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
