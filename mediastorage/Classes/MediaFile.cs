using mediastorage.Enums;
using mediastorage.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace mediastorage.Classes
{
    public class MediaFile : BaseMediaStorage, IMediaFile
    {


        public FileInfo File { get; private set; }
        public Category Category { get; private set; }

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
                return Category.Music;
            }
            else if (typeFile == ".jpg" || typeFile == ".png" || typeFile == ".jpeg")
            {
                return Category.Image;
            }
            else if (typeFile == ".avi" || typeFile == ".mpg" || typeFile == ".mp4")
            {
                return Category.Movie;
            }
            else
                return null;
        }


        public List<MediaFile> GetListByTypeFile(Category category)
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

            if (file.TypeFile == Category.Music || file.TypeFile == Category.Movie)
            {
                RunPlayFile(file);
            }
            else if (file.TypeFile == Category.Image)
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