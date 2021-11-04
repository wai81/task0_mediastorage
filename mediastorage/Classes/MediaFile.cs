using MediaStorage.Enums;
using MediaStorage.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MediaStorage.Classes
{
    public class MediaFile : BaseMediaStorage, IMediaFile
    {
        public FileInfo File { get; private set; }

        public MediaCategory Category { get; private set; }

        public MediaFile(string nameFile)
        {
            NameFile = nameFile;
            File = new FileInfo(nameFile);
            Category = GetTypeFile(File);
        }

        private dynamic GetTypeFile(FileInfo file)
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
                return null;
        }

        public List<MediaFile> GetListByTypeFile(MediaCategory category)
        {
            throw new NotImplementedException();
        }

        public List<MediaFile> GetAllFiles()
        {
            throw new NotImplementedException();
        }

        public List<PlayList> SeachFile(string name)
        {
            throw new NotImplementedException();
        }

        public void PlayFile(MediaFile file)
        {
            if (file.Category == MediaCategory.Music || file.Category == MediaCategory.Movie)
            {
                RunPlayFile(file);
            }
            else if (file.Category == MediaCategory.Image)
            {
                RunViewFile(file);
            }
        }

        private void RunViewFile(MediaFile file)
        {

        }

        private void RunPlayFile(MediaFile file)
        {

        }

        public MediaFile AddFile(string nameFile)
        {
            throw new NotImplementedException();
        }

        public void RemoveFile(MediaFile file)
        {

        }
    }
}