﻿using System;
using System.Data.Entity;

namespace Infobasis.Data.DataMultitenant
{
    public class EntityFrameworkConfiguration : DbConfiguration
    {
        public EntityFrameworkConfiguration()
        {
            AddInterceptor(new TenantCommandInterceptor());
            AddInterceptor(new TenantCommandTreeInterceptor());
        }

    }
}