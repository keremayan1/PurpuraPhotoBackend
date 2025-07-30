using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class AlbumManager : IAlbumService
    {
        private readonly IAlbumDal _albumDal;
        public AlbumManager(IAlbumDal albumDal)
        {
            _albumDal = albumDal;
        }
        public async Task<IResult> Add(Album album)
        {
            await _albumDal.AddAsync(album);
            return new SuccessResult();
        }

        public async Task<IResult> Delete(Guid id)
        {
            var getId = await _albumDal.GetAsync(x=> x.Id == id);
            if (getId == null)
                return new ErrorResult("Album is not found");
            await _albumDal.DeleteAsync(getId);
            return new SuccessResult();
        }

        public Task<IDataResult<List<Album>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<Album>> GetById(int AlbumId)
        {
            throw new NotImplementedException();
        }

        public async Task<IResult> Update(Album album)
        {
            var getId = await _albumDal.GetAsync(x=> x.Id == album.Id);
            if(getId == null)
                return new ErrorResult("Album is not found");
            getId.AlbumName = album.AlbumName;
            getId.StartedDate = album.StartedDate;
            getId.EndDate= album.EndDate;
            getId.PhotographerNote = album.PhotographerNote;
            getId.Note = album.Note;
            getId.SelectedCount = album.SelectedCount;
            getId.IsDraft = album.IsDraft;
            getId.IsSend= album.IsSend;
            getId.IsViewed = album.IsViewed;
            getId.IsProcessed = album.IsProcessed;
            getId.IsCompleted = album.IsCompleted;
            await _albumDal.UpdateAsync(getId);
            return new SuccessResult();
        }
    }
}
