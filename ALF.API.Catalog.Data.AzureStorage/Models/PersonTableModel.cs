using ALF.API.Catalog.Infrastructure.Models;
using Microsoft.Azure.Cosmos.Table;
using System;

namespace ALF.API.Catalog.Data.AzureStorage.Models
{
    public sealed class PersonTableModel : TableEntity, IPersonModel
    {
        public PersonTableModel()
            : base()
        {
        }

        [IgnoreProperty]
        public Guid Id
        {
            get => Guid.Parse(RowKey);
            set => RowKey = value.ToString("N");
        }

        [IgnoreProperty]
        public Guid RelatedId
        {
            get => Guid.Parse(PartitionKey);
            set => PartitionKey = value.ToString("N");
        }

        [IgnoreProperty]
        public IOrganizationModel Organization { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public bool IsPrimary { get; set; }
    }
}
