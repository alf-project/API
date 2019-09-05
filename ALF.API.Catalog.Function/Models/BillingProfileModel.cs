using System;
using ALF.API.Catalog.Infrastructure.Models;

namespace ALF.API.Catalog.Function.Models
{
    public sealed class BillingProfileModel : IBillingProfileModel
    {
        public Guid Id { get; set; }
        public Guid RelatedId { get; set; }
        public bool IsPrimary { get; set; }
        public string Beneficiary { get; set; }
        public string TaxId { get; set; }
        public string IBAN { get; set; }
    }
}
