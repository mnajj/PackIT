using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using PackIT.Shared.Abstractions.Commands;
using PackIT.Shared.Abstractions.Queries;
using PackIT.Shared.Commands;

namespace PackIT.Shared.Queries;

public static class Extensions
{
	public static IServiceCollection AddQueries(this IServiceCollection services)
	{
		var assembly = Assembly.GetCallingAssembly();
		services.AddSingleton<IQueryDispatcher, InMemoryQueryDispatcher>();
		services.Scan(s => s
			.FromAssemblies(assembly)
			.AddClasses(c => c.AssignableTo(typeof(IQueryHandler<,>)))
			.AsImplementedInterfaces()
			.WithScopedLifetime());
		return services;
	}
}