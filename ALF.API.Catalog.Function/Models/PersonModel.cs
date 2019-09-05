using System;
using ALF.API.Catalog.Infrastructure.Models;

namespace ALF.API.Catalog.Function.Models
{
    public sealed class PersonModel : IPersonModel
    {
        public Guid Id { get; set; }
        public Guid RelatedId { get; set; }
        public bool IsPrimary { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
    }
}
