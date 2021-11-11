using MediaStorage.Classes;

namespace MediaStorage.Interfaces
{
    interface IMediaPlayer
    {
        void Paly(IPlayList playList);

        void Paly(BaseMedia item);

        void Stop();
    }
}