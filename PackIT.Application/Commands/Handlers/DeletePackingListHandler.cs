using PackIT.Application.Exceptions;
using PackIT.Domain.Repositories;
using PackIT.Shared.Abstractions.Commands;

namespace PackIT.Application.Commands.Handlers;

internal sealed class DeletePackingListHandler : ICommandHandler<DeletePackingList>
{
	private readonly IPackingListRepository _repository;

	public DeletePackingListHandler(IPackingListRepository repository)
	{
		_repository = repository;
	}

	public async Task HandleAsync(DeletePackingList command)
	{
		var packingList = await _repository.GetByIdAsync(command.Id);
		if (packingList is null)
		{
			throw new PackingListNotFoundException(command.Id);
		}

		await _repository.DeleteAsync(packingList);
	}
}