using System.Collections.Generic;

namespace Training.Application.Albums
{
    public interface IAlbumService
    {
        IEnumerable<AlbumDto> Get();
        AlbumDto Get(string id);
        void Create(AlbumDto album);
    }
}