using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace mediastorage
{
    public class MediaFile : BaseMediaStorage
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

        private MediaFile GetFileById(Guid id)
        {
            throw new System.NotImplementedException();
        }

        public List<MediaFile> GetListByTypeFile(TypeMediaFile typeFile) 
        {
            throw new System.NotImplementedException();
        }

        public List<MediaFile> GetListAllFiles()
        {
            throw new System.NotImplementedException();
        }

        public List<PlayList> SeachFile(string name)
        {
            throw new System.NotImplementedException();
        }

        public void PlayFile(Guid id)
        {
            MediaFile file = GetFileById(id);   

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
            throw new NotImplementedException();
        }

        private void RunPlayFile(MediaFile file)
        {
            throw new NotImplementedException();
        }
    }
}