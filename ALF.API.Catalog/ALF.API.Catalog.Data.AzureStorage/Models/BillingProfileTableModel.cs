using ALF.API.Catalog.Infrastructure.Models;
using Microsoft.Azure.Cosmos.Table;
using System;

namespace ALF.API.Catalog.Data.AzureStorage.Models
{
    public sealed class BillingProfileTableModel : TableEntity, IBillingProfileModel
    {
        public BillingProfileTableModel()
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

        public string Beneficiary { get; set; }
        public string TaxId { get; set; }
        public string IBAN { get; set; }
        public bool IsPrimary { get; set; }
    }
}
