using System.Collections.Generic;
using System;

namespace Exspectans.DependencyInjection
{
    public class DependenciesCollection
    {
        private Dictionary<Type, Dependency> dependencies = new();
        private Dictionary<Type, object> singletons = new();

        public void Add(Dependency dependency) => dependencies.Add(dependency.Type, dependency);

        public object Get(Type type)
        {
            if (!dependencies.ContainsKey(type))
            {
                throw new ArgumentException($"Type is not a dependency: {type.FullName}");
            }

            var dependency = dependencies[type];
            if (dependency.IsSingleton)
            {
                if (!singletons.ContainsKey(type))
                {
                    singletons.Add(type, dependency.Factory());
                }
                return singletons[type];
            }
            else
            {
                return dependency.Factory();
            }
        }

        public T Get<T>()
        {
            return (T)Get(typeof(T));
        }
    }
}