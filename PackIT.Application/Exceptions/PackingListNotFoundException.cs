using PackIT.Shared.Abstractions.Exceptions;

namespace PackIT.Application.Exceptions;

public class PackingListNotFoundException : PackItException
{
	public PackingListNotFoundException(Guid id) : base($"Packing list with id: {id} not found")
	{
	}
}