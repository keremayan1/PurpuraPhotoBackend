using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IAlbumStatusService
    {
        Task<IDataResult<List<AlbumStatus>>> GetAll();
        Task<IDataResult<AlbumStatus>> GetById(int AlbumStatusId);
        Task<IResult> Add(AlbumStatus AlbumStatus);
        Task<IResult> Update(AlbumStatus AlbumStatus);
        Task<IResult> Delete(Guid id);
    }
}
