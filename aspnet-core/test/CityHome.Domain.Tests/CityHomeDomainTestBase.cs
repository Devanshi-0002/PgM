﻿using Volo.Abp.Modularity;

namespace CityHome;

/* Inherit from this class for your domain layer tests. */
public abstract class CityHomeDomainTestBase<TStartupModule> : CityHomeTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
