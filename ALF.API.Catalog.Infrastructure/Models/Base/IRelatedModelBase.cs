namespace ALF.API.Catalog.Infrastructure.Models.Base
{
    public interface IRelatedModelBase<TKey, TRelatedKey> : IModelBase<TKey>
    {
        TRelatedKey RelatedId { get; set; }
    }
}
