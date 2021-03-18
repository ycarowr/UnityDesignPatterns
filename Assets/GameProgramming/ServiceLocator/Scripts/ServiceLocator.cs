using System;
using System.Collections.Generic;

namespace ServiceLocatorExample
{
    /// <summary>
    ///  All available services must implement this interface. 
    /// </summary>
    public interface IService
    {
    }

    public static class ServiceLocator
    {
        private static readonly Dictionary<Type, object> _registry = new Dictionary<Type, object>();

        /// <summary>
        ///     Returns null in case the service is not registered or services not initialized.
        /// </summary>
        public static T GetService<T>() where T : class
        {
            var type = typeof(T);
            var containsService = _registry.ContainsKey(type);
            return containsService ? _registry[type] as T : null;
        }

        /// <summary>
        ///     Registers a service in the list.
        /// </summary>
        public static void RegisterService<T>(IService service) where T : IService
        {
            var type = typeof(T);
            _registry[type] = service;
        }

        /// <summary>
        ///     UnRegisters a service in the list.
        /// </summary>
        private static void UnRegisterService<T>() where T : IService
        {
            var type = typeof(T);
            _registry.Remove(type);
        }
    }
}