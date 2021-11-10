using MediaStorage.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediaStorage
{
    abstract class MediaPlaye : IMediaPlayer
    {
                       
        public IMedia Media { get; set; }

        public  IMedia Play(string file)
        {
            throw new NotImplementedException();
        }

        public void Play(IMedia item)
        {
            throw new NotImplementedException();
        }

        public void Play()
        {
            throw new NotImplementedException();
        }

        public void Pause() 
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
