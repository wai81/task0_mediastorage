﻿using System;
using System.Collections.Generic;
using System.Text;

namespace mediastorage.Classes
{
    public abstract class BaseMediaStorage

    {

        public Guid Id { get; private set; }

        public string NameFile { get; set; }

    }
}