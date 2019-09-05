namespace ALF.API.Catalog.Infrastructure.Models.Base
{
    public interface IModelBase<Key>
    {
        Key Id { get; set; }
    }
}
