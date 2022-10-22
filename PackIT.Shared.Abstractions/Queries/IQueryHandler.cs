using System.Threading.Tasks;

namespace PackIT.Shared.Abstractions.Queries;

public interface IQueryHandler<TQuery, TResult> where TQuery : class, IQuery<TResult>
{
	Task<TResult> HandleAsync(TQuery query);
}