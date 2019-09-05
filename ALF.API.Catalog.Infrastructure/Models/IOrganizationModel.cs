using ALF.API.Catalog.Infrastructure.Models.Base;
using System;

namespace ALF.API.Catalog.Infrastructure.Models
{
    public interface IOrganizationModel : IModelBase<Guid>
    {
        string Title { get; set; }
    }
}
