using System;
using System.Collections.Generic;
using System.Text;

namespace Autofac.Integration.ServiceFabric
{
    internal class ServiceFabricRegistrationCreator
    {
        private readonly Action<ILifetimeScope> _creator;

        public ServiceFabricRegistrationCreator(Action<ILifetimeScope> creator)
        {
            _creator = creator;
        }

        public void ExecuteCreator(ILifetimeScope scope)
        {
            _creator(scope);
        }
    }
}
