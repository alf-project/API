using ALF.API.Catalog.Infrastructure.Models.Base;

namespace ALF.API.Catalog.Infrastructure.Models
{
    public interface IContactModel : ICollectionItemModelBase
    {
        IPersonModel Person { get; set; }
    }
}
