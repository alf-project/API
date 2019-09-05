using ALF.API.Catalog.Infrastructure.Models.Base;

namespace ALF.API.Catalog.Infrastructure.Models
{
    public interface IBillingProfileModel : ICollectionItemModelBase
    {
        string Beneficiary { get; set; }
        string TaxId { get; set; }
        string IBAN { get; set; }
    }
}
