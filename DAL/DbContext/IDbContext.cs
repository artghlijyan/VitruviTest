using System;

namespace DAL.DbContext
{
    public interface IDbContext
    {
        public string ConnectionString { get; }
    }
}
