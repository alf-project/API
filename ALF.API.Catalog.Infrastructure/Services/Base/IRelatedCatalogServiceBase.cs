using System.Collections.Generic;
using System.Threading.Tasks;
using ALF.API.Catalog.Infrastructure.Models.Base;

namespace ALF.API.Catalog.Infrastructure.Services.Base
{
    public interface IRelatedCatalogServiceBase<TEntity, in TKey, in TRelatedKey>
        where TEntity : IRelatedModelBase<TKey, TRelatedKey>
    {
        Task<IEnumerable<TEntity>> GetByRelatedIdAsync(TRelatedKey id);
        Task DeleteByRelatedIdAsync(TRelatedKey id);
    }
}
