using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IAlbumService
    {
        Task<IDataResult<List<Album>>> GetAll();
        Task<IDataResult<Album>> GetById(int AlbumId);
        Task<IResult> Add(Album album);
        Task<IResult> Update(Album album);
        Task<IResult> Delete(Guid id);
    }
}
