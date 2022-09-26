using PackIT.Shared.Abstractions.Exceptions;

namespace PackIT.Domain.Exceptions;

public sealed class EmptyPackingListNameException : PackItException
{
	public EmptyPackingListNameException() : base("Packing list name is empty")
	{
	}
}