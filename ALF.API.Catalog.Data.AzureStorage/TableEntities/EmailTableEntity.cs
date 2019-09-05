using System;
using ALF.API.Catalog.Infrastructure.Models;
using Microsoft.Azure.Cosmos.Table;

namespace ALF.API.Catalog.Data.AzureStorage.TableEntities
{
    public sealed class EmailTableEntity : TableEntity, IEmailModel
    {
        public EmailTableEntity()
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

        public bool IsPrimary { get; set; }
        public string EMail { get; set; }
    }
}
