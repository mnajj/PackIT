using PackIT.Application.Dtos;
using PackIT.Domain.Repositories;
using PackIT.Shared.Abstractions.Queries;

namespace PackIT.Application.Queries.Handlers;

internal sealed class GetPackingListHandler : IQueryHandler<GetPackingList, PackingListDto>
{
	private readonly IPackingListRepository _repository;

	public GetPackingListHandler(IPackingListRepository repository)
	{
		_repository = repository;
	}

	public async Task<PackingListDto> HandleAsync(GetPackingList query)
	{
		var packingList = await _repository.GetByIdAsync(query.Id);
	}
}