using System;
using ALF.API.Catalog.Infrastructure.Models;

namespace ALF.API.Catalog.Function.Models
{
    public sealed class PhoneModel : IPhoneModel
    {
        public Guid Id { get; set; }
        public Guid RelatedId { get; set; }
        public bool IsPrimary { get; set; }
        public string Phone { get; set; }
    }
}
