using System;
using ALF.API.Catalog.Infrastructure.Models;

namespace ALF.API.Catalog.Function.Models
{
    public sealed class OrganizationModel : IOrganizationModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
    }
}
