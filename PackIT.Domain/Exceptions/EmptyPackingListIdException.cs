using PackIT.Shared.Abstractions.Exceptions;

namespace PackIT.Domain.Exceptions;

public class EmptyPackingListIdException : PackItException
{
	public EmptyPackingListIdException() : base("Packing list id can't be empty")
	{
	}
}