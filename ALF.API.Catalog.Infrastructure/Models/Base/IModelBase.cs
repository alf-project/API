namespace ALF.API.Catalog.Infrastructure.Models.Base
{
    public interface IModelBase<TKey>
    {
        TKey Id { get; set; }
    }
}
