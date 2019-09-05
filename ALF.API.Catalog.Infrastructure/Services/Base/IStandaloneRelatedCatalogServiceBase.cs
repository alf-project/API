using ALF.API.Catalog.Infrastructure.Models.Base;

namespace ALF.API.Catalog.Infrastructure.Services.Base
{
    public interface IStandaloneRelatedCatalogServiceBase<TEntity, in TKey, in TRelatedKey> : IStandaloneCatalogServiceBase<TEntity, TKey>, IRelatedCatalogServiceBase<TEntity, TKey, TRelatedKey>
        where TEntity : IRelatedModelBase<TKey, TRelatedKey>
    {
        
    }
}
