using ALF.API.Catalog.Infrastructure.Models;
using Microsoft.Azure.Cosmos.Table;
using System;

namespace ALF.API.Catalog.Data.AzureStorage.Models
{
    public sealed class OrganizationTableModel : TableEntity, IOrganizationModel
    {
        public OrganizationTableModel()
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
