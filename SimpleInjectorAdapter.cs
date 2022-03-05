using Remnant.Dependency.Interface;
using System;

namespace Remnant.Dependency.SimpleInjector
{
	public class SimpleInjectorAdapter : IContainer
	{
		private readonly global::SimpleInjector.Container _container;

		public SimpleInjectorAdapter(global::SimpleInjector.Container container)
		{
			if (container == null)
				throw new ArgumentNullException(nameof(container));

			_container = container;
		}

		public IContainer Clear()
		{
			throw new NotSupportedException("SimpleInjector does not support 'Clear'.");
		}

		public IContainer DeRegister<TType>() where TType : class
		{
			throw new NotSupportedException("Deregister not supported for SimpleInjector.");
		}

		public IContainer DeRegister(object instance)
		{
			throw new NotSupportedException("Deregister not supported for SimpleInjector.");
		}

		public IContainer Register(Type type, object instance)
		{
			_container.RegisterInstance(type, instance);
			return this;
		}

		public IContainer Register(object instance)
		{
			_container.RegisterSingleton(() => instance);
			return this;
		}

		public IContainer Register<TType>(object instance) where TType : class
		{
			_container.RegisterSingleton<TType>(() => instance as TType);
			return this;
		}

		public IContainer Register<TType>() where TType : class, new()
		{
			_container.RegisterSingleton(() => new TType());
			return this;
		}

		public IContainer Register<TType, TObject>()
			where TType : class
			where TObject : class, new()
		{
			_container.RegisterSingleton<TType>(() => new TObject() as TType);
			return this;
		}

		public TType ResolveInstance<TType>() where TType : class
		{
			return _container.GetInstance<TType>();
		}
	}
}
