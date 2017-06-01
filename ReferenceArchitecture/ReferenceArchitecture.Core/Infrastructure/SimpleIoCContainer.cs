using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ReferenceArchitecture.Core.Infrastructure
{
	public class SimpleIoCContainer : IContainer
	{
		readonly IList<RegisteredObject> registeredObjects = new List<RegisteredObject>();

		public void Register<TTypeToResolve, TConcrete>(LifeCycle lifeCycle = LifeCycle.Singleton)
		{
			registeredObjects.Add(new RegisteredObject(typeof(TTypeToResolve), typeof(TConcrete), lifeCycle));
		}

		public TTypeToResolve Resolve<TTypeToResolve>()
		{
			return (TTypeToResolve)ResolveObject(typeof(TTypeToResolve));
		}

		public object Resolve(Type typeToResolve)
		{
			return ResolveObject(typeToResolve);
		}

		object ResolveObject(Type typeToResolve)
		{
			var registeredObject = registeredObjects.FirstOrDefault(o => o.TypeToResolve == typeToResolve);
			if (registeredObject == null)
			{
				throw new TypeNotRegisteredException(string.Format(
					"The type {0} has not been registered", typeToResolve.Name));
			}
			return GetInstance(registeredObject);
		}

		object GetInstance(RegisteredObject registeredObject)
		{
			if (registeredObject.Instance == null ||
				registeredObject.LifeCycle == LifeCycle.Transient)
			{
				var parameters = ResolveConstructorParameters(registeredObject);
				registeredObject.CreateInstance(parameters.ToArray());
			}
			return registeredObject.Instance;
		}

		bool HasInstance(Type typeToResolve)
		{
			return registeredObjects.FirstOrDefault(o => o.TypeToResolve == typeToResolve) != null;
		}

		IEnumerable<object> ResolveConstructorParameters(RegisteredObject registeredObject)
		{
			var info = registeredObject.ConcreteType.GetTypeInfo();
			foreach (var constructor in info.DeclaredConstructors)
			{
				if (constructor.GetParameters().Count() == 0)
					continue;

				var canFillAllParameters = constructor.GetParameters().All(p => HasInstance(p.ParameterType));

				if (!canFillAllParameters)
					continue;

				foreach (var parameter in constructor.GetParameters())
				{
					yield return ResolveObject(parameter.ParameterType);
				}
			}
		}
	}
}
