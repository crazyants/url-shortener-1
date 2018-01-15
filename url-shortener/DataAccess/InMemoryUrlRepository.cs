﻿using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading.Tasks;

namespace url_shortener.DataAccess
{
    public class InMemoryUrlRepository : IUrlRepository
    {
        private ConcurrentDictionary<string, string> repo;

        public InMemoryUrlRepository()
        {
            this.repo = new ConcurrentDictionary<string, string>();
        }

        public Uri Get(string path)
        {
            if (repo.TryGetValue(path, out string url))
            {
                // TODO: check the url is valid, just in case.
                return new Uri(url);
            }
            return null;
        }

        public bool Save(string path, Uri url)
        {
            if(!repo.TryAdd(path, url.ToString()))
            {
                return false;
            }
            return true;
        }
    }
}
