using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Application.Base;
using Training.Core.Models;
using Training.Core.Repositories;

namespace Training.Application.Albums
{
    public class AlbumService : ServiceBase, IAlbumService
    {
        private readonly IAlbumRepository _albumRepository;
        public AlbumService(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
            _albumRepository = unitOfWork.AlbumRepository;
        }

        public void Create(AlbumDto dto)
        {
            var album = Map(dto);

            album.Id = Guid.NewGuid();

            _albumRepository.Create(album);
            _unitOfWork.CommitTransaction();
        }

        public void Delete(string title)
        {
            var album = _albumRepository.Get(title);

            album.IsDeleted = true;

            _albumRepository.Update(album);
            _unitOfWork.CommitTransaction();
        }

        public IEnumerable<AlbumDto> Get()
        {
            return _albumRepository.Get().Select(MapEntity);
        }

        public AlbumDto Get(string title)
        {
            return MapEntity(_albumRepository.Get(title));
        }

        public void Update(AlbumDto dto)
        {
            var album = _albumRepository.Get(dto.Title);

            album.Title = dto.Title;
            album.Author = dto.Author;

            _albumRepository.Update(album);
            _unitOfWork.CommitTransaction();
        }
        private Album Map(AlbumDto dto)
        {
            return new Album
            {
                Title = dto.Title,
                Author = dto.Author
            };
        }
        private AlbumDto MapEntity(Album album)
        {
            return new AlbumDto
            {
                Title = album.Title,
                Author = album.Author
            };
        }
    }
}
