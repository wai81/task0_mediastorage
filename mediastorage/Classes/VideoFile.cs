﻿using MediaStorage.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MediaStorage.Classes
{
    public class VideoFile : BaseMedia
    {
        public VideoFile(string nameFile)
        {
            NameFile = nameFile;
        }
    }
}