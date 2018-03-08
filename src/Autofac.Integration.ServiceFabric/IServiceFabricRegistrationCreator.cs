namespace Autofac.Integration.ServiceFabric
{
    public interface IServiceFabricRegistrationCreator
    {
        void ExecuteCreator(ILifetimeScope scope);
    }
}
