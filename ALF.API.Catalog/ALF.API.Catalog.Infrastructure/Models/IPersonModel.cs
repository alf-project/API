using ALF.API.Catalog.Infrastructure.Models.Base;
using System;

namespace ALF.API.Catalog.Infrastructure.Models
{
    public interface IPersonModel : ICollectionItemModelBase
    {
        IOrganizationModel Organization { get; set; }

        string FirstName { get; set; }
        string LastName { get; set; }
        string Role { get; set; }
    }
}
