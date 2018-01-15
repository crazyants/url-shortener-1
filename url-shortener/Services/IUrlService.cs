﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace url_shortener.Services
{
    public interface IUrlService
    {
        /// <summary>
        /// Get the url that maps to the given one.
        /// </summary>
        /// <param name="uri"></param>
        /// <returns>The mapped url, or null if none exists.</returns>
        Uri Get(Uri uri);
        Uri ShortenAndSave(Uri url);
    }
}
