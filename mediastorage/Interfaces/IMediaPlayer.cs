using MediaStorage.Classes;

namespace MediaStorage.Interfaces
{
    interface IMediaPlayer
    {
        void Paly(IPlayList playList);
        void Play(BaseMedia item);
        void Stop();
    }
}