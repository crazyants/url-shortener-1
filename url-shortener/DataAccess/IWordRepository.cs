﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace url_shortener.DataAccess
{
    public interface IWordRepository
    {
        string RandomNoun();
        string RandomAdjective();
    }
}
