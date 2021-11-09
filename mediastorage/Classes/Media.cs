using MediaStorage.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MediaStorage.Classes
{
    public class Media
    {
        public List<PlayList> PlayList { get; private set; }

        public List<VideoFile> VideoFile { get; private set; }

        public List<ImageFile> ImageFile { get; private set; }

        public List<MusicFile> MusicFile { get; private set; }


        public MediaCategory GetTypeFile(FileInfo file)
        {
            string typeFile = file.Extension.ToLower();

            if (typeFile == ".mp3" || typeFile == ".wav")
            {
                return MediaCategory.Music;
            }
            else if (typeFile == ".jpg" || typeFile == ".png" || typeFile == ".jpeg")
            {
                return MediaCategory.Image;
            }
            else if (typeFile == ".avi" || typeFile == ".mpg" || typeFile == ".mp4")
            {
                return MediaCategory.Movie;
            }
            else
                return MediaCategory.Unknown;
        }

        public void AddMediaFile (string item)
        {
            var File = new FileInfo(item);

            MediaCategory category = GetTypeFile(File);

            if (category == MediaCategory.Image)
            {
                throw new NotImplementedException();
            }
            else if (category == MediaCategory.Movie)
            {
                throw new NotImplementedException();
            }
            else if (category == MediaCategory.Music)
            {
                throw new NotImplementedException();
            }
            else
                throw new NotImplementedException();
            
        }

        public void DeleteMediaFile(string item)
        {

        }

        public List<PlayList> AddPlayList(PlayList playList)
        {
            throw new NotImplementedException();
        }

        public List<PlayList> DelitePlayList(PlayList playList)
        {
            throw new NotImplementedException();
        }

        public List<Media> SearhByName(string name)
        {
            throw new NotImplementedException();
        }

    }
}
