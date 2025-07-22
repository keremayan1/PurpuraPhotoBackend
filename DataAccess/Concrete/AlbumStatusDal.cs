using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Context;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class AlbumStatusDal : EfEntityRepository<AlbumStatus, SQLContext>, IAlbumStatusDal
    {
    }
}
