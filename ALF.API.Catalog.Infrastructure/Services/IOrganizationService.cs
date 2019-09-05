﻿using System;
using ALF.API.Catalog.Infrastructure.Models;
using ALF.API.Catalog.Infrastructure.Services.Base;

namespace ALF.API.Catalog.Infrastructure.Services
{
    public interface IOrganizationService : IStandaloneCatalogServiceBase<IOrganizationModel, Guid>
    {
    }
}
