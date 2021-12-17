using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Core.Models;
using Training.Core.Repositories;

namespace Training.DAL
{
    public class AlbumRepository : IAlbumRepository
    {
        private readonly TrainingDbContext _trainingDbContext;


        public AlbumRepository(TrainingDbContext trainingDbContext)
        {
            _trainingDbContext = trainingDbContext;
        }

        public void Create(Album album)
        {
            _trainingDbContext.Albums.Add(album);
        }

        public IEnumerable<Album> Get()
        {
            return _trainingDbContext.Albums.Where(x => !x.IsDeleted);
        }

        public Album Get(string title)
        {
            return _trainingDbContext.Albums.FirstOrDefault(x => x.Title == title);
        }

        public void Update(Album album)
        {
            _trainingDbContext.Albums.Update(album);
        }
    }
}
