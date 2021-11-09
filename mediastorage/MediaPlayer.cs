using MediaStorage.Classes;
using MediaStorage.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediaStorage
{
    public abstract class MediaPlayer
    {
        Media MediaList { get; set; }

        public MediaPlayer()
        {

        }

        public abstract IMediaFile Play(string file);

        //public abstract Pause();

        //public abstract Stop();

        //public virtual StepBackward()
        //{
        //    var seekTo =0;
        //    return seekTo;
        //}
    
    }
}
