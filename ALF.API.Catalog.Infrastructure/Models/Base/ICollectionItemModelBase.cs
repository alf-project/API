using System;

namespace ALF.API.Catalog.Infrastructure.Models.Base
{
    public interface ICollectionItemModelBase : IRelatedModelBase<Guid, Guid>
    {
        bool IsPrimary { get; set; }
    }
}
