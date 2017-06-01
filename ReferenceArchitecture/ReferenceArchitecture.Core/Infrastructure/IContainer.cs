using System;
namespace ReferenceArchitecture.Core.Infrastructure
{
	public interface IContainer
	{
		void Register<TTypeToResolve, TConcrete>(LifeCycle lifeCycle = LifeCycle.Singleton);
		TTypeToResolve Resolve<TTypeToResolve>();
		object Resolve(Type typeToResolve);
	}
}
