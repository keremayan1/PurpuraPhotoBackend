using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class AlbumStatusManager : IAlbumStatusService
    {
        private readonly IAlbumStatusDal _albumStatusDal;

        public AlbumStatusManager(IAlbumStatusDal albumStatusDal)
        {
            _albumStatusDal = albumStatusDal;
        }

        public async Task<IResult> Add(AlbumStatus AlbumStatus)
        {
            await _albumStatusDal.AddAsync(AlbumStatus);
            return new SuccessResult();
        }

        public async Task<IResult> Delete(Guid id)
        {
            var getId = await _albumStatusDal.GetAsync(x => x.Id == id);
            if (getId == null)
                return new ErrorResult("Album Status is not found");

            await _albumStatusDal.DeleteAsync(getId);
            return new SuccessResult();

        }

        public Task<IDataResult<List<AlbumStatus>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<AlbumStatus>> GetById(int AlbumStatusId)
        {
            throw new NotImplementedException();
        }

        public async Task<IResult> Update(AlbumStatus AlbumStatus)
        {
            var getId = await _albumStatusDal.GetAsync(x => x.Id == AlbumStatus.Id);
            if (getId == null)
                return new ErrorResult("Album Status is not found");

            getId.AlbumStatusName = AlbumStatus.AlbumStatusName;

            await _albumStatusDal.UpdateAsync(getId);
            return new SuccessResult();
        }
    }
}
