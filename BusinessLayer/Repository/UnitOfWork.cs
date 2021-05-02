using DataAccessLayer;
using System;

namespace BusinessLayer.Repository
{
    public class UnitOfWork : IDisposable
    {
        private readonly StadiumContext _db;

        public UnitOfWork(StadiumContext db)
        {
            _db = db;

        }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
