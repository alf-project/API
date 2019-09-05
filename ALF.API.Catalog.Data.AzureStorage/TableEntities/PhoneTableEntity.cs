using System;
using ALF.API.Catalog.Infrastructure.Models;
using Microsoft.Azure.Cosmos.Table;

namespace ALF.API.Catalog.Data.AzureStorage.TableEntities
{
    public sealed class PhoneTableEntity : TableEntity, IPhoneModel
    {
        public PhoneTableEntity()
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

        public string Phone { get; set; }
        public bool IsPrimary { get; set; }
    }
}
