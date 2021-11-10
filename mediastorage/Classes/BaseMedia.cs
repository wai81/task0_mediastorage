﻿using MediaStorage.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MediaStorage.Classes
{
    public abstract class BaseMedia

    {
        public Guid Id { get; private set; }

        public string NameFile { get; set; }

        
    }
   
}