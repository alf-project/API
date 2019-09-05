namespace ALF.API.Catalog.Infrastructure.Models.Base
{
    public interface IRelatedModelBase<Key, RelatedKey> : IModelBase<Key>
    {
        RelatedKey RelatedId { get; set; }
    }
}
