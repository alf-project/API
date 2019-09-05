using ALF.API.Catalog.Infrastructure.Models;
using Microsoft.Azure.Cosmos.Table;
using System;

namespace ALF.API.Catalog.Data.AzureStorage.Models
{
    public sealed class EmailTableModel : TableEntity, IEmailModel
    {
        public EmailTableModel()
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
        public IPersonModel Person { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool IsPrimary { get; set; }
        public string EMail { get; set; }
    }
}
