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
        public TypeMediaFile TypeFile { get; private set; }

        public MediaFile(string nameFile)
        {
            NameFile = nameFile;
            File = new FileInfo(nameFile);
            TypeFile = GetTypeFile(File);
        }

        private dynamic GetTypeFile(FileInfo file)
        {

            string _typeFile = file.Extension.ToLower();
            if (_typeFile == ".mp3")
            {
                return TypeMediaFile.Music;
            }
            else if (_typeFile == ".jpg" || _typeFile == ".png" || _typeFile == ".jpeg")
            {
                return TypeMediaFile.Image;
            }
            else if (_typeFile == ".avi" || _typeFile == ".mpg" || _typeFile == ".mp4")
            {
                return TypeMediaFile.Movie;
            }
            else
                return null;
        }


        public List<MediaFile> GetListByTypeFile(TypeMediaFile typeFile)
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

            if (file.TypeFile == TypeMediaFile.Music || file.TypeFile == TypeMediaFile.Movie)
            {
                RunPlayFile(file);
            }
            else if (file.TypeFile == TypeMediaFile.Image)
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