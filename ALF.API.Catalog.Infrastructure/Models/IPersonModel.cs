using ALF.API.Catalog.Infrastructure.Models.Base;

namespace ALF.API.Catalog.Infrastructure.Models
{
    public interface IPersonModel : ICollectionItemModelBase
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Role { get; set; }
    }
}
