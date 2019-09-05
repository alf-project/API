using System.Collections.Generic;
using System.Threading.Tasks;
using ALF.API.Catalog.Infrastructure.Models.Base;

namespace ALF.API.Catalog.Infrastructure.Services.Base
{
    public interface IStandaloneCatalogServiceBase<TEntity, in TKey>
        where TEntity : IModelBase<TKey>
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(TKey id);
        Task<TEntity> CreateAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task DeleteByIdAsync(TKey id);
    }
}
