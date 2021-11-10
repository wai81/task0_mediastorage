using MediaStorage.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediaStorage
{
    abstract class MediaPlaye : IMediaPlayer
    {
                       
        public Mediateka Media { get; set; }

        public Mediateka Play(string file)
        {
            throw new NotImplementedException();
        }

        public void Play(Mediateka item)
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
