using Dal.Models;
using DAL.DbContext;

namespace Dal.DbContext
{
    public interface IRepository<TModel>
    {
        #region Get

        public TModel GetProviderGroups();

        #endregion

        #region Insert
        // some code

        #endregion

        #region Update
        // some code

        #endregion

        #region Delete
        // some code

        #endregion
    }
}
