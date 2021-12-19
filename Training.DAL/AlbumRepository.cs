using System;
using System.Collections.Generic;
using Training.Core.Repositories;
using Training.Core.Models;
using System.Linq;
using Training.DAL.Context;

namespace Training.DAL
{
    public class AlbumRepository: IAlbumRepository
    {
        private readonly TrainingDbContext _trainingDbContext;
        public AlbumRepository(TrainingDbContext trainingDbContext)
        {
            _trainingDbContext = trainingDbContext;
        }

        public void Create(Album album)
        {
            _trainingDbContext.Albums
                .Add(album);
        }

        public IEnumerable<Album> Get()
        {
            return _trainingDbContext.Albums.Where(x => !x.IsDeleted);
        }

        public Album Get(string id)
        {
            return _trainingDbContext.Albums.FirstOrDefault(x => x.Id.ToString() == id);

        }
    }
}
