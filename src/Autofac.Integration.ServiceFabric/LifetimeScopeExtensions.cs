using System;
using System.Collections.Generic;
using System.Text;

namespace Autofac.Integration.ServiceFabric
{
    public static class LifetimeScopeExtensions
    {
        public static void CreateServiceFabricRegistrations(this ILifetimeScope scope)
        {
            var creators = scope.Resolve<List<ServiceFabricRegistrationCreator>>();
            foreach (var creator in creators)
            {
                creator.ExecuteCreator(scope);
            }
        }
    }
}
