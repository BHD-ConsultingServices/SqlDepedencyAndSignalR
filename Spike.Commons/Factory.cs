
namespace Spike.Commons
{
    using Microsoft.Practices.Unity;
    using Microsoft.Practices.Unity.Configuration;
    using System;
    public static class Factory
    {
        public static T CreateInstance<T>()
        {
            try
            {
            var container = new UnityContainer();
            container.LoadConfiguration();

            var resolvedObject = container.Resolve<T>();

            return resolvedObject;

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
