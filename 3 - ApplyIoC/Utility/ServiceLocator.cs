using System;
using System.Collections.Generic;

namespace Utility
{
    /// <summary>
    /// Этот класс может быть заменет утилитами:
    ///    - StructureMap (AltDotNet)
    ///    - Castle Windsor (AltDotNet)
    ///    - Unity (Microsoft P&P)
    ///    - Ninject (open source)
    /// </summary>
    public static class ServiceLocator
    {
        private static readonly Dictionary<Type, Type> services = new Dictionary<Type, Type>();

        public static void RegisterService<T>(Type service)
        {
            services[typeof (T)] = service;
        }

        public static T Resolve<T>()
        {
            return (T) Activator.CreateInstance(services[typeof (T)]);
        }
    }
}