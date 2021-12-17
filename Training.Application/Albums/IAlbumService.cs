using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Application.Albums
{
    public interface IAlbumService
    {
        IEnumerable<AlbumDto> Get();
        AlbumDto Get(string title);
        void Update(AlbumDto dto);
        void Create(AlbumDto dto);
        void Delete(string title);
    }
}
