﻿using MyWarehouse.Infrastructure.Authentication.Core.Model;
using System.Collections.Generic;

namespace MyWarehouse.Infrastructure.Authentication.Core.Services
{
    public interface ITokenService
    {
        TokenModel CreateAuthenticationToken(string userId, string userName, IEnumerable<(string claimType, string claimValue)> customClaims = null);
    }
}
