using MediaStorage.Classes;

namespace MediaStorage.Interfaces
{
    interface IMediaPlayer
    {
        void Plаy(IPlayList playList);
        void Plаy(BaseMedia item);
        void Stop(BaseMedia item);

    }
}