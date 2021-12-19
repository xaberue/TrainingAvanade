using System;
using System.Collections.Generic;
using Training.Core.Models;

namespace Training.Core.Repositories
{
    public interface IAlbumRepository
    {
        IEnumerable<Album> Get();
        Album Get(string id);
        void Create(Album album);
    }
}
