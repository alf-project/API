using System;
using ALF.API.Catalog.Infrastructure.Models;
using Microsoft.Azure.Cosmos.Table;

namespace ALF.API.Catalog.Data.AzureStorage.TableEntities
{
    public sealed class OrganizationTableEntity : TableEntity, IOrganizationModel
    {
        public OrganizationTableEntity()
            : base()
        {
            PartitionKey = string.Empty;
        }

        [IgnoreProperty]
        public Guid Id
        {
            get => Guid.Parse(RowKey);
            set => RowKey = value.ToString("N");
        }

        public string Title { get; set; }
    }
}
