using MediaStorage.Classes.MediaFile;
using MediaStorage.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MediaStorage.Classes
{
    public class Mediateka 
    {
        public List<PlayList> PlayList { get; private set; } = new List<PlayList>();

        public List<VideoFile> VideoFileList { get; private set; } = new List<VideoFile>();

        public List<ImageFile> ImageFileList { get; private set; } = new List<ImageFile>();

        public List<MusicFile> MusicFileList { get; private set; } = new List<MusicFile>();


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

        public void AddMediaFile(string item)
        {
            var File = new FileInfo(item);

            MediaCategory category = GetTypeFile(File);

            if (category == MediaCategory.Image)
            {
                var mediaFile = AddImage(item);
                ImageFileList.Add(mediaFile);
            }
            else if (category == MediaCategory.Movie)
            {
                var mediaFile = AddImage(item);
                ImageFileList.Add(mediaFile);
            }
            else if (category == MediaCategory.Music)
            {
                var mediaFile = AddImage(item);
                ImageFileList.Add(mediaFile);
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

        public void DelitePlayList(PlayList playList)
        {
            throw new NotImplementedException();
        }

        public List<Mediateka> SearhByName(string name)
        {
            throw new NotImplementedException();
        }

        private ImageFile AddImage(string file)
        {
            ImageFile img = new ImageFile(file);
            return img;
        }

        private VideoFile AddVideo(string file)
        {
            VideoFile video = new VideoFile(file);
            return video;
        }

        private MusicFile AddMusic(string file)
        {
            MusicFile music = new MusicFile(file);
            return music;
        }


    }
}
